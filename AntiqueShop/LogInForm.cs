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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Black;
        }
        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            musteriGiris form3 = new musteriGiris();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            saticiGiris form3 = new saticiGiris();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }
    }
}
