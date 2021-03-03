using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading;

using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        bool provjera = false;
        string PlayerName;
        int i = 0;
        int bodovi = 0;
        int Level = 1;
        int brojac = 0;
        bool stop = false;
        int bodoviZaIgru = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        Thread t1;
        Thread t2;
        Thread t3;
        KonekcijaNaBazu kb = InstancaBaze.kb;
        Player _player;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Player player):this()
        {
            PlayerName = player.Ime;
            _player = player;
        }

        private void UcitajStatistiku()
        {
            lblPlayer.Text = PlayerName;
            lblBodovi.Text = bodovi.ToString();
            pbBodovi.Value = bodoviZaIgru;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            Position.SetControlPosition(btnGlavni, e.Location.X, e.Location.Y);
            if (provjera)
            {
               
                this.Close();
                player.Stop();
                
                System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
                player2.SoundLocation = "C:\\Users\\HOME\\Desktop\\New folder\\Amir\\Igrica\\Game\\Game\\Super Mario Bros - You're dead Sound effect.wav";
                player2.Play();
                Thread.Sleep(3000);

                EndGame();
                DialogResult = DialogResult.OK;

                
            }




        }



        private void MoveRandBtn()
        {


            while (true)
            {
                if (stop)
                    break;

                Thread.Sleep(100);

                Action a = () =>
                {
                    if (i < this.Controls.Count)
                    {
                        if (this.Controls[i++] is Button)
                        {
                            if (i >= this.Controls.Count)
                            {
                                i = 0;
                            }

                            var btn = this.Controls[i] as Button;
                            if (btn!= null && btn.Name != btnGlavni.Name && btn.Name != btnEnd.Name)
                            {
                                Position.SetControlPosition(btn, btn.Location.X - btn.Size.Width, btn.Location.Y);


                                if (btn.Location.X <= -btn.Location.X)
                                {
                                    this.Controls.Remove(btn);
                                }
                            }
                        }
                    }
                };
                if (provjera == true)
                {
                    break;
                }
                BeginInvoke(a);


            }


        }

        public void CheckCollision()
        {
            while (true)
            {

                if (stop)
                    break;
                Thread.Sleep(1);

                Action a = () =>
                {
                    if (i < this.Controls.Count)
                    {
                        if (this.Controls[i++] is Button)
                        {
                            if (i >= this.Controls.Count)
                            {
                                i = 0;
                            }

                            var btn = this.Controls[i] as Button;
                            if (btn!=null && btn.Name != btnGlavni.Name && btn.Name != btnEnd.Name)
                            {
                                if (CollisionCalc.Calc(btnGlavni, btn) || CollisionCalc.CalcFire(btnGlavni,pictureBox1))
                                {

                                    provjera = true;
                                }


                            }
                        }
                    }
                };
                if (provjera == true)
                {
                    break;
                }
                BeginInvoke(a);





            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UcitajStatistiku();
            UcitajDugme();
            player.SoundLocation = "C:\\Users\\HOME\\Desktop\\New folder\\Amir\\Igrica\\Game\\Game\\Crash Bandicoot 3 - Warped - Theme.wav";
            player.Play();
            t1 = new Thread(RandBtn);
             t2 = new Thread(MoveRandBtn);
             t3 = new Thread(CheckCollision);
            t1.Start();
            t2.Start();
            t3.Start();





        }

        private void UcitajDugme()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, btnGlavni.Width, btnGlavni.Height);
            btnGlavni.Region = new Region(gp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gp.Dispose();

        }

        public void RandBtn()
        {


            while (true)
            {

                if (stop)
                    break;
                Thread.Sleep(1000);

                Action a = () =>
                {
                
                        Button RandButt = new Button();
                        RandButton.SetRandButton(RandButt);
                        Random random = new Random();
                        Position.SetControlPosition(RandButt, this.Size.Width - RandButt.Size.Width, random.Next(this.Size.Height - RandButt.Size.Height));
                    if (Level!=ChangeLevel.Level)
                    {
                        ChangeLevel.NextLevel(RandButt);
                    }
                        this.Controls.Add(RandButt);
                    
                    bodovi += 3;
                    bodoviZaIgru += 3;
                    if (bodoviZaIgru>33)
                    {
                        bodoviZaIgru = 0;

                    }
                    UcitajStatistiku();
                    if (bodovi%33==0)
                    {
                        Level = ChangeLevel.NextLevel(btnGlavni, this);
                        bodoviZaIgru = 0;
                        pbBodovi.Value = 0;
                    }

                };
                if (provjera == true)
                {
                    break;
                    
                    
                }
                BeginInvoke(a);
            }

        }

        private void btnGlavni_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            EndGame();
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void EndGame()
        {
            stop = true;
            int xp = bodovi / 4;
            _player.XP += xp;

            brojac = _player.Level.Id;
            Level l = kb.Levels.ToList()[brojac];
            if (_player.XP>=l.XP)
            {
                
                if (brojac <= kb.Levels.ToList().Count())
                {
                    _player.Level = kb.Levels.ToList()[brojac];
                    _player.XP = 0;
                }
            }
            kb.Entry(_player).State = System.Data.Entity.EntityState.Modified;
            kb.SaveChanges();
            t1.Join();
            t2.Join();
            t3.Join();

            
            ResetujIgru();
        }

        private void ResetujIgru()
        {
            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    var btn = item as Button;
                    if (btn != null && btn.Name != btnGlavni.Name)
                    {
                        this.Controls.Remove(btn);
                    }
                }

            }
            if (provjera == true)
            {
                this.Hide();
                new frmZavrsna(bodovi,_player).Show();

            }
            stop = false;
            bodovi = 0;
            bodoviZaIgru = 0;
            
            Level = 1;
            ChangeLevel.Level = 1;
            
        }
    }
}
