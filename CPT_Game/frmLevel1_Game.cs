using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPT_Game
{
    public partial class frmLevel1_Game : Form
    {

        // strat local variables
        bool gouplevel1;
        bool godownlevel1;
        bool goleftlevel1;
        bool gorightlevel1;

        int speedlevel1 = 5;

        //ghost 1 and 2 variables
        int ghost1level1 = 8;
        int ghost2level1 = 8;

        //ghost 3 
        int ghost3ylevel1 = 8;
        int ghost3xlevel1 = 8;

        int scorelevel1 = 0;

        public frmLevel1_Game()
        {
            InitializeComponent();
            //makes the game over lable not visible
            lblGameOverlevel1.Visible = false;
        }            

        private void KeyIsDownlevel1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                //changes the image for left
                goleftlevel1 = true;
                picPacManlevel1.Image = Properties.Resources.Right;
            }
            if (e.KeyCode == Keys.Right)
            {
                //changes the image for right
                gorightlevel1 = true;
                picPacManlevel1.Image = Properties.Resources.Left;
            }
            if (e.KeyCode == Keys.Up)
            {
                //changes the image for up
                gouplevel1 = true;
                picPacManlevel1.Image = Properties.Resources.Up;
            }
            if (e.KeyCode == Keys.Down)
            {
                //changes the image for down
                godownlevel1 = true;
                picPacManlevel1.Image = Properties.Resources.down;
            }
        }

        private void KeysIsUplevel1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleftlevel1 = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                gorightlevel1 = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                gouplevel1 = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godownlevel1 = false;
            }
        }

        private void tmrlevel1_Tick(object sender, EventArgs e)
        {
            //shows on the scoere bord
            lblscorelevel1.Text = "Score:" + scorelevel1;

            //player movement
            if (goleftlevel1)
            {
                //player moves to the left
                picPacManlevel1.Left -= speedlevel1;              
            }
            if (gorightlevel1)
            {
                //player moves to the right
                picPacManlevel1.Left += speedlevel1;               
            }
            if (gouplevel1)
            {
                //player moves up
                picPacManlevel1.Top -= speedlevel1;               
            }
            if (godownlevel1)
            {
                //player moves down
                picPacManlevel1.Top += speedlevel1;               
            }

            //moving the ghost and bumping with the walls
            picRedGhostlevel1.Left += ghost1level1;
            picYellowGhostlevel1.Left += ghost2level1;

            //move red ghost
            //if the red ghost hits the wall "1" then go backwars 
            if (picRedGhostlevel1.Bounds.IntersectsWith(picWall1level1.Bounds))
            {
                ghost1level1 = -ghost1level1;
            }

            //if the red ghost hits the wall "2" then go backwars 
            else if (picRedGhostlevel1.Bounds.IntersectsWith(picWall2level1.Bounds))
            {
                ghost1level1 = -ghost1level1;
            }

            //move yellow ghsot
            //if the yellow ghost hits the wall "3" then go backwars 
            if (picYellowGhostlevel1.Bounds.IntersectsWith(picWall3level1.Bounds))
            {
                ghost2level1 = -ghost2level1;
            }

            //if the yellow ghost hits the wall "4" then go backwars 
            if (picYellowGhostlevel1.Bounds.IntersectsWith(picWall4level1.Bounds))
            {
                ghost2level1 = -ghost2level1;
            }

            //for loop to check walls, ghost and points
            foreach (Control hitBox in this.Controls)
            {
                //if the player hits a "wall" or "ghost"
                if (hitBox is PictureBox && hitBox.Tag == "wallLevel1" || hitBox.Tag == "ghostLevel1")
                {
                    // check if the player hits the wall or ghost, then is the game over
                    if(((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel1.Bounds)|| scorelevel1 == 30)
                    {
                        //the game over stuff

                        //rest the possion
                        picPacManlevel1.Left = 0;
                        picPacManlevel1.Top = 20;

                        //display game over
                        lblGameOverlevel1.Visible = true;
                    }
                }

                //if player hits a "coin"
                if (hitBox is PictureBox && hitBox.Tag == "coinLevel1")
                {
                    if (((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel1.Bounds))
                    {
                        Controls.Remove(hitBox);
                        scorelevel1++;
                    }
                }
            }
        }
    }
}
