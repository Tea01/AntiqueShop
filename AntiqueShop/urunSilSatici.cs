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
    public partial class urunSilSatici : Form
    {
        public urunSilSatici()
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

        private void urunSilSatici_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from urun";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGrid_listele.DataSource = ds.Tables[0];
        }
        private void btn_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from urun";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGrid_listele.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Silmek ister misiniz?.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result==DialogResult.Yes)
            {
                conn.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("delete from urun where urun_id=@p1", conn);
                
                komut2.Parameters.AddWithValue("@p1", int.Parse(text_id.Text));
                
                komut2.ExecuteNonQuery();
                
                MessageBox.Show("Ürün silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                conn.Close();
            }
           
        }

    }
}
