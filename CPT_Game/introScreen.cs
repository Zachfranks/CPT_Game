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

namespace CPT_Game
{
    public partial class introScreen : Form
    {
        public introScreen()
        {   
            InitializeComponent();

            //this makes the splah screen apreer befoer he form 
            Thread splahscreen = new Thread(new ThreadStart(splashStrat));
            splahscreen.Start();

            //this timer waits 50 seconds entil it auto stops the program
            Thread.Sleep(5000);
            splahscreen.Abort();
        }

        public void splashStrat()
        {
            //run the slash screen
            Application.Run(new splashform());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form1 = new Level1_Game())
            {
                //gose to new game
                Visible = false;
                form1.ShowDialog();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form1 = new HowToPlay())
            {
                //gose to how to play
                Visible = false;
                form1.ShowDialog();
                Close();
            }
        }
    }
}
