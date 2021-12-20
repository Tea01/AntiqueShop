namespace AntiqueShop
{
    partial class urunAraMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunAraMusteri));
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.dataGrid_urun = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.btn_AnaMenu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sepet = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sepeteEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_urun)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_adi
            // 
            this.txt_adi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_adi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adi.Location = new System.Drawing.Point(349, 729);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(137, 27);
            this.txt_adi.TabIndex = 79;
            this.txt_adi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGrid_urun
            // 
            this.dataGrid_urun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_urun.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.dataGrid_urun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid_urun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_urun.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.dataGrid_urun.Location = new System.Drawing.Point(0, 382);
            this.dataGrid_urun.MultiSelect = false;
            this.dataGrid_urun.Name = "dataGrid_urun";
            this.dataGrid_urun.RowHeadersWidth = 51;
            this.dataGrid_urun.RowTemplate.Height = 24;
            this.dataGrid_urun.Size = new System.Drawing.Size(1110, 334);
            this.dataGrid_urun.TabIndex = 85;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txt_ara);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Controls.Add(this.btn_AnaMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 589);
            this.panel1.TabIndex = 80;
            // 
            // txt_ara
            // 
            this.txt_ara.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_ara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ara.Location = new System.Drawing.Point(139, 350);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(137, 27);
            this.txt_ara.TabIndex = 69;
            this.txt_ara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 68;
            this.label3.Text = "Urun Ara";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_exit.ForeColor = System.Drawing.Color.Linen;
            this.label_exit.Location = new System.Drawing.Point(1068, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(39, 39);
            this.label_exit.TabIndex = 12;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // btn_AnaMenu
            // 
            this.btn_AnaMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AnaMenu.Location = new System.Drawing.Point(12, 13);
            this.btn_AnaMenu.Name = "btn_AnaMenu";
            this.btn_AnaMenu.Size = new System.Drawing.Size(151, 40);
            this.btn_AnaMenu.TabIndex = 59;
            this.btn_AnaMenu.Text = "Ana Menü";
            this.btn_AnaMenu.UseVisualStyleBackColor = true;
            this.btn_AnaMenu.Click += new System.EventHandler(this.btn_AnaMenu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(792, 725);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 86;
            this.label5.Text = "Sepet ID";
            // 
            // txt_sepet
            // 
            this.txt_sepet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_sepet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sepet.Location = new System.Drawing.Point(912, 725);
            this.txt_sepet.Name = "txt_sepet";
            this.txt_sepet.Size = new System.Drawing.Size(137, 27);
            this.txt_sepet.TabIndex = 84;
            this.txt_sepet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_fiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_fiyat.Location = new System.Drawing.Point(613, 726);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(127, 27);
            this.txt_fiyat.TabIndex = 88;
            this.txt_fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 730);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 83;
            this.label4.Text = "Urun ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(537, 725);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 87;
            this.label2.Text = "Fiyat";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_id.Location = new System.Drawing.Point(110, 730);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(137, 27);
            this.txt_id.TabIndex = 82;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(288, 728);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 28);
            this.label1.TabIndex = 81;
            this.label1.Text = "Adı";
            // 
            // btn_sepeteEkle
            // 
            this.btn_sepeteEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sepeteEkle.Location = new System.Drawing.Point(940, 768);
            this.btn_sepeteEkle.Name = "btn_sepeteEkle";
            this.btn_sepeteEkle.Size = new System.Drawing.Size(156, 53);
            this.btn_sepeteEkle.TabIndex = 89;
            this.btn_sepeteEkle.Text = "Sepete Ekle";
            this.btn_sepeteEkle.UseVisualStyleBackColor = true;
            this.btn_sepeteEkle.Click += new System.EventHandler(this.btn_sepeteEkle_Click);
            // 
            // urunAraMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1108, 833);
            this.Controls.Add(this.btn_sepeteEkle);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.dataGrid_urun);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sepet);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "urunAraMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunAraMusteri";
            this.Load += new System.EventHandler(this.urunAraMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_urun)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.DataGridView dataGrid_urun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button btn_AnaMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sepet;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sepeteEkle;
    }
}