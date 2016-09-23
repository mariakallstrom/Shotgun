using System;
using System.Windows.Forms;

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
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            SetAmmoStartGame();
            SetPointNewGame();
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
            var ammoP = LblAmmoCountPlay.Text;
            if (ammoP == "")
            {
                MessageBox.Show(@"Du måste starta spelet");
            
            }
            else
            {
                var x = Npc();
                PlayerBlocksComputer(x);
            }

        }

        private void BtnShoot_Click(object sender, EventArgs e)
        {
            var ammoP = LblAmmoCountPlay.Text;
            if (ammoP == "")
            {
                MessageBox.Show(@"Du måste starta spelet");
            }
            else
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
         
        }

        private void BtnShotgun_Click(object sender, EventArgs e)
        {
            var ammoP = LblAmmoCountPlay.Text;
            if (ammoP == "")
            {
                MessageBox.Show(@"Du måste starta spelet");
            }
            else
            {
                var x = GetPlayerAmmo();

                if (x < 3)
                {
                    MessageBox.Show(@"Du har för lite skott!");

                }
                else
                {
                    var n = Npc();
                    PlayerShotgunsComputer(n);
                }
            }
           
        }

        public void SetAmmoStartGame()
        {
            SetNpcAmmo(0);
            SetPlayerAmmo(0);

        }

        public void SetPointNewGame()
        {
            SetNpcPoints(0);
            SetPlayersPoint(0);
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
                    MessageBox.Show(@"Blocka ot Shotgun, datorn fick poäng!");
                    NpcWinPoint();
                    SetAmmoStartGame();
                }
            }
        }
        public void PlayerShootsComputer(int npc)
        {
            var pShoot = PlayerShoot();
            if (pShoot == npc)
            {
                MessageBox.Show(@"Skjuta mot skjuta");
                NpcLooseAmmo();
                PlayerLooseAmmo();
            }
            else
            {
                if (pShoot != npc)
                {
                    if (npc == 1)
                    {
                        MessageBox.Show(@"Skjuta mot Blocka");
                        PlayerLooseAmmo();
                    }
                    else if (npc == 3)
                    {
                        MessageBox.Show(@"Skjuta mot ladda. Du fick poäng!");
                        PlayerWinPoint();
                        SetAmmoStartGame();
                    }
                    else if (npc == 4)
                    {
                        MessageBox.Show(@"Datorn fick poäng!");
                        NpcWinPoint();
                        SetAmmoStartGame();
                    }
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
                    MessageBox.Show(@"Ladda mot skjuta. Datorn fick poäng!");
                    NpcWinPoint();
                    SetAmmoStartGame();
                }
                else if (npc == 4)
                {
                    MessageBox.Show(@"Ladda mot shotgun. Datorn fick poäng!");
                    NpcWinPoint();
                    SetAmmoStartGame();
                }
            }
        }

        public void PlayerShotgunsComputer(int npc)
        {
            if (PlayerShotgun() == npc)
            {
                MessageBox.Show(@"Shotgun mot Shotgun");
                PlayerLooseAmmo();
                NpcLooseAmmo();
            }
            else
            {
           
            if (npc == 1)
                {
                    MessageBox.Show(@"Shotgun mot blocka! Du fick poäng!");
                    PlayerWinPoint();
                    SetAmmoStartGame();
                }
                else if (npc == 2)
                {
                    MessageBox.Show(@"Shotgun mot Skjuta! Du fick poäng!");
                   PlayerWinPoint();
                    SetAmmoStartGame();
                }
                else if (npc == 3)
                {
                    MessageBox.Show(@"Shotgun mot Ladda! Du fick poäng!");
                   PlayerWinPoint();
                    SetAmmoStartGame();
                }
            }
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
            var ammoN = LblAmmoCountNpc.Text;
            if (ammoN == "")
            {
                MessageBox.Show(@"Du måste starta spelet");
                return 0;
            }
            var nAmmo = Convert.ToInt32(LblAmmoCountNpc.Text);
            return nAmmo;
        }

        public void SetNpcAmmo(int nAmmo)
        {
            LblAmmoCountNpc.Text = nAmmo.ToString();
           
        }

        public int GetPlayerAmmo()
        {
            var ammoP = LblAmmoCountPlay.Text;
            if (ammoP == "")
            {
                MessageBox.Show(@"Du måste starta spelet");
                return 0;
            }
                var pAmmo = Convert.ToInt32(LblAmmoCountPlay.Text);
                return pAmmo;
            }

        public void SetPlayerAmmo(int pAmmo)
        {
            LblAmmoCountPlay.Text = pAmmo.ToString();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int GetPlayerPoints()
        {
            var pPoint = Convert.ToInt32(LblPointsPlay.Text);
            return pPoint;
        }

        public void SetPlayersPoint(int pPoint)
        {
            LblPointsPlay.Text = pPoint.ToString();
        }

        public int GetNpcPoints()
        {
            var nPoint = Convert.ToInt32(LblPointsNPC.Text);
            return nPoint;
        }

        public void SetNpcPoints(int nPoint)
        {
            LblPointsNPC.Text = nPoint.ToString();
        }

        public void PlayerWinPoint()
        {
            var pPoint = GetPlayerPoints();
            pPoint++;
            SetPlayersPoint(pPoint);
            PointsCount();
        
        }

        public void NpcWinPoint()
        {
            var nPoint = GetNpcPoints();
            nPoint++;
            SetNpcPoints(nPoint);
            PointsCount();
        }

        public void PointsCount()
        {
            var nPoint = GetNpcPoints();
            var pPoint = GetPlayerPoints();

            if (nPoint == 3)
            {
                MessageBox.Show(@"Datorn vann!");
                StartNewGame();
            }
            if (pPoint == 3)
            {
                MessageBox.Show(@"Du vann!");
                StartNewGame();
            }
        }

        public void StartNewGame()
        {
            LblAmmoCountPlay.Text = "";
            LblAmmoCountNpc.Text = "";
            LblPointsNPC.Text = "";
            LblPointsPlay.Text = "";
            Application.Run(this);
        }


    }
}
