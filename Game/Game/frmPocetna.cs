using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class frmPocetna : Form
    {
        string PlayerName;
        System.Media.SoundPlayer _player;
        KonekcijaNaBazu kb = InstancaBaze.kb;
        public frmPocetna()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        public frmPocetna(System.Media.SoundPlayer player) :this()
        {
            _player = player;
        }
        private void UcitajDugme()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, btnDodaj.Width, btnDodaj.Height);
            btnDodaj.Region = new Region(gp);

            gp.Dispose();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
          
            this.Hide();
           
           Player p= DodajPlayera();
            Form frm = new frmProfil(p,_player);
            frm.Show();



        }

        private Player DodajPlayera()
        {
            Player p = new Player();
            p.Ime = txtIme.Text;
            p.Password = txtPassword.Text;
            if (pbSlika.Image == null)
             p.Slika = ImageHelper.FromImageToByte(pbSlika.BackgroundImage);
            else
                p.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
            p.Level = kb.Levels.ToList()[0];
            p.XP = 0;
            kb.Players.Add(p);
            kb.SaveChanges();
            return p;
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            PlayerName = txtIme.Text;
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            
            PlayerName = txtIme.Text;
            txtSlika.Hide();
            txtPName.Hide();
            txtPPassword.Hide();

        }

        private void frmPocetna_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Da li zelite napustiti igru?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.No)
            {
                this.Hide();
                this.Show();
            }
               
                
            
        }

        private void pbSlika_MouseHover(object sender, EventArgs e)
        {
            txtSlika.Show();
        }

        private void pbSlika_MouseLeave(object sender, EventArgs e)
        {
            txtSlika.Hide();
        }

        private void txtIme_MouseHover(object sender, EventArgs e)
        {
            txtPName.Show();
        }

        private void txtIme_MouseLeave(object sender, EventArgs e)
        {
            txtPName.Hide();

        }

        private void txtPPassword_MouseHover(object sender, EventArgs e)
        {
            txtPPassword.Show();
        }

        private void txtPPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPPassword.Hide();
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (ofdUcitajSliku.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofdUcitajSliku.FileName);
               
            }
        }
    }
}
