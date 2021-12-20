namespace AntiqueShop
{
    partial class urunEkleSatici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunEkleSatici));
            this.label_exit = new System.Windows.Forms.Label();
            this.btn_Ana_Menu = new System.Windows.Forms.Button();
            this.lbl_urun_id = new System.Windows.Forms.Label();
            this.lbl_urun_ad = new System.Windows.Forms.Label();
            this.lbl_urun_fiyati = new System.Windows.Forms.Label();
            this.lbl_urun_tanimi = new System.Windows.Forms.Label();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_tanimi = new System.Windows.Forms.TextBox();
            this.box_kategori = new System.Windows.Forms.ComboBox();
            this.dataGrid_listele = new System.Windows.Forms.DataGridView();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_kategori_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_exit.Location = new System.Drawing.Point(1264, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(39, 39);
            this.label_exit.TabIndex = 12;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // btn_Ana_Menu
            // 
            this.btn_Ana_Menu.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ana_Menu.Location = new System.Drawing.Point(1089, 655);
            this.btn_Ana_Menu.Name = "btn_Ana_Menu";
            this.btn_Ana_Menu.Size = new System.Drawing.Size(203, 59);
            this.btn_Ana_Menu.TabIndex = 28;
            this.btn_Ana_Menu.Text = "Ana Menü";
            this.btn_Ana_Menu.UseVisualStyleBackColor = true;
            this.btn_Ana_Menu.Click += new System.EventHandler(this.btn_Ana_Menu_Click);
            this.btn_Ana_Menu.MouseEnter += new System.EventHandler(this.btn_Ana_Menu_MouseEnter);
            this.btn_Ana_Menu.MouseHover += new System.EventHandler(this.btn_Ana_Menu_MouseHover);
            // 
            // lbl_urun_id
            // 
            this.lbl_urun_id.AutoSize = true;
            this.lbl_urun_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_urun_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun_id.Location = new System.Drawing.Point(41, 121);
            this.lbl_urun_id.Name = "lbl_urun_id";
            this.lbl_urun_id.Size = new System.Drawing.Size(93, 29);
            this.lbl_urun_id.TabIndex = 29;
            this.lbl_urun_id.Text = "Urun ID";
            // 
            // lbl_urun_ad
            // 
            this.lbl_urun_ad.AutoSize = true;
            this.lbl_urun_ad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_urun_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun_ad.Location = new System.Drawing.Point(38, 169);
            this.lbl_urun_ad.Name = "lbl_urun_ad";
            this.lbl_urun_ad.Size = new System.Drawing.Size(105, 29);
            this.lbl_urun_ad.TabIndex = 30;
            this.lbl_urun_ad.Text = "Urun Adı";
            // 
            // lbl_urun_fiyati
            // 
            this.lbl_urun_fiyati.AutoSize = true;
            this.lbl_urun_fiyati.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_urun_fiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun_fiyati.Location = new System.Drawing.Point(31, 309);
            this.lbl_urun_fiyati.Name = "lbl_urun_fiyati";
            this.lbl_urun_fiyati.Size = new System.Drawing.Size(127, 29);
            this.lbl_urun_fiyati.TabIndex = 31;
            this.lbl_urun_fiyati.Text = "Urun Fiyatı";
            // 
            // lbl_urun_tanimi
            // 
            this.lbl_urun_tanimi.AutoSize = true;
            this.lbl_urun_tanimi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_urun_tanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun_tanimi.Location = new System.Drawing.Point(25, 357);
            this.lbl_urun_tanimi.Name = "lbl_urun_tanimi";
            this.lbl_urun_tanimi.Size = new System.Drawing.Size(144, 29);
            this.lbl_urun_tanimi.TabIndex = 32;
            this.lbl_urun_tanimi.Text = "Urun Tanımı";
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kategori.Location = new System.Drawing.Point(39, 214);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(104, 29);
            this.lbl_kategori.TabIndex = 33;
            this.lbl_kategori.Text = "Kategori";
            // 
            // text_id
            // 
            this.text_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.text_id.Location = new System.Drawing.Point(200, 121);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(173, 22);
            this.text_id.TabIndex = 34;
            // 
            // txt_adi
            // 
            this.txt_adi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_adi.Location = new System.Drawing.Point(200, 169);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(173, 22);
            this.txt_adi.TabIndex = 35;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_fiyat.Location = new System.Drawing.Point(200, 313);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(173, 22);
            this.txt_fiyat.TabIndex = 36;
            // 
            // txt_tanimi
            // 
            this.txt_tanimi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_tanimi.Location = new System.Drawing.Point(200, 357);
            this.txt_tanimi.Name = "txt_tanimi";
            this.txt_tanimi.Size = new System.Drawing.Size(173, 22);
            this.txt_tanimi.TabIndex = 37;
            // 
            // box_kategori
            // 
            this.box_kategori.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.box_kategori.FormattingEnabled = true;
            this.box_kategori.Location = new System.Drawing.Point(200, 217);
            this.box_kategori.Name = "box_kategori";
            this.box_kategori.Size = new System.Drawing.Size(173, 24);
            this.box_kategori.TabIndex = 38;
            // 
            // dataGrid_listele
            // 
            this.dataGrid_listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_listele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.dataGrid_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_listele.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.dataGrid_listele.Location = new System.Drawing.Point(502, 92);
            this.dataGrid_listele.Name = "dataGrid_listele";
            this.dataGrid_listele.RowHeadersWidth = 51;
            this.dataGrid_listele.RowTemplate.Height = 24;
            this.dataGrid_listele.Size = new System.Drawing.Size(764, 296);
            this.dataGrid_listele.TabIndex = 39;
            // 
            // btn_listele
            // 
            this.btn_listele.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.Location = new System.Drawing.Point(867, 655);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(203, 59);
            this.btn_listele.TabIndex = 40;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(184, 407);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(203, 59);
            this.btn_ekle.TabIndex = 41;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_kategori_id
            // 
            this.txt_kategori_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_kategori_id.Location = new System.Drawing.Point(200, 267);
            this.txt_kategori_id.Name = "txt_kategori_id";
            this.txt_kategori_id.Size = new System.Drawing.Size(173, 22);
            this.txt_kategori_id.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Kategori ID";
            // 
            // urunEkleSatici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 726);
            this.Controls.Add(this.txt_kategori_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.dataGrid_listele);
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
            this.Controls.Add(this.btn_Ana_Menu);
            this.Controls.Add(this.label_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "urunEkleSatici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunEkleSatici";
            this.Load += new System.EventHandler(this.urunEkleSatici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button btn_Ana_Menu;
        private System.Windows.Forms.Label lbl_urun_id;
        private System.Windows.Forms.Label lbl_urun_ad;
        private System.Windows.Forms.Label lbl_urun_fiyati;
        private System.Windows.Forms.Label lbl_urun_tanimi;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_tanimi;
        private System.Windows.Forms.ComboBox box_kategori;
        private System.Windows.Forms.DataGridView dataGrid_listele;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_kategori_id;
        private System.Windows.Forms.Label label1;
    }
}