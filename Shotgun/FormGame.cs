using System;
using System.Windows.Forms;
using Shotgun.PlayerVsNpcPics;
using Shotgun.PointForm;

//npcBlock = 1;
//npcShoot = 2;
//npcLoad = 3;
//npcShotgun = 4;
//playBlock = 1;
//playShoot = 2;
//playLoad = 3;
//playShotgun = 4;

namespace Shotgun
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
            Fg = this;
        }

        public static FormGame Fg;

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
           GetAndSet gs = new GetAndSet();
            gs.SetAmmoStartGame();
            gs.SetPointNewGame();
            gs.GetChoosedScore();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            GameCode gc = new GameCode();
            if (LblAmmoCountPlay.Text == "")
            {
                MessageBox.Show(@"Du måste starta spelet");
            }
            else
            {
                var x = gc.Npc();
                gc.PlayerLoadsComputer(x);
            }
        }

        private void BtnBlock_Click(object sender, EventArgs e)
        {
            GameCode gc = new GameCode();
            var ammoP = LblAmmoCountPlay.Text;
            if (ammoP == "")
            {
                MessageBox.Show(@"Du måste starta spelet");
            
            }
            else
            {
                var x = gc.Npc();
               gc.PlayerBlocksComputer(x);
            }

        }

        private void BtnShoot_Click(object sender, EventArgs e)
        {
            GameCode gc = new GameCode();
            GetAndSet gs = new GetAndSet();
            var ammoP = LblAmmoCountPlay.Text;
            if (ammoP == "")
            {
                MessageBox.Show(@"Du måste starta spelet");
            }
            else
            {
                if (gs.GetPlayerAmmo() == 0)
                {
                    NoBullets no = new NoBullets();
                    no.Show();
                }
                else
                {
                    var x = gc.Npc();
                    gc.PlayerShootsComputer(x);
                }
            }
         
        }

        private void BtnShotgun_Click(object sender, EventArgs e)
        {
            GameCode gc = new GameCode();
            GetAndSet gs = new GetAndSet();
            var ammoP = LblAmmoCountPlay.Text;
            if (ammoP == "")
            {
                MessageBox.Show(@"Du måste starta spelet");
            }
            else
            {
                var x = gs.GetPlayerAmmo();

                if (x < 3)
                {
                    NoBullets no = new NoBullets();
                    no.Show();

                }
                else
                {
                    var n = gc.Npc();
                    gc.PlayerShotgunsComputer(n);
                }
            }
           
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
