using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class ShotgunVsBlock : Form
    {
        public ShotgunVsBlock()
        {
            InitializeComponent();
        }

        private void ShotgunVsBlock_Load(object sender, EventArgs e)
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
