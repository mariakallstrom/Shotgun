using System;
using System.Windows.Forms;

namespace Shotgun
{
    class GetAndSet
    {
        public void SetAmmoStartGame()
        {
            SetNpcAmmo(0);
            SetPlayerAmmo(0);

        }

        public void SetPointNewGame()
        {
            FormGame.Fg.LblPointsNPC.Text = "0";
            FormGame.Fg.LblPointsPlay.Text = "0";
        }

        public int GetChoosedScore()
        {
            if (FormGame.Fg.TxtChoose.Text == "")
            {
                SetChoosedScore(3);
            }
            var choosedScore = int.Parse(FormGame.Fg.TxtChoose.Text);
            return choosedScore;
        }

        public void SetChoosedScore(int choosedScore)
        {
            FormGame.Fg.TxtChoose.Text = choosedScore.ToString();
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

        public int GetNpcAmmo()
        {
            var ammoN = FormGame.Fg.LblAmmoCountNpc.Text;
            if (ammoN == "")
            {
                MessageBox.Show(@"Du måste starta spelet");
                return 0;
            }
            var nAmmo = Convert.ToInt32(FormGame.Fg.LblAmmoCountNpc.Text);
            return nAmmo;
        }

        public void SetNpcAmmo(int nAmmo)
        {
            FormGame.Fg.LblAmmoCountNpc.Text = nAmmo.ToString();

        }

        public int GetPlayerAmmo()
        {
            var ammoP = FormGame.Fg.LblAmmoCountPlay.Text;
            if (ammoP == "")
            {
                MessageBox.Show(@"Du måste starta spelet");
                return 0;
            }
            var pAmmo = Convert.ToInt32(FormGame.Fg.LblAmmoCountPlay.Text);
            return pAmmo;
        }

        public void SetPlayerAmmo(int pAmmo)
        {
            FormGame.Fg.LblAmmoCountPlay.Text = pAmmo.ToString();
        }

        public int GetPlayerPoints()
        {
            var pPoint = Convert.ToInt32(FormGame.Fg.LblPointsPlay.Text);
            return pPoint;
        }

        public void SetPlayersPoint(int pPoint)
        {
            FormGame.Fg.LblPointsPlay.Text = pPoint.ToString();
          
        }

        public int GetNpcPoints()
        {
            var nPoint = Convert.ToInt32(FormGame.Fg.LblPointsNPC.Text);
            return nPoint;
        }

        public void SetNpcPoints(int nPoint)
        {
            FormGame.Fg.LblPointsNPC.Text = nPoint.ToString();
        }
        public void StartNewGame()
        {
            FormGame.Fg.LblAmmoCountPlay.Text = "";
            FormGame.Fg.LblAmmoCountNpc.Text = "";
            FormGame.Fg.LblPointsNPC.Text = "";
            FormGame.Fg.LblPointsPlay.Text = "";
        }
    }
}
