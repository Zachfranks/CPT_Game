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
    public partial class frmLevel2_Game : Form
    {

        //sounds players
        private SoundPlayer soundPlayerCoinLevel2;
        private SoundPlayer soundPlayerGhostLevel2;
        private SoundPlayer soundPlayerWinLevel2;
        private SoundPlayer soundPlayerDeathLevel2;
        private SoundPlayer soundPlayerGameOverLevel2;


        // strat local variables
        bool gouplevel2;
        bool godownlevel2;
        bool goleftlevel2;
        bool gorightlevel2;

        //pacman speed
        int speedlevel2 = 6;

        //ghost 1,2,3 and 4 variables
        int ghost1level2 = 6;
        int ghost2level2 = 6;
        int ghost3level2 = 8;
        int ghost4level2 = 6;

        //ghost 5
        int ghost5ylevel2 = 7;
        int ghost5xlevel2 = 7;

        //score borad
        int scorelevel2 = 0;

        //lifecount
        int life_Count = 0;

        public frmLevel2_Game()
        {
            InitializeComponent();
        }

        private void KeyIsDownlevel2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                //changes the image for left
                goleftlevel2 = true;
                picPacManlevel2.Image = Properties.Resources.pikachunringleft;
            }
            if (e.KeyCode == Keys.Right)
            {
                //changes the image for right
                gorightlevel2 = true;
                picPacManlevel2.Image = Properties.Resources.pikachunright;
            }
            if (e.KeyCode == Keys.Up)
            {
                //changes the image for up
                gouplevel2 = true;
                picPacManlevel2.Image = Properties.Resources.pikachuruingup;
            }
            if (e.KeyCode == Keys.Down)
            {
                //changes the image for down
                godownlevel2 = true;
                picPacManlevel2.Image = Properties.Resources.pikachunriuingdown;
            }
        }

        private void KeysIsUplevel2(object sender, KeyEventArgs e)
        {
            //disable action when you unpress the button
            if (e.KeyCode == Keys.Left)
            {
                goleftlevel2 = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                gorightlevel2 = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                gouplevel2 = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godownlevel2 = false;
            }
        }

        private void tmrlevel2_Tick(object sender, EventArgs e)
        {
            //shows on the scoere bord
            //lblscorelevel2.Text = "Score:" + scorelevel2;

            //player movement
            if (goleftlevel2)
            {
                //player moves to the left
                picPacManlevel2.Left -= speedlevel2;
            }
            if (gorightlevel2)
            {
                //player moves to the right
                picPacManlevel2.Left += speedlevel2;
            }
            if (gouplevel2)
            {
                //player moves up
                picPacManlevel2.Top -= speedlevel2;
            }
            if (godownlevel2)
            {
                //player moves down
                picPacManlevel2.Top += speedlevel2;
            }

            picPinkGhostlevel2.Left += ghost1level2;
            picYellowGhostlevel2.Left += ghost2level2;

            //move pink ghost

            if (picPinkGhostlevel2.Bounds.IntersectsWith(picWall1level2.Bounds))
            {
                ghost1level2 = -ghost1level2;
                picPinkGhostlevel2.Image = Properties.Resources.pinkghostlevel2;
                
            }

            //if the red ghost hits the wall "2" then go backwars 
            else if (picPinkGhostlevel2.Bounds.IntersectsWith(picWall2level2.Bounds))
            {
                ghost1level2 = -ghost1level2;
                picPinkGhostlevel2.Image = Properties.Resources.ghostlevel2pink;
            }

            //move yellow ghsot
            //if the yellow ghost hits the wall "3" then go backwars 
            else if (picYellowGhostlevel2.Bounds.IntersectsWith(picWall3level2.Bounds))
            {
                ghost2level2 = -ghost2level2;
                picYellowGhostlevel2.Image = Properties.Resources.rightlevel2;
            }

            //if the yellow ghost hits the wall "4" then go backwars 
            else if (picYellowGhostlevel2.Bounds.IntersectsWith(picWall4level2.Bounds))
            {
                ghost2level2 = -ghost2level2;
                picYellowGhostlevel2.Image = Properties.Resources.chostlevel2;
            }

        }
    }
}
