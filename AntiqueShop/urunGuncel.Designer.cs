namespace AntiqueShop
{
    partial class urunGuncel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunGuncel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.btn_guncel = new System.Windows.Forms.Button();
            this.box_kategori = new System.Windows.Forms.ComboBox();
            this.txt_tanimi = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.lbl_urun_tanimi = new System.Windows.Forms.Label();
            this.lbl_urun_fiyati = new System.Windows.Forms.Label();
            this.lbl_urun_ad = new System.Windows.Forms.Label();
            this.lbl_urun_id = new System.Windows.Forms.Label();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_AnaMenu = new System.Windows.Forms.Button();
            this.dataGrid_listele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 654);
            this.panel1.TabIndex = 0;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_exit.ForeColor = System.Drawing.Color.Black;
            this.label_exit.Location = new System.Drawing.Point(663, -1);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(39, 39);
            this.label_exit.TabIndex = 11;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // btn_guncel
            // 
            this.btn_guncel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncel.Location = new System.Drawing.Point(498, 475);
            this.btn_guncel.Name = "btn_guncel";
            this.btn_guncel.Size = new System.Drawing.Size(166, 46);
            this.btn_guncel.TabIndex = 52;
            this.btn_guncel.Text = "Güncel";
            this.btn_guncel.UseVisualStyleBackColor = true;
            this.btn_guncel.Click += new System.EventHandler(this.btn_guncel_Click);
            // 
            // box_kategori
            // 
            this.box_kategori.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.box_kategori.FormattingEnabled = true;
            this.box_kategori.Location = new System.Drawing.Point(496, 251);
            this.box_kategori.Name = "box_kategori";
            this.box_kategori.Size = new System.Drawing.Size(173, 24);
            this.box_kategori.TabIndex = 51;
            // 
            // txt_tanimi
            // 
            this.txt_tanimi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_tanimi.Location = new System.Drawing.Point(496, 421);
            this.txt_tanimi.Name = "txt_tanimi";
            this.txt_tanimi.Size = new System.Drawing.Size(173, 22);
            this.txt_tanimi.TabIndex = 50;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_fiyat.Location = new System.Drawing.Point(496, 332);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(173, 22);
            this.txt_fiyat.TabIndex = 49;
            // 
            // txt_adi
            // 
            this.txt_adi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_adi.Location = new System.Drawing.Point(496, 169);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(173, 22);
            this.txt_adi.TabIndex = 48;
            // 
            // text_id
            // 
            this.text_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.text_id.Location = new System.Drawing.Point(496, 88);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(173, 22);
            this.text_id.TabIndex = 47;
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_kategori.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kategori.Location = new System.Drawing.Point(526, 214);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(110, 28);
            this.lbl_kategori.TabIndex = 46;
            this.lbl_kategori.Text = "Kategori";
            // 
            // lbl_urun_tanimi
            // 
            this.lbl_urun_tanimi.AutoSize = true;
            this.lbl_urun_tanimi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_urun_tanimi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun_tanimi.Location = new System.Drawing.Point(509, 379);
            this.lbl_urun_tanimi.Name = "lbl_urun_tanimi";
            this.lbl_urun_tanimi.Size = new System.Drawing.Size(145, 28);
            this.lbl_urun_tanimi.TabIndex = 45;
            this.lbl_urun_tanimi.Text = "Urun Tanımı";
            // 
            // lbl_urun_fiyati
            // 
            this.lbl_urun_fiyati.AutoSize = true;
            this.lbl_urun_fiyati.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_urun_fiyati.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun_fiyati.Location = new System.Drawing.Point(517, 296);
            this.lbl_urun_fiyati.Name = "lbl_urun_fiyati";
            this.lbl_urun_fiyati.Size = new System.Drawing.Size(131, 28);
            this.lbl_urun_fiyati.TabIndex = 44;
            this.lbl_urun_fiyati.Text = "Urun Fiyatı";
            // 
            // lbl_urun_ad
            // 
            this.lbl_urun_ad.AutoSize = true;
            this.lbl_urun_ad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_urun_ad.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun_ad.Location = new System.Drawing.Point(525, 132);
            this.lbl_urun_ad.Name = "lbl_urun_ad";
            this.lbl_urun_ad.Size = new System.Drawing.Size(110, 28);
            this.lbl_urun_ad.TabIndex = 43;
            this.lbl_urun_ad.Text = "Ürün Adı";
            // 
            // lbl_urun_id
            // 
            this.lbl_urun_id.AutoSize = true;
            this.lbl_urun_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_urun_id.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun_id.Location = new System.Drawing.Point(534, 53);
            this.lbl_urun_id.Name = "lbl_urun_id";
            this.lbl_urun_id.Size = new System.Drawing.Size(94, 28);
            this.lbl_urun_id.TabIndex = 42;
            this.lbl_urun_id.Text = "Ürün ID";
            // 
            // btn_listele
            // 
            this.btn_listele.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.Location = new System.Drawing.Point(499, 532);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(165, 44);
            this.btn_listele.TabIndex = 41;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_AnaMenu
            // 
            this.btn_AnaMenu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AnaMenu.Location = new System.Drawing.Point(500, 588);
            this.btn_AnaMenu.Name = "btn_AnaMenu";
            this.btn_AnaMenu.Size = new System.Drawing.Size(165, 43);
            this.btn_AnaMenu.TabIndex = 54;
            this.btn_AnaMenu.Text = "Ana Menü";
            this.btn_AnaMenu.UseVisualStyleBackColor = true;
            this.btn_AnaMenu.Click += new System.EventHandler(this.btn_AnaMenu_Click);
            // 
            // dataGrid_listele
            // 
            this.dataGrid_listele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.dataGrid_listele.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_listele.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.dataGrid_listele.Location = new System.Drawing.Point(-1, 647);
            this.dataGrid_listele.Name = "dataGrid_listele";
            this.dataGrid_listele.RowHeadersWidth = 51;
            this.dataGrid_listele.RowTemplate.Height = 24;
            this.dataGrid_listele.Size = new System.Drawing.Size(707, 231);
            this.dataGrid_listele.TabIndex = 53;
            // 
            // urunGuncel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(706, 1005);
            this.Controls.Add(this.dataGrid_listele);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.btn_AnaMenu);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_guncel);
            this.Controls.Add(this.box_kategori);
            this.Controls.Add(this.txt_tanimi);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.lbl_kategori);
            this.Controls.Add(this.lbl_urun_tanimi);
            this.Controls.Add(this.lbl_urun_fiyati);
            this.Controls.Add(this.lbl_urun_ad);
            this.Controls.Add(this.lbl_urun_id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "urunGuncel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunGuncel";
            this.Load += new System.EventHandler(this.urunGuncel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button btn_guncel;
        private System.Windows.Forms.ComboBox box_kategori;
        private System.Windows.Forms.TextBox txt_tanimi;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.Label lbl_urun_tanimi;
        private System.Windows.Forms.Label lbl_urun_fiyati;
        private System.Windows.Forms.Label lbl_urun_ad;
        private System.Windows.Forms.Label lbl_urun_id;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_AnaMenu;
        private System.Windows.Forms.DataGridView dataGrid_listele;
    }
}