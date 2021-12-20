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
    public partial class saticiGiris : Form
    {
        public saticiGiris()
        {
            InitializeComponent();
        }
        //define something to connect databse
        private NpgsqlConnection conn;  //connection
        string connstring = String.Format("Server={0}; Port={1}; User ID={2}; Password={3}; Database={4};", "localHost", "5432", "postgres", "e182a3.,", "AntiqueShop");
        private NpgsqlCommand cmd;
        private string sql = null;

        private void Button_login_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM satici(:_satici_adi, :_sifre)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_satici_adi", TextBox_username.Text);
                cmd.Parameters.AddWithValue("_sifre", TextBox_password.Text);

                int result = (int)cmd.ExecuteScalar();

                conn.Close();

                if (result == 1)
                {
                    this.Hide();
                    new SellerForm().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lütfen kullanıcı adınızı veya şifrenizi kontrol edin.", "Giriş başarısız oldu ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatta: " + ex.Message, "Bir şeyler yanlış gitti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        private void saticiGiris_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void lbl_uye_ol_Click(object sender, EventArgs e)
        {
            saticiKayit form3 = new saticiKayit();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Black;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Linen;
        }

        private void lbl_uye_ol_MouseEnter(object sender, EventArgs e)
        {
            lbl_uye_ol.ForeColor = Color.Black;
        }

        private void lbl_uye_ol_MouseLeave(object sender, EventArgs e)
        {
            lbl_uye_ol.ForeColor = Color.LightYellow;
        }
    }
}
