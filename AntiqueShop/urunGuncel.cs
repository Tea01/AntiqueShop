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
    public partial class urunGuncel : Form
    {
        public urunGuncel()
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
            label_exit.ForeColor = Color.Tan;
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from urun";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGrid_listele.DataSource = ds.Tables[0];
        }

        private void btn_AnaMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm frm = new SellerForm();
            frm.ShowDialog();
        }

        private void urunGuncel_Load(object sender, EventArgs e)
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

        private void btn_guncel_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update urun set urun_adi=@p1, kategori_turu=@p2, urun_fiyati=@p3, urun_tanimi=@p4 where urun_id=@p5", conn);
            komut3.Parameters.AddWithValue("@p1", txt_adi.Text);
            komut3.Parameters.AddWithValue("@p2", box_kategori.SelectedValue.ToString());
            komut3.Parameters.AddWithValue("@p3", int.Parse(txt_fiyat.Text));
            komut3.Parameters.AddWithValue("@p4", txt_tanimi.Text);
            komut3.Parameters.AddWithValue("@p5", int.Parse(text_id.Text));

            komut3.ExecuteNonQuery();

            MessageBox.Show("Güncelleme gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
        }
    }
}
