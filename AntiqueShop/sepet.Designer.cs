namespace AntiqueShop
{
    partial class sepet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sepet));
            this.dataGrid_sepet = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGrid_toplamFiyat = new System.Windows.Forms.DataGridView();
            this.dataGrid_toplamurun = new System.Windows.Forms.DataGridView();
            this.lbl_toplam_urun = new System.Windows.Forms.Label();
            this.lbl_toplam_fiyat = new System.Windows.Forms.Label();
            this.btn_ana_menu = new System.Windows.Forms.Button();
            this.btn_satin_al = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cikart = new System.Windows.Forms.TextBox();
            this.btn_cikart = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_sepet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_toplamFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_toplamurun)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_sepet
            // 
            this.dataGrid_sepet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_sepet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(130)))), ((int)(((byte)(115)))));
            this.dataGrid_sepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_sepet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(130)))), ((int)(((byte)(115)))));
            this.dataGrid_sepet.Location = new System.Drawing.Point(-1, 339);
            this.dataGrid_sepet.Name = "dataGrid_sepet";
            this.dataGrid_sepet.RowHeadersWidth = 51;
            this.dataGrid_sepet.RowTemplate.Height = 24;
            this.dataGrid_sepet.Size = new System.Drawing.Size(896, 259);
            this.dataGrid_sepet.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 599);
            this.panel1.TabIndex = 6;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_exit.ForeColor = System.Drawing.Color.White;
            this.label_exit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_exit.Location = new System.Drawing.Point(857, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(39, 39);
            this.label_exit.TabIndex = 15;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_listele);
            this.panel2.Controls.Add(this.btn_cikart);
            this.panel2.Controls.Add(this.txt_cikart);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGrid_toplamFiyat);
            this.panel2.Controls.Add(this.dataGrid_toplamurun);
            this.panel2.Controls.Add(this.lbl_toplam_urun);
            this.panel2.Controls.Add(this.lbl_toplam_fiyat);
            this.panel2.Controls.Add(this.btn_ana_menu);
            this.panel2.Controls.Add(this.btn_satin_al);
            this.panel2.Location = new System.Drawing.Point(-1, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 405);
            this.panel2.TabIndex = 8;
            // 
            // dataGrid_toplamFiyat
            // 
            this.dataGrid_toplamFiyat.ColumnHeadersHeight = 8;
            this.dataGrid_toplamFiyat.Location = new System.Drawing.Point(297, 187);
            this.dataGrid_toplamFiyat.Name = "dataGrid_toplamFiyat";
            this.dataGrid_toplamFiyat.RowHeadersWidth = 51;
            this.dataGrid_toplamFiyat.RowTemplate.Height = 24;
            this.dataGrid_toplamFiyat.Size = new System.Drawing.Size(148, 80);
            this.dataGrid_toplamFiyat.TabIndex = 60;
            // 
            // dataGrid_toplamurun
            // 
            this.dataGrid_toplamurun.ColumnHeadersHeight = 8;
            this.dataGrid_toplamurun.Location = new System.Drawing.Point(55, 187);
            this.dataGrid_toplamurun.Name = "dataGrid_toplamurun";
            this.dataGrid_toplamurun.RowHeadersWidth = 51;
            this.dataGrid_toplamurun.RowTemplate.Height = 24;
            this.dataGrid_toplamurun.Size = new System.Drawing.Size(148, 80);
            this.dataGrid_toplamurun.TabIndex = 59;
            // 
            // lbl_toplam_urun
            // 
            this.lbl_toplam_urun.AutoSize = true;
            this.lbl_toplam_urun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_toplam_urun.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam_urun.Location = new System.Drawing.Point(64, 161);
            this.lbl_toplam_urun.Name = "lbl_toplam_urun";
            this.lbl_toplam_urun.Size = new System.Drawing.Size(125, 23);
            this.lbl_toplam_urun.TabIndex = 57;
            this.lbl_toplam_urun.Text = "Toplam Ürün";
            this.lbl_toplam_urun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_toplam_fiyat
            // 
            this.lbl_toplam_fiyat.AutoSize = true;
            this.lbl_toplam_fiyat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_toplam_fiyat.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam_fiyat.Location = new System.Drawing.Point(307, 161);
            this.lbl_toplam_fiyat.Name = "lbl_toplam_fiyat";
            this.lbl_toplam_fiyat.Size = new System.Drawing.Size(128, 23);
            this.lbl_toplam_fiyat.TabIndex = 55;
            this.lbl_toplam_fiyat.Text = "Toplam Fiyat";
            this.lbl_toplam_fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ana_menu
            // 
            this.btn_ana_menu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ana_menu.Location = new System.Drawing.Point(714, 325);
            this.btn_ana_menu.Name = "btn_ana_menu";
            this.btn_ana_menu.Size = new System.Drawing.Size(149, 46);
            this.btn_ana_menu.TabIndex = 50;
            this.btn_ana_menu.Text = "Ana Menü";
            this.btn_ana_menu.UseVisualStyleBackColor = true;
            this.btn_ana_menu.Click += new System.EventHandler(this.btn_ana_menu_Click);
            // 
            // btn_satin_al
            // 
            this.btn_satin_al.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_satin_al.Location = new System.Drawing.Point(736, 187);
            this.btn_satin_al.Name = "btn_satin_al";
            this.btn_satin_al.Size = new System.Drawing.Size(102, 46);
            this.btn_satin_al.TabIndex = 49;
            this.btn_satin_al.Text = "Satın Al";
            this.btn_satin_al.UseVisualStyleBackColor = true;
            this.btn_satin_al.Click += new System.EventHandler(this.btn_satin_al_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Çıkartmak istediğiniz urun:";
            // 
            // txt_cikart
            // 
            this.txt_cikart.Location = new System.Drawing.Point(325, 325);
            this.txt_cikart.Name = "txt_cikart";
            this.txt_cikart.Size = new System.Drawing.Size(100, 22);
            this.txt_cikart.TabIndex = 62;
            // 
            // btn_cikart
            // 
            this.btn_cikart.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikart.Location = new System.Drawing.Point(444, 311);
            this.btn_cikart.Name = "btn_cikart";
            this.btn_cikart.Size = new System.Drawing.Size(102, 46);
            this.btn_cikart.TabIndex = 63;
            this.btn_cikart.Text = "Çıkart";
            this.btn_cikart.UseVisualStyleBackColor = true;
            this.btn_cikart.Click += new System.EventHandler(this.btn_cikart_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.Location = new System.Drawing.Point(736, 256);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(102, 46);
            this.btn_listele.TabIndex = 64;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 844);
            this.Controls.Add(this.dataGrid_sepet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sepet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sepet";
            this.Load += new System.EventHandler(this.sepet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_sepet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_toplamFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_toplamurun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_sepet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ana_menu;
        private System.Windows.Forms.Button btn_satin_al;
        private System.Windows.Forms.Label lbl_toplam_urun;
        private System.Windows.Forms.Label lbl_toplam_fiyat;
        private System.Windows.Forms.DataGridView dataGrid_toplamurun;
        private System.Windows.Forms.DataGridView dataGrid_toplamFiyat;
        private System.Windows.Forms.Button btn_cikart;
        private System.Windows.Forms.TextBox txt_cikart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_listele;
    }
}