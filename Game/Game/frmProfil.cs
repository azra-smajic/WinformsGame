using cSharpIntroWinForms.P9;
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
    public partial class frmProfil : Form
    {
        KonekcijaNaBazu kb = InstancaBaze.kb;
        Player _p;
        System.Media.SoundPlayer _player;

        public frmProfil()
        {
            InitializeComponent();
        }
        public frmProfil(Player p, System.Media.SoundPlayer player) : this()
        {
            _p = p;
            _player = player;
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {
            lblIme.Text = _p.Ime;
            lblLevel.Text = _p.Level.Ime;
            Level l = kb.Levels.ToList()[_p.Level.Id];
            pbXP.Maximum = l.XP;
            pbXP.Value = _p.XP;
            _player.Play();
            pbSlika.Image = ImageHelper.FromByteToImage(_p.Slika);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _player.Stop();
            this.Hide();
            new Form1(_p).Show();
        }

        private void lblEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _player.Stop();
            this.Hide();
            new Form2().Show();

        }
    }
}
