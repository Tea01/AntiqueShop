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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseLeave_1(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Tan;

        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm frm = new LogInForm();
            frm.ShowDialog();
        }

        private void btn_Urun_Liste_Click(object sender, EventArgs e)
        {
            this.Hide();
            urunListesiSatici frm = new urunListesiSatici();
            frm.ShowDialog();
        }

        private void btn_Urun_Ekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            urunEkleSatici frm = new urunEkleSatici();
            frm.ShowDialog();
        }

        private void btn_Urun_Sil_Click(object sender, EventArgs e)
        {
            this.Hide();
            urunSilSatici frm = new urunSilSatici();
            frm.ShowDialog();
        }

        private void btn_Urun_Guncel_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Urun_Guncel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            urunGuncel frm = new urunGuncel();
            frm.ShowDialog();
        }

        private void btn_Urun_Ara_Click(object sender, EventArgs e)
        {
            this.Hide();
            urunAraSatici frm = new urunAraSatici();
            frm.ShowDialog();
        }
    }
}
