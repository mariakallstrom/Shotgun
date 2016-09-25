using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun.PlayerVsNpcPics
{
    public partial class OnePointToNpc: Form
    {
        public OnePointToNpc()
        {
            InitializeComponent();
        }

        private void OnePointToComputer_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
