using System;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            FormGame fg = new FormGame();
            fg.Show();
            Hide();
        }
        

        public void FormRules_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Do whatever you want here
        }

        public void BtnGameRules_Click(object sender, EventArgs e)
        {
            OpenForm();
          
        }

        private void OpenForm()
        {
            var form2 = new FormRules();
            form2.FormClosing += FormIsClosing;
            form2.Show();

            this.Hide();
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel)
            {
                return;
            }

            Show();
            Update();
        }
    }


    }

