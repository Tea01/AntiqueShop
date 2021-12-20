﻿using Npgsql;
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
    public partial class urunListesiSatici : Form
    {
        public urunListesiSatici()
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
            label_exit.ForeColor = Color.LightGray;
        }
        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }
        private void urunListesiSatici_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from urun";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGrid_listele.DataSource = ds.Tables[0];
        }

        private void btn_AnaMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm frm = new SellerForm();
            frm.ShowDialog();
        }

        private void btn_AnaMenu_MouseEnter(object sender, EventArgs e)
        {
            btn_AnaMenu.ForeColor = Color.White;
        }
    }
}
