using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shotgun.PlayerVsNpcPics;
using Shotgun.PointForm;

namespace Shotgun
{
    class GameCode
    {
        GetAndSet gs = new GetAndSet();
        public int Npc()
        {
            var nAmmo = gs.GetNpcAmmo();
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
                    gs.NpcGetAmmo();
                }
                else if (npc == 2)
                {
                    BlockVsShoot load = new BlockVsShoot();
                    load.Show();
                    gs.NpcLooseAmmo();
                }
                else if (npc == 4)
                {
                    BlockVsShotgun load = new BlockVsShotgun();
                    load.Show();
                    point.Show();
                    NpcWinPoint();
                    gs.SetAmmoStartGame();
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
                gs.NpcLooseAmmo();
                gs.PlayerLooseAmmo();
            }
            else
            {
                if (pShoot != npc)
                {
                    if (npc == 1)
                    {
                        ShootVsBlock load = new ShootVsBlock();
                        load.Show();
                        gs.PlayerLooseAmmo();
                    }
                    else if (npc == 3)
                    {
                        ShootVsLoad load = new ShootVsLoad();
                        load.Show();
                        win.Show();
                        PlayerWinPoint();
                        gs.SetAmmoStartGame();
                    }
                    else if (npc == 4)
                    {
                        ShotgunVSShotgun load = new ShotgunVSShotgun();
                        load.Show();
                        point.Show();
                        NpcWinPoint();
                        gs.SetAmmoStartGame();
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
                gs.PlayerGetAmmo();
                gs.NpcGetAmmo();
            }
            else
            {
                if (npc == 1)
                {
                    LoadVsBlock load = new LoadVsBlock();
                    load.Show();
                    gs.PlayerGetAmmo();
                }
                else if (npc == 2)
                {
                    LoadVsShoot load = new LoadVsShoot();
                    load.Show();
                    point.Show();
                    NpcWinPoint();
                    gs.SetAmmoStartGame();
                }
                else if (npc == 4)
                {
                    LoadVsShotgun load = new LoadVsShotgun();
                    load.Show();
                    point.Show();
                    NpcWinPoint();
                    gs.SetAmmoStartGame();
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
                gs.PlayerLooseAmmo();
                gs.NpcLooseAmmo();
            }
            else
            {

                if (npc == 1)
                {
                    ShotgunVsBlock load = new ShotgunVsBlock();
                    load.Show();
                    point.Show();
                    PlayerWinPoint();
                    gs.SetAmmoStartGame();
                }
                else if (npc == 2)
                {
                    ShotgunVsShoot load = new ShotgunVsShoot();
                    load.Show();
                    point.Show();
                    PlayerWinPoint();
                    gs.SetAmmoStartGame();
                }
                else if (npc == 3)
                {
                    ShotgunVsLoad load = new ShotgunVsLoad();
                    load.Show();
                    point.Show();
                    PlayerWinPoint();
                    gs.SetAmmoStartGame();
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

        public void PlayerWinPoint()
        {
            var pPoint = gs.GetPlayerPoints();
            pPoint++;
            gs.SetPlayersPoint(pPoint);
            PointsCount();

        }

        public void NpcWinPoint()
        {
            var nPoint = gs.GetNpcPoints();
            nPoint++;
            gs.SetNpcPoints(nPoint);
            PointsCount();
        }

        public void PointsCount()
        {
            var nPoint = gs.GetNpcPoints();
            var pPoint = gs.GetPlayerPoints();

            var choosedScore = gs.GetChoosedScore();
            if (nPoint == choosedScore)
            {
                NpcWin win = new NpcWin();
                win.Show();
                gs.StartNewGame();
            }
            if (pPoint == choosedScore)
            {
                PlayerWin win = new PlayerWin();
                win.Show();
                gs.StartNewGame();
            }
        }


    }
}
