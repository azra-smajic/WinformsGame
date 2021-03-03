namespace Game
{
    partial class frmPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPocetna));
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ofdUcitajSliku = new System.Windows.Forms.OpenFileDialog();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodaj.BackgroundImage")));
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodaj.Location = new System.Drawing.Point(879, 382);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(81, 71);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(117, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Picture:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtIme.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.Color.Blue;
            this.txtIme.Location = new System.Drawing.Point(425, 126);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(403, 54);
            this.txtIme.TabIndex = 2;
            this.txtIme.Text = "Player";
            this.txtIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            this.txtIme.MouseLeave += new System.EventHandler(this.txtIme_MouseLeave);
            this.txtIme.MouseHover += new System.EventHandler(this.txtIme_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(420, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPassword.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Blue;
            this.txtPassword.Location = new System.Drawing.Point(425, 312);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(403, 54);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Player";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPPassword_MouseLeave);
            this.txtPassword.MouseHover += new System.EventHandler(this.txtPPassword_MouseHover);
            // 
            // pbSlika
            // 
            this.pbSlika.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSlika.BackgroundImage")));
            this.pbSlika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSlika.Location = new System.Drawing.Point(122, 126);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(272, 228);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 4;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            this.pbSlika.MouseLeave += new System.EventHandler(this.pbSlika_MouseLeave);
            this.pbSlika.MouseHover += new System.EventHandler(this.pbSlika_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(420, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player Name:";
            // 
            // ofdUcitajSliku
            // 
            this.ofdUcitajSliku.FileName = "openFileDialog1";
            // 
            // txtSlika
            // 
            this.txtSlika.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSlika.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSlika.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlika.Location = new System.Drawing.Point(122, 360);
            this.txtSlika.Multiline = true;
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(272, 93);
            this.txtSlika.TabIndex = 6;
            this.txtSlika.Text = "Ukoliko zelite da ucitate svoju sliku, kliknite dva puta na postojecu a potom oda" +
    "berite sliku sa vaseg racunara";
            // 
            // txtPName
            // 
            this.txtPName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPName.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(425, 197);
            this.txtPName.Multiline = true;
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(403, 50);
            this.txtPName.TabIndex = 7;
            this.txtPName.Text = "Ukoliko ne promjenite ime, ono ce automatski biti dodano";
            // 
            // txtPPassword
            // 
            this.txtPPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPPassword.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPassword.Location = new System.Drawing.Point(425, 382);
            this.txtPPassword.Multiline = true;
            this.txtPPassword.Name = "txtPPassword";
            this.txtPPassword.Size = new System.Drawing.Size(403, 71);
            this.txtPPassword.TabIndex = 8;
            this.txtPPassword.Text = "Ukoliko ne promijenite password bt ce vam automatski dodijeljen, a vrijednost ce " +
    "mu biti kao i ime";
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 527);
            this.ControlBox = false;
            this.Controls.Add(this.txtPPassword);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPocetna";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPocetna_FormClosing);
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofdUcitajSliku;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPPassword;
    }
}