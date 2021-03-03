namespace Game
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNDGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 43);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenu
            // 
            this.btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rankingToolStripMenuItem,
            this.eNDGAMEToolStripMenuItem});
            this.btnMenu.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(107, 39);
            this.btnMenu.Text = "Menu";
            this.btnMenu.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(241, 40);
            this.rankingToolStripMenuItem.Text = "Ranking";
            this.rankingToolStripMenuItem.Click += new System.EventHandler(this.rankingToolStripMenuItem_Click);
            // 
            // eNDGAMEToolStripMenuItem
            // 
            this.eNDGAMEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.eNDGAMEToolStripMenuItem.Name = "eNDGAMEToolStripMenuItem";
            this.eNDGAMEToolStripMenuItem.Size = new System.Drawing.Size(241, 40);
            this.eNDGAMEToolStripMenuItem.Text = "END GAME";
            this.eNDGAMEToolStripMenuItem.Click += new System.EventHandler(this.eNDGAMEToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "dobro dosli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1068, 205);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrijava.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(344, 155);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(348, 68);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Imate Profil?";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistracija.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracija.Location = new System.Drawing.Point(344, 316);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(348, 68);
            this.btnRegistracija.TabIndex = 5;
            this.btnRegistracija.Text = "Registruj se!";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            this.btnRegistracija.MouseHover += new System.EventHandler(this.btnRegistracija_MouseHover);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 569);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem eNDGAMEToolStripMenuItem;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnRegistracija;
    }
}