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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value < 100)
            {
                guna2ProgressBar1.Value += 1;
                label2.Text = guna2ProgressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                LogInForm login1 = new LogInForm();
                login1.Show();
                this.Hide();

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
