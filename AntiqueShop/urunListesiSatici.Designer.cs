namespace AntiqueShop
{
    partial class urunListesiSatici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunListesiSatici));
            this.label_exit = new System.Windows.Forms.Label();
            this.dataGrid_listele = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AnaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listele)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_exit.ForeColor = System.Drawing.Color.Black;
            this.label_exit.Location = new System.Drawing.Point(767, 10);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(39, 39);
            this.label_exit.TabIndex = 11;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // dataGrid_listele
            // 
            this.dataGrid_listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_listele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGrid_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_listele.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGrid_listele.Location = new System.Drawing.Point(-3, 501);
            this.dataGrid_listele.Name = "dataGrid_listele";
            this.dataGrid_listele.RowHeadersWidth = 51;
            this.dataGrid_listele.RowTemplate.Height = 24;
            this.dataGrid_listele.Size = new System.Drawing.Size(820, 329);
            this.dataGrid_listele.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_AnaMenu);
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 502);
            this.panel1.TabIndex = 29;
            // 
            // btn_AnaMenu
            // 
            this.btn_AnaMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AnaMenu.Location = new System.Drawing.Point(618, 444);
            this.btn_AnaMenu.Name = "btn_AnaMenu";
            this.btn_AnaMenu.Size = new System.Drawing.Size(156, 52);
            this.btn_AnaMenu.TabIndex = 12;
            this.btn_AnaMenu.Text = "Ana Menü";
            this.btn_AnaMenu.UseVisualStyleBackColor = true;
            this.btn_AnaMenu.Click += new System.EventHandler(this.btn_AnaMenu_Click);
            this.btn_AnaMenu.MouseEnter += new System.EventHandler(this.btn_AnaMenu_MouseEnter);
            // 
            // urunListesiSatici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 826);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid_listele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "urunListesiSatici";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunListesiSatici";
            this.Load += new System.EventHandler(this.urunListesiSatici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listele)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.DataGridView dataGrid_listele;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AnaMenu;
    }
}