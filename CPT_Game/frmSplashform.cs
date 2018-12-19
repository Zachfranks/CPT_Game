using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CPT_Game
{
    public partial class frmSplashform : Form
    {
        //sound play
        private SoundPlayer soundPlayer;

        public frmSplashform()
        {
            InitializeComponent();

            //palys intro sound
            soundPlayer = new SoundPlayer("PacMan.wav");
            soundPlayer.Play();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //loding bar incenent
            prgStrat.Increment(1);

            //when the progress bar is full stop 
            if (prgStrat.Value == 100)
                timStrat.Stop();
        }
    }
}
