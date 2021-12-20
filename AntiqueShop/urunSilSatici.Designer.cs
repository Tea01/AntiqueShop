namespace AntiqueShop
{
    partial class urunSilSatici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunSilSatici));
            this.label_exit = new System.Windows.Forms.Label();
            this.btn_listele = new System.Windows.Forms.Button();
            this.dataGrid_listele = new System.Windows.Forms.DataGridView();
            this.btn_Ana_Menu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.text_id = new System.Windows.Forms.TextBox();
            this.lbl_urun_id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listele)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_exit.ForeColor = System.Drawing.Color.White;
            this.label_exit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_exit.Location = new System.Drawing.Point(734, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(39, 39);
            this.label_exit.TabIndex = 13;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // btn_listele
            // 
            this.btn_listele.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.Location = new System.Drawing.Point(402, 627);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(145, 42);
            this.btn_listele.TabIndex = 43;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // dataGrid_listele
            // 
            this.dataGrid_listele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.dataGrid_listele.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_listele.GridColor = System.Drawing.Color.BurlyWood;
            this.dataGrid_listele.Location = new System.Drawing.Point(-2, 675);
            this.dataGrid_listele.Name = "dataGrid_listele";
            this.dataGrid_listele.RowHeadersWidth = 51;
            this.dataGrid_listele.RowTemplate.Height = 24;
            this.dataGrid_listele.Size = new System.Drawing.Size(776, 223);
            this.dataGrid_listele.TabIndex = 42;
            // 
            // btn_Ana_Menu
            // 
            this.btn_Ana_Menu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ana_Menu.Location = new System.Drawing.Point(582, 628);
            this.btn_Ana_Menu.Name = "btn_Ana_Menu";
            this.btn_Ana_Menu.Size = new System.Drawing.Size(168, 42);
            this.btn_Ana_Menu.TabIndex = 41;
            this.btn_Ana_Menu.Text = "Ana Menü";
            this.btn_Ana_Menu.UseVisualStyleBackColor = true;
            this.btn_Ana_Menu.Click += new System.EventHandler(this.btn_Ana_Menu_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(111, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 44;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_id
            // 
            this.text_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.text_id.Location = new System.Drawing.Point(145, 570);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(173, 22);
            this.text_id.TabIndex = 46;
            // 
            // lbl_urun_id
            // 
            this.lbl_urun_id.AutoSize = true;
            this.lbl_urun_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_urun_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun_id.Location = new System.Drawing.Point(24, 566);
            this.lbl_urun_id.Name = "lbl_urun_id";
            this.lbl_urun_id.Size = new System.Drawing.Size(93, 29);
            this.lbl_urun_id.TabIndex = 45;
            this.lbl_urun_id.Text = "Urun ID";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.text_id);
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Controls.Add(this.btn_Ana_Menu);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 679);
            this.panel1.TabIndex = 47;
            // 
            // urunSilSatici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 894);
            this.Controls.Add(this.lbl_urun_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid_listele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "urunSilSatici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunSilSatici";
            this.Load += new System.EventHandler(this.urunSilSatici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listele)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.DataGridView dataGrid_listele;
        private System.Windows.Forms.Button btn_Ana_Menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label lbl_urun_id;
        private System.Windows.Forms.Panel panel1;
    }
}