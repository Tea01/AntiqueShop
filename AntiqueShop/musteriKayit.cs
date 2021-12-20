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
    public partial class musteriKayit : Form
    {
        public musteriKayit()
        {
            InitializeComponent();
        }
        //define something to connect databse
        private NpgsqlConnection conn;  //connection
        string connstring = String.Format("Server={0}; Port={1}; User ID={2}; Password={3}; Database={4};", "localHost", "5432", "postgres", "e182a3.,", "AntiqueShop");
        
        private void Button_login_Click(object sender, EventArgs e)
        {
            //if login is successful, hide this form and show the main form for costumer
            //passing username from the login form into main form

            try
            {
                conn.Open();
                NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO musteri(musteri_id, musteri_adi, sifre, sehir_id) values (@p1, @p2, @p3, @p4)", conn);

                komut.Parameters.AddWithValue("@p1", int.Parse(TextBox_musteri_id.Text));
                komut.Parameters.AddWithValue("@p2", TextBox_username.Text);
                komut.Parameters.AddWithValue("@p3", TextBox_password.Text);
                komut.Parameters.AddWithValue("@p4", int.Parse(TextBox_sehir_id.Text));

                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıtınız oluşturdu. Aramıza hoş geldiniz", "Illyria Antika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();


                this.Hide();
                CustomerForm frm = new CustomerForm();
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatta: " + ex.Message, "Bir şeyler yanlış gitti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        private void musteriKayit_Load(object sender, EventArgs e)
        {
           conn = new NpgsqlConnection(connstring);
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
            label_exit.ForeColor = Color.Black;
        }
    }
}
