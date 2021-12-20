using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiqueShop
{
    public partial class urunEkleSatici : Form
    {
        public urunEkleSatici()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=AntiqueShop; user ID=postgres; password=e182a3.,");
        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Black;
        }

        private void btn_Ana_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm frm = new SellerForm();
            frm.ShowDialog();
        }

        private void btn_Ana_Menu_MouseEnter(object sender, EventArgs e)
        {
            btn_Ana_Menu.ForeColor = System.Drawing.Color.LightGray;
        }

        private void btn_Ana_Menu_MouseHover(object sender, EventArgs e)
        {
            btn_Ana_Menu.ForeColor = System.Drawing.Color.LightGray;

        }

        private void urunEkleSatici_Load(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from kategori", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            box_kategori.DisplayMember = "kategori_turu";
            box_kategori.ValueMember = "kategori_turu";
            box_kategori.DataSource = dt;
            conn.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select urun_id from urun where urun_id='"+text_id.Text+"'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            if(dt.Rows.Count>=1)
            {
                MessageBox.Show("Ürün zaten var","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                NpgsqlCommand komut = new NpgsqlCommand("insert into urun (urun_id, urun_adi, kategori_turu, urun_fiyati, urun_tanimi, kategori_id) values (@p1, @p2, @p3, @p4, @p5, @p6)", conn);
                komut.Parameters.AddWithValue("@p1", int.Parse(text_id.Text));
                komut.Parameters.AddWithValue("@p2", txt_adi.Text);
                komut.Parameters.AddWithValue("@p3", box_kategori.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@p4", int.Parse(txt_fiyat.Text));
                komut.Parameters.AddWithValue("@p5", txt_tanimi.Text);
                komut.Parameters.AddWithValue("@p6", int.Parse(txt_kategori_id.Text));

                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün kaydoldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from urun";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGrid_listele.DataSource = ds.Tables[0];
        }
    }
}
