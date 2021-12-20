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
using DGVPrinterHelper;

namespace AntiqueShop
{
    public partial class sepet : Form
    {
        public sepet()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=AntiqueShop; user ID=postgres; password=e182a3.,");
        DGVPrinter printer = new DGVPrinter();
        private void sepet_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from sepet_urun";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGrid_sepet.DataSource = ds.Tables[0];

            string comm = "select * from toplamurun()";
            NpgsqlDataAdapter daa = new NpgsqlDataAdapter(comm, conn);
            DataSet dss = new DataSet();
            daa.Fill(dss);
            dataGrid_toplamurun.DataSource = dss.Tables[0];

            
            string comm1 = "select * from toplamfiyat()";
            NpgsqlDataAdapter daa1 = new NpgsqlDataAdapter(comm1, conn);
            DataSet dss1 = new DataSet();
            daa1.Fill(dss1);
            dataGrid_toplamFiyat.DataSource = dss1.Tables[0];
        }

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

        private void btn_ana_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm frm = new CustomerForm();
            frm.ShowDialog();
        }

        private void btn_satin_al_Click(object sender, EventArgs e)
        {
            printer.Title = "Illyria Antika Siparis List ";
            printer.SubTitle = string.Format("Date:{0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGrid_sepet);
        }

        private void btn_cikart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek ister misiniz?.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                conn.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("delete from sepet_urun where urun_id=@p1", conn);
               
                komut2.Parameters.AddWithValue("@p1", int.Parse(txt_cikart.Text));
               
                komut2.ExecuteNonQuery();
              
                MessageBox.Show("Ürün silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                conn.Close();
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from sepet_urun";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGrid_sepet.DataSource = ds.Tables[0];

            string commC = "select * from toplamurun()";
            NpgsqlDataAdapter daaC = new NpgsqlDataAdapter(commC, conn);
            DataSet dssC = new DataSet();
            daaC.Fill(dssC);
            dataGrid_toplamurun.DataSource = dssC.Tables[0];


            string comm1C = "select * from toplamfiyat()";
            NpgsqlDataAdapter daa1 = new NpgsqlDataAdapter(comm1C, conn);
            DataSet dss1C = new DataSet();
            daa1.Fill(dss1C);
            dataGrid_toplamFiyat.DataSource = dss1C.Tables[0];
        }
    }
}
