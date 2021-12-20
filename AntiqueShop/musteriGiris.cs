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
    public partial class musteriGiris : Form
    {
        public musteriGiris()
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
            //if login is successful, hide this form and show the main form for costumer
            //passing username from the login form into main form

            try
            {
                conn.Open();
                sql = @"SELECT * FROM musteri(:_musteri_adi, :_sifre)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_musteri_adi", TextBox_username.Text);
                cmd.Parameters.AddWithValue("_sifre", TextBox_password.Text);

                int result = (int)cmd.ExecuteScalar();

                conn.Close();

                if(result==1)
                {
                    this.Hide();
                    new CustomerForm().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lütfen kullanıcı adınızı veya şifrenizi kontrol edin.", "Giriş başarısız oldu ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hatta: " + ex.Message, "Bir şeyler yanlış gitti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void musteriGiris_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void lbl_kayit_ol_Click(object sender, EventArgs e)
        {
            musteriKayit form3 = new musteriKayit();
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
            label_exit.ForeColor = Color.Wheat;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Black;
        }

        private void lbl_kayit_ol_MouseEnter(object sender, EventArgs e)
        {
            lbl_kayit_ol.ForeColor = Color.Wheat;
        }

        private void lbl_kayit_ol_MouseLeave(object sender, EventArgs e)
        {
            lbl_kayit_ol.ForeColor = Color.Black;
        }
    }
}

