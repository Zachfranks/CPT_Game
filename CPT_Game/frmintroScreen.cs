using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using WMPLib;

namespace CPT_Game
{
    public partial class frmIntroScreen : Form
    {
        int score = 0;
        public frmIntroScreen()
        {   
            InitializeComponent();
            //this makes the splah screen apreer befoer he form 

            //got this code off https://www.youtube.com/watch?v=J9azEeLwymU
            Thread splahscreen = new Thread(new ThreadStart(splashStrat));
            splahscreen.Start();

            //this timer waits 50 seconds entil it auto stops the program
            Thread.Sleep(5000);
            splahscreen.Abort();
        }

        public void splashStrat()
        {
            //run the slash screen
            Application.Run(new frmSplashform());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form1 = new frmLevel1_Game(score))
            {
                //gose to new game
                Visible = false;
                form1.ShowDialog();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form1 = new frmHowToPlay())
            {
                //gose to how to play
                Visible = false;
                form1.ShowDialog();
                Close();
            }
        }

        private void btnlevel_Click(object sender, EventArgs e)
        {
            using (var form1 = new frmLevles(score))
            {
                //gose to how to play
                Visible = false;
                form1.ShowDialog();
                Close();
            }
            
        }
    }
}
