using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form2 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void noviIgracToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmPocetna().Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmPocetna(player).Show();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

            player.SoundLocation = "C:\\Users\\HOME\\Desktop\\New folder\\Amir\\Igrica\\Game\\Game\\song.wav";
            player.Play();


        }

        private void eNDGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Close();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmPocetna(player).Show();
        }

        private void btnRegistracija_MouseHover(object sender, EventArgs e)
        {

           

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmPrijava(player).Show();
        }

        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRanking().Show();
        }
    }
}
