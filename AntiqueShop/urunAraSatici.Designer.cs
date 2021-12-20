namespace AntiqueShop
{
    partial class urunAraSatici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunAraSatici));
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.dataGrid_listele = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.btn_AnaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ara
            // 
            this.txt_ara.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_ara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ara.Location = new System.Drawing.Point(25, 576);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(137, 22);
            this.txt_ara.TabIndex = 0;
            this.txt_ara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // dataGrid_listele
            // 
            this.dataGrid_listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_listele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.dataGrid_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_listele.Location = new System.Drawing.Point(-3, 613);
            this.dataGrid_listele.Name = "dataGrid_listele";
            this.dataGrid_listele.RowHeadersWidth = 51;
            this.dataGrid_listele.RowTemplate.Height = 24;
            this.dataGrid_listele.Size = new System.Drawing.Size(753, 290);
            this.dataGrid_listele.TabIndex = 1;
            this.dataGrid_listele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_listele_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(179, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_exit.ForeColor = System.Drawing.Color.Linen;
            this.label_exit.Location = new System.Drawing.Point(711, -4);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(39, 39);
            this.label_exit.TabIndex = 11;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // btn_AnaMenu
            // 
            this.btn_AnaMenu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AnaMenu.Location = new System.Drawing.Point(588, 554);
            this.btn_AnaMenu.Name = "btn_AnaMenu";
            this.btn_AnaMenu.Size = new System.Drawing.Size(149, 53);
            this.btn_AnaMenu.TabIndex = 55;
            this.btn_AnaMenu.Text = "Ana Menü";
            this.btn_AnaMenu.UseVisualStyleBackColor = true;
            this.btn_AnaMenu.Click += new System.EventHandler(this.btn_AnaMenu_Click);
            // 
            // urunAraSatici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 901);
            this.Controls.Add(this.btn_AnaMenu);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_listele);
            this.Controls.Add(this.txt_ara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "urunAraSatici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunAraSatici";
            this.Load += new System.EventHandler(this.urunAraSatici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.DataGridView dataGrid_listele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button btn_AnaMenu;
    }
}