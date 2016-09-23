using System;
using System.Windows.Forms;


namespace Shotgun

//npcBlock = 1;
//npcShoot = 2;
//npcLoad = 3;
//npcShotgun = 4;
//playBlock = 1;
//playShoot = 2;
//playLoad = 3;
//playShotgun = 4;
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }


        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            SetAmmoStartGame();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (LblAmmoCountPlay.Text == "")
            {
                MessageBox.Show(@"Du måste starta spelet");
            }
            else
            {
                var x = Npc();
                PlayerLoadsComputer(x);
            }

        }

        private void BtnBlock_Click(object sender, EventArgs e)
        {
            var x = Npc();
            PlayerBlocksComputer(x);
        }

        private void BtnShoot_Click(object sender, EventArgs e)
        {
            if (GetPlayerAmmo() == 0)
            {
                MessageBox.Show(@"Du har inga skott!");
            }
            else
            {
                var x = Npc();
                PlayerShootsComputer(x);
            }

        }

        private void BtnShotgun_Click(object sender, EventArgs e)
        {
            var x = Npc();
            PlayerShotgunsComputer(x);
        }

        public void PlayerBlocksComputer(int npc)
        {
            var pBlock = PlayerBlock();

            if (pBlock == npc)
            {
                MessageBox.Show(@"Blocka mot Blocka!");
            }
            else
            {
                if (npc == 3)
                {
                    MessageBox.Show(@"Blocka mot Ladda");
                    NpcGetAmmo();
                }
                else if (npc == 2)
                {
                    MessageBox.Show(@"Blocka mot Skjuta");
                    NpcLooseAmmo();
                }
                else if (npc == 4)
                {
                    MessageBox.Show(@"Datorn vann!");
                }
            }
        }
        public void PlayerShootsComputer(int npc)
        {
            var pShoot = PlayerShoot();
            if (pShoot != npc)
            {
                if (npc == 1)
                {
                    MessageBox.Show(@"Skjuta mot Blocka");
                    PlayerLooseAmmo(); 
                }
               else if (npc == 3)
                {
                    MessageBox.Show(@"Du vann!");
                }
                else if (npc == 4)
                {
                    MessageBox.Show(@"Datorn vann!");
                }
            }
        }
        public void PlayerLoadsComputer(int npc)
        {
            if (PlayerLoad() == npc)
            {
                PlayerGetAmmo();
                NpcGetAmmo();
            }
            else
            {
                if (npc == 1)
                {
                    MessageBox.Show(@"Ladda mot Blocka");
                    PlayerGetAmmo();
                }
                else if (npc == 2)
                {
                    MessageBox.Show(@"Datorn vann!");
                }
                else if (npc == 4)
                {
                    MessageBox.Show(@"Datorn vann!");
                }
            }
        }
        public void PlayerShotgunsComputer(int npc)
        {
            if (PlayerShotgun() != npc)
            {
                MessageBox.Show(@"Du vann!");
            }
        }
        
        public void SetAmmoStartGame()
        {
            SetPlayerAmmo(0);
            SetNpcAmmo(0);
        }
        public int PlayerLoad()
        {
            return 3;
        }


        public int PlayerShoot()
        {
            return 2;
        }

        public int PlayerBlock()
        {
            return 1;
        }

        public int PlayerShotgun()
        {
            var x = GetPlayerAmmo();

            if (x < 3)
            {
                MessageBox.Show(@"Du har för lite skott!");
                return 0;
            }
               
                return 4;
        }

        public void PlayerGetAmmo()
        {
            var pAmmo = GetPlayerAmmo();
            pAmmo++;
            SetPlayerAmmo(pAmmo);
        }



        public void PlayerLooseAmmo()
        {
            var pAmmo = GetPlayerAmmo();
            pAmmo--;
            SetPlayerAmmo(pAmmo);
        }




        public void NpcGetAmmo()
        {
            var nAmmo = GetNpcAmmo();
            nAmmo++;
            SetNpcAmmo(nAmmo);
        }

        public void NpcLooseAmmo()
        {
            var nAmmo = GetNpcAmmo();
            nAmmo--;
            SetNpcAmmo(nAmmo);
        }

        public int Npc()
        {
            var nAmmo = GetNpcAmmo();
            var x = 0;
            if (nAmmo == 0)
            {
                return 3;
            }
            Random random = new Random();
            var r = random.Next(1, 4);

            if (r == 1)
            {
                x = 1;
            }
            else if (r == 2)
            {
                x = 2;
            }
            else if (r == 3)
            {
                x = 3;
            }
            else if (r == 4 && nAmmo <= 3)
            {
                x = 4;
            }
            else
            {
                Npc();
            }
            return x;
        }




        public int GetNpcAmmo()
        {
            var nAmmo = Convert.ToInt32(LblAmmoCountNpc.Text);
            return nAmmo;
        }

        public void SetNpcAmmo(int nAmmo)
        {
            LblAmmoCountNpc.Text = nAmmo.ToString();
           
        }

        public int GetPlayerAmmo()
        {
            var pAmmo = Convert.ToInt32(LblAmmoCountPlay.Text);
            return pAmmo;
        }

        public void SetPlayerAmmo(int pAmmo)
        {
            LblAmmoCountPlay.Text = pAmmo.ToString();
        }

    





        // QuitGame



        //Ladda mot ladda: Båda spelarna får ett skott
        //Ladda mot blocka Spelaren som laddar får ett skott
        //Blocka mot blocka Ingenting händer
        //Skjuta mot blocka Spelaren som skjuter förlorar ett skott
        //Skjuta mot skjuta Båda spelarna förlorar ett skott
        //Skjuta mot ladda Spelaren som skjuter vinner spelet

    }
}
