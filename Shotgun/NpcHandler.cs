using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun
{
    class NpcHandler
    {
        FormGame fg = new FormGame();

        public int Npc()
        {
            var nAmmo = fg.GetNpcAmmo();
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
    }
}
