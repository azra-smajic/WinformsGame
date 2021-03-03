namespace Game
{
    partial class frmRanking
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
            this.dgvRank = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblBack = new System.Windows.Forms.ToolStripLabel();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRank
            // 
            this.dgvRank.AllowUserToAddRows = false;
            this.dgvRank.AllowUserToDeleteRows = false;
            this.dgvRank.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvRank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Level,
            this.XP});
            this.dgvRank.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRank.Location = new System.Drawing.Point(0, 36);
            this.dgvRank.Name = "dgvRank";
            this.dgvRank.ReadOnly = true;
            this.dgvRank.RowHeadersWidth = 51;
            this.dgvRank.RowTemplate.Height = 24;
            this.dgvRank.Size = new System.Drawing.Size(1083, 456);
            this.dgvRank.TabIndex = 0;
            this.dgvRank.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblBack
            // 
            this.lblBack.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(76, 30);
            this.lblBack.Text = "BACK";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "Level";
            this.Level.MinimumWidth = 6;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // XP
            // 
            this.XP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.XP.DataPropertyName = "XP";
            this.XP.HeaderText = "XP";
            this.XP.MinimumWidth = 6;
            this.XP.Name = "XP";
            this.XP.ReadOnly = true;
            // 
            // frmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 480);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvRank);
            this.Name = "frmRanking";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRank;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn XP;
    }
}