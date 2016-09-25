using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun.PointForm
{
    public partial class PlayerWin : Form
    {
        public PlayerWin()
        {
            InitializeComponent();
        }

        private void PlayerWin_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
