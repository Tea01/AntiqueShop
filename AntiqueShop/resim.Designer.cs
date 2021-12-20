namespace AntiqueShop
{
    partial class resim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resim));
            this.dataGrid_resim = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sepeteEkle = new System.Windows.Forms.Button();
            this.txt_sepet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.btn_AnaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_resim)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_resim
            // 
            this.dataGrid_resim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_resim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGrid_resim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_resim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGrid_resim.Location = new System.Drawing.Point(0, 567);
            this.dataGrid_resim.Name = "dataGrid_resim";
            this.dataGrid_resim.RowHeadersWidth = 51;
            this.dataGrid_resim.RowTemplate.Height = 24;
            this.dataGrid_resim.Size = new System.Drawing.Size(966, 297);
            this.dataGrid_resim.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_sepeteEkle);
            this.panel1.Controls.Add(this.txt_sepet);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_fiyat);
            this.panel1.Controls.Add(this.txt_adi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Controls.Add(this.btn_AnaMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 570);
            this.panel1.TabIndex = 4;
            // 
            // btn_sepeteEkle
            // 
            this.btn_sepeteEkle.BackColor = System.Drawing.Color.Maroon;
            this.btn_sepeteEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sepeteEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sepeteEkle.Location = new System.Drawing.Point(775, 523);
            this.btn_sepeteEkle.Name = "btn_sepeteEkle";
            this.btn_sepeteEkle.Size = new System.Drawing.Size(176, 36);
            this.btn_sepeteEkle.TabIndex = 84;
            this.btn_sepeteEkle.Text = "Sepete Ekle";
            this.btn_sepeteEkle.UseVisualStyleBackColor = false;
            this.btn_sepeteEkle.Click += new System.EventHandler(this.btn_sepeteEkle_Click);
            // 
            // txt_sepet
            // 
            this.txt_sepet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_sepet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sepet.Location = new System.Drawing.Point(637, 532);
            this.txt_sepet.Name = "txt_sepet";
            this.txt_sepet.Size = new System.Drawing.Size(88, 22);
            this.txt_sepet.TabIndex = 83;
            this.txt_sepet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(549, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 85;
            this.label5.Text = "Sepet ID";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_fiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_fiyat.Location = new System.Drawing.Point(418, 533);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(109, 22);
            this.txt_fiyat.TabIndex = 87;
            this.txt_fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_adi
            // 
            this.txt_adi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_adi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adi.Location = new System.Drawing.Point(246, 533);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(93, 22);
            this.txt_adi.TabIndex = 79;
            this.txt_adi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(361, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 86;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 82;
            this.label4.Text = "Urun ID";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_id.Location = new System.Drawing.Point(91, 533);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(87, 22);
            this.txt_id.TabIndex = 81;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(199, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 80;
            this.label6.Text = "Adı";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_exit.ForeColor = System.Drawing.Color.Linen;
            this.label_exit.Location = new System.Drawing.Point(924, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(39, 39);
            this.label_exit.TabIndex = 78;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // btn_AnaMenu
            // 
            this.btn_AnaMenu.BackColor = System.Drawing.Color.Maroon;
            this.btn_AnaMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AnaMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AnaMenu.Location = new System.Drawing.Point(13, 5);
            this.btn_AnaMenu.Name = "btn_AnaMenu";
            this.btn_AnaMenu.Size = new System.Drawing.Size(133, 40);
            this.btn_AnaMenu.TabIndex = 73;
            this.btn_AnaMenu.Text = "Ana Menü";
            this.btn_AnaMenu.UseVisualStyleBackColor = false;
            this.btn_AnaMenu.Click += new System.EventHandler(this.btn_AnaMenu_Click);
            // 
            // resim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 862);
            this.Controls.Add(this.dataGrid_resim);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "resim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mobilya";
            this.Load += new System.EventHandler(this.mobilya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_resim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_resim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sepeteEkle;
        private System.Windows.Forms.TextBox txt_sepet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button btn_AnaMenu;
    }
}