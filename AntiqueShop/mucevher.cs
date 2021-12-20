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
    public partial class mucevher : Form
    {
        public mucevher()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=AntiqueShop; user ID=postgres; password=e182a3.,");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Linen;
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Tan;
        }

        private void btn_sepeteEkle_Click(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select urun_id from sepet_urun where urun_id='" + txt_id.Text + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Ürün zaten var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                NpgsqlCommand komut = new NpgsqlCommand("insert into sepet_urun (sepet_id, urun_id, urun_fiyati, urun_adi) values (@p1,@p2,@p3,@p4)", conn);
                komut.Parameters.AddWithValue("@p1", int.Parse(txt_sepet.Text));
                komut.Parameters.AddWithValue("@p2", int.Parse(txt_id.Text));
                komut.Parameters.AddWithValue("@p3", int.Parse(txt_fiyat.Text));
                komut.Parameters.AddWithValue("@p4", txt_adi.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün kaydoldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btn_AnaMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm frm = new CustomerForm();
            frm.ShowDialog();
        }

        private void mucevher_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from urun where kategori_turu='mucevher'";          //bej kushtin qe te marri vtm nga mobilyet
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGrid_mucevher.DataSource = ds.Tables[0];
        }
    }
}
