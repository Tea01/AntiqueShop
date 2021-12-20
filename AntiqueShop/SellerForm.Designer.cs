namespace AntiqueShop
{
    partial class SellerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_Urun_Ara = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Urun_Ekle = new System.Windows.Forms.Button();
            this.btn_Urun_Sil = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_Urun_Liste = new System.Windows.Forms.Button();
            this.btn_Urun_Guncel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Location = new System.Drawing.Point(219, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 740);
            this.panel1.TabIndex = 0;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_exit.ForeColor = System.Drawing.Color.Tan;
            this.label_exit.Location = new System.Drawing.Point(515, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(39, 39);
            this.label_exit.TabIndex = 10;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave_1);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(9, -5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 90);
            this.panel3.TabIndex = 17;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(100)))), ((int)(((byte)(5)))));
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(47, 779);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 45);
            this.button9.TabIndex = 19;
            this.button9.Text = "Çıkış Yap";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btn_Urun_Ara
            // 
            this.btn_Urun_Ara.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Urun_Ara.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Urun_Ara.Location = new System.Drawing.Point(10, 126);
            this.btn_Urun_Ara.Name = "btn_Urun_Ara";
            this.btn_Urun_Ara.Size = new System.Drawing.Size(203, 59);
            this.btn_Urun_Ara.TabIndex = 18;
            this.btn_Urun_Ara.Text = "Ürün Ara";
            this.btn_Urun_Ara.UseVisualStyleBackColor = true;
            this.btn_Urun_Ara.Click += new System.EventHandler(this.btn_Urun_Ara_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(100)))), ((int)(((byte)(5)))));
            this.btn_Exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Exit.Location = new System.Drawing.Point(47, 562);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(133, 45);
            this.btn_Exit.TabIndex = 21;
            this.btn_Exit.Text = "Çıkış Yap";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Urun_Ekle
            // 
            this.btn_Urun_Ekle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Urun_Ekle.Location = new System.Drawing.Point(12, 206);
            this.btn_Urun_Ekle.Name = "btn_Urun_Ekle";
            this.btn_Urun_Ekle.Size = new System.Drawing.Size(203, 59);
            this.btn_Urun_Ekle.TabIndex = 20;
            this.btn_Urun_Ekle.Text = "Ürün Ekle";
            this.btn_Urun_Ekle.UseVisualStyleBackColor = true;
            this.btn_Urun_Ekle.Click += new System.EventHandler(this.btn_Urun_Ekle_Click);
            // 
            // btn_Urun_Sil
            // 
            this.btn_Urun_Sil.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Urun_Sil.Location = new System.Drawing.Point(12, 283);
            this.btn_Urun_Sil.Name = "btn_Urun_Sil";
            this.btn_Urun_Sil.Size = new System.Drawing.Size(203, 59);
            this.btn_Urun_Sil.TabIndex = 22;
            this.btn_Urun_Sil.Text = "Ürün Sil";
            this.btn_Urun_Sil.UseVisualStyleBackColor = true;
            this.btn_Urun_Sil.Click += new System.EventHandler(this.btn_Urun_Sil_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(100)))), ((int)(((byte)(5)))));
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(49, 1120);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 45);
            this.button8.TabIndex = 27;
            this.button8.Text = "Çıkış Yap";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btn_Urun_Liste
            // 
            this.btn_Urun_Liste.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Urun_Liste.Location = new System.Drawing.Point(12, 439);
            this.btn_Urun_Liste.Name = "btn_Urun_Liste";
            this.btn_Urun_Liste.Size = new System.Drawing.Size(203, 59);
            this.btn_Urun_Liste.TabIndex = 26;
            this.btn_Urun_Liste.Text = "Ürün Listesi";
            this.btn_Urun_Liste.UseVisualStyleBackColor = true;
            this.btn_Urun_Liste.Click += new System.EventHandler(this.btn_Urun_Liste_Click);
            // 
            // btn_Urun_Guncel
            // 
            this.btn_Urun_Guncel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Urun_Guncel.Location = new System.Drawing.Point(12, 361);
            this.btn_Urun_Guncel.Name = "btn_Urun_Guncel";
            this.btn_Urun_Guncel.Size = new System.Drawing.Size(203, 59);
            this.btn_Urun_Guncel.TabIndex = 28;
            this.btn_Urun_Guncel.Text = "Ürün Güncel";
            this.btn_Urun_Guncel.UseVisualStyleBackColor = true;
            this.btn_Urun_Guncel.Click += new System.EventHandler(this.btn_Urun_Guncel_Click_1);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(77)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(772, 644);
            this.Controls.Add(this.btn_Urun_Guncel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btn_Urun_Liste);
            this.Controls.Add(this.btn_Urun_Sil);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Urun_Ekle);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btn_Urun_Ara);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn_Urun_Liste;
        private System.Windows.Forms.Button btn_Urun_Sil;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Urun_Ekle;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_Urun_Ara;
        private System.Windows.Forms.Button btn_Urun_Guncel;
    }
}