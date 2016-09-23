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
  partial class BlockVsBlock : Form
    {
        public BlockVsBlock()
        {
            InitializeComponent();
        }
   
       private void BlockVsBlock_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 10000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

       public void timer_Tick(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
