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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panel_subBar.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panel_subBar.Visible == true)
            {
                panel_subBar.Visible = false;
            }
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_categories_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_subBar);
        }

        private void button_mobilya_Click(object sender, EventArgs e)
        {
            this.Hide();
            mobilya frm = new mobilya();
            frm.ShowDialog();
            hideSubMenu();
        }

        private void button_saat_Click(object sender, EventArgs e)
        {
            this.Hide();
            saat frm = new saat();
            frm.ShowDialog();
            hideSubMenu();
        }

        private void button_resim_Click(object sender, EventArgs e)
        {
            this.Hide();
            resim frm = new resim();
            frm.ShowDialog();
            hideSubMenu();
        }

        private void button_kitaplar_Click(object sender, EventArgs e)
        {
            this.Hide();
            kitaplar frm = new kitaplar();
            frm.ShowDialog();
            hideSubMenu();
        }

        private void button_sikke_Click(object sender, EventArgs e)
        {
            this.Hide();
            sikke frm = new sikke();
            frm.ShowDialog();
            hideSubMenu();
        }

        private void btn_mucevher_Click(object sender, EventArgs e)
        {
            this.Hide();
            mucevher frm = new mucevher();
            frm.ShowDialog();
            hideSubMenu();
        }

        private void button_vinylPlak_Click(object sender, EventArgs e)
        {
            this.Hide();
            vinylPlaka frm = new vinylPlaka();
            frm.ShowDialog();
            hideSubMenu();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm frm = new LogInForm();
            frm.ShowDialog();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Wheat;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            urunAraMusteri form3 = new urunAraMusteri();
            form3.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            sepet frm = new sepet();
            frm.ShowDialog();
            this.Show();
        }
    }
}
