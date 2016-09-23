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
                    NoBullets no = new NoBullets();
                    no.Show();
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
                    NoBullets no = new NoBullets();
                    no.Show();

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
            OnePointToNpc point = new OnePointToNpc();
            

            var pBlock = PlayerBlock();

            if (pBlock == npc)
            {
                BlockVsBlock load = new BlockVsBlock();
                    load.Show();
            }
            else
            {
                if (npc == 3)
                {
                   BlockVsLoad load = new BlockVsLoad();
                    load.Show();
                    NpcGetAmmo();
                }
                else if (npc == 2)
                {
                    BlockVsShoot load = new BlockVsShoot();
                    load.Show();
                    NpcLooseAmmo();
                }
                else if (npc == 4)
                {
                    BlockVsShotgun load = new BlockVsShotgun();
                    load.Show();
                    point.Show();
                    NpcWinPoint();
                    SetAmmoStartGame();
                }
            }
        }
        public void PlayerShootsComputer(int npc)
        {
            OnePointToNpc point = new OnePointToNpc();
            PlayerOnePoint win = new PlayerOnePoint();
            var pShoot = PlayerShoot();
            if (pShoot == npc)
            {
                ShootVsShoot load = new ShootVsShoot();
                load.Show();
                NpcLooseAmmo();
                PlayerLooseAmmo();
            }
            else
            {
                if (pShoot != npc)
                {
                    if (npc == 1)
                    {
                        ShootVsBlock load = new ShootVsBlock();
                        load.Show();
                        PlayerLooseAmmo();
                    }
                    else if (npc == 3)
                    {
                        ShootVsLoad load = new ShootVsLoad();
                        load.Show();
                        win.Show();
                        PlayerWinPoint();
                        SetAmmoStartGame();
                    }
                    else if (npc == 4)
                    {
                        ShotgunVSShotgun load = new ShotgunVSShotgun();
                        load.Show();
                        point.Show();
                        NpcWinPoint();
                        SetAmmoStartGame();
                    }
                }
            }
           
        }

        public void PlayerLoadsComputer(int npc)
        {
           OnePointToNpc point = new OnePointToNpc();
            if (PlayerLoad() == npc)
            {
                LoadVsLoad load = new LoadVsLoad();
                load.Show();
                PlayerGetAmmo();
                NpcGetAmmo();
            }
            else
            {
                if (npc == 1)
                {
                    LoadVsBlock load = new LoadVsBlock();
                    load.Show();
                    PlayerGetAmmo();
                }
                else if (npc == 2)
                {
                   LoadVsShoot load = new LoadVsShoot();
                    load.Show();
                    point.Show();
                    NpcWinPoint();
                    SetAmmoStartGame();
                }
                else if (npc == 4)
                {
                   LoadVsShotgun load = new LoadVsShotgun();
                    load.Show();
                    point.Show();
                    NpcWinPoint();
                    SetAmmoStartGame();
                }
            }
        }

        public void PlayerShotgunsComputer(int npc)
        {
            PlayerOnePoint point = new PlayerOnePoint();
            if (PlayerShotgun() == npc)
            {
                ShotgunVSShotgun load = new ShotgunVSShotgun();
                load.Show();
                PlayerLooseAmmo();
                NpcLooseAmmo();
            }
            else
            {
           
            if (npc == 1)
                {
                    ShotgunVsBlock load = new ShotgunVsBlock();
                    load.Show();
                    point.Show();
                    PlayerWinPoint();
                    SetAmmoStartGame();
                }
                else if (npc == 2)
                {
                   ShotgunVsShoot load = new ShotgunVsShoot();
                    load.Show();
                    point.Show();
                   PlayerWinPoint();
                    SetAmmoStartGame();
                }
                else if (npc == 3)
                {
                   ShotgunVsLoad load = new ShotgunVsLoad();
                    load.Show();
                    point.Show();
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

        public int GetChoosedScore()
        {
            if (TxtChoose.Text == "")
            {
                SetChoosedScore(3);
            }
            var choosedScore = int.Parse(TxtChoose.Text);
            return choosedScore;
        }

        public void SetChoosedScore(int choosedScore)
        {
            TxtChoose.Text = choosedScore.ToString();
        }

        public void PointsCount()
        {
            var nPoint = GetNpcPoints();
            var pPoint = GetPlayerPoints();

            var choosedScore = GetChoosedScore();
            if (nPoint == choosedScore)
            {
                NpcWin win = new NpcWin();
                win.Show();
                StartNewGame();
            }
            if (pPoint == choosedScore)
            {
                PlayerWin win = new PlayerWin();
                win.Show();
                StartNewGame();
            }
        }

        public void StartNewGame()
        {
            LblAmmoCountPlay.Text = "";
            LblAmmoCountNpc.Text = "";
            LblPointsNPC.Text = "";
            LblPointsPlay.Text = "";
        }

   
    }
}
