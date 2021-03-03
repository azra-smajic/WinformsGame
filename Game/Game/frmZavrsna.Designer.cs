namespace Game
{
    partial class frmZavrsna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZavrsna));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPonovi = new System.Windows.Forms.Button();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBodovi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(283, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "BROJ BODOVA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPonovi
            // 
            this.btnPonovi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPonovi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPonovi.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonovi.Location = new System.Drawing.Point(233, 295);
            this.btnPonovi.Name = "btnPonovi";
            this.btnPonovi.Size = new System.Drawing.Size(180, 57);
            this.btnPonovi.TabIndex = 1;
            this.btnPonovi.Text = "Igraj Ponovo";
            this.btnPonovi.UseVisualStyleBackColor = false;
            this.btnPonovi.Click += new System.EventHandler(this.btnPonovi_Click);
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZavrsi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZavrsi.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZavrsi.Location = new System.Drawing.Point(560, 295);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(185, 57);
            this.btnZavrsi.TabIndex = 2;
            this.btnZavrsi.Text = "Završi Igricu";
            this.btnZavrsi.UseVisualStyleBackColor = false;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(283, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 53);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mischief managed";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBodovi
            // 
            this.lblBodovi.AutoSize = true;
            this.lblBodovi.BackColor = System.Drawing.Color.Transparent;
            this.lblBodovi.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodovi.ForeColor = System.Drawing.Color.Black;
            this.lblBodovi.Location = new System.Drawing.Point(623, 188);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(0, 53);
            this.lblBodovi.TabIndex = 3;
            // 
            // frmZavrsna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 485);
            this.ControlBox = false;
            this.Controls.Add(this.lblBodovi);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.btnPonovi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmZavrsna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmZavrsna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPonovi;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBodovi;
    }
}