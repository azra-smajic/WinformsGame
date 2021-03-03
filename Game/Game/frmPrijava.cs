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
    public partial class frmPrijava : Form
    {
        KonekcijaNaBazu kb = InstancaBaze.kb;
        System.Media.SoundPlayer player;
        public frmPrijava()
        {
            InitializeComponent();
        }
        public frmPrijava(System.Media.SoundPlayer _player):this()
        {
            player = _player;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var lst = kb.Players.ToList();
            var Ime = txtIme.Text;
            var Password = txtPassword.Text;
            foreach (var item in lst)
            {
                if (item.Ime.ToLower() == Ime.ToLower() && item.Password.ToLower() == Password.ToLower())
                {
                    this.Hide();
                    new frmProfil(item, player).Show();
                    return;

                }
            }
            this.Hide();
            new frmPocetna(player).Show();

        }
    }
}
