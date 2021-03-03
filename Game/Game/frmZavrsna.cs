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
    public partial class frmZavrsna : Form
    {
       
        string _Bodovi;
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        Player _p;
        public frmZavrsna()
        {
            InitializeComponent();
        }
        public frmZavrsna(int Bodovi, Player p)
        {
            InitializeComponent();
            _p = p;
            _Bodovi = Bodovi.ToString();
        }

        private void btnPonovi_Click(object sender, EventArgs e)
        {
            player2.Stop();
            this.Close();
            (new Form1()).Show();
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            player2.Stop();
            player2.SoundLocation = "C:\\Users\\HOME\\Desktop\\New folder\\Amir\\Igrica\\Game\\Game\\song.wav";
            this.Hide();
            new frmProfil(_p,player2).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmZavrsna_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lblBodovi.Text = _Bodovi;
           
            player2.SoundLocation = "C:\\Users\\HOME\\Desktop\\New folder\\Amir\\Igrica\\Game\\Game\\All Legend of Zelda Game Over Themes 1986-2011.wav";
            player2.Play();
        }
    }
}
