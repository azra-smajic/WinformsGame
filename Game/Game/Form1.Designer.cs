namespace Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGlavni = new System.Windows.Forms.Button();
            this.ssStatistika = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBodovi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbBodovi = new System.Windows.Forms.ToolStripProgressBar();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ofdUcitajSliku = new System.Windows.Forms.OpenFileDialog();
            this.ssStatistika.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGlavni
            // 
            this.btnGlavni.BackColor = System.Drawing.Color.Red;
            this.btnGlavni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGlavni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGlavni.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnGlavni.FlatAppearance.BorderSize = 3;
            this.btnGlavni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGlavni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlavni.Location = new System.Drawing.Point(183, 203);
            this.btnGlavni.Name = "btnGlavni";
            this.btnGlavni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGlavni.Size = new System.Drawing.Size(57, 56);
            this.btnGlavni.TabIndex = 0;
            this.btnGlavni.UseVisualStyleBackColor = false;
            this.btnGlavni.Click += new System.EventHandler(this.btnGlavni_Click);
            // 
            // ssStatistika
            // 
            this.ssStatistika.BackColor = System.Drawing.Color.SeaGreen;
            this.ssStatistika.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatistika.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPlayer,
            this.toolStripStatusLabel1,
            this.lblBodovi,
            this.toolStripStatusLabel2,
            this.pbBodovi});
            this.ssStatistika.Location = new System.Drawing.Point(0, 471);
            this.ssStatistika.Name = "ssStatistika";
            this.ssStatistika.Size = new System.Drawing.Size(1065, 36);
            this.ssStatistika.TabIndex = 1;
            this.ssStatistika.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 30);
            this.toolStripStatusLabel1.Text = "Bodovi:";
            // 
            // lblBodovi
            // 
            this.lblBodovi.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(0, 30);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(233, 30);
            this.toolStripStatusLabel2.Text = "Do iduceg levela:";
            // 
            // pbBodovi
            // 
            this.pbBodovi.Maximum = 33;
            this.pbBodovi.Name = "pbBodovi";
            this.pbBodovi.Size = new System.Drawing.Size(100, 28);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Maroon;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(957, 471);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(108, 36);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "KRAJ";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(0, 30);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1065, 29);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(463, 26);
            this.toolStripLabel1.Text = "I solemnly swear that I am up to no good.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ofdUcitajSliku
            // 
            this.ofdUcitajSliku.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 507);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.ssStatistika);
            this.Controls.Add(this.btnGlavni);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ssStatistika.ResumeLayout(false);
            this.ssStatistika.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGlavni;
        private System.Windows.Forms.StatusStrip ssStatistika;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblBodovi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar pbBodovi;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ToolStripStatusLabel lblPlayer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog ofdUcitajSliku;
    }
}

