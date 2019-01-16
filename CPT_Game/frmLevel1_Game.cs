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
using System.Threading;
using WMPLib;

namespace CPT_Game
{
    public partial class frmLevel1_Game : Form
    {

        //sounds players
        private SoundPlayer soundPlayerCoinLevel1;
        private SoundPlayer soundPlayerWinLevel1;
        private SoundPlayer soundPlayerDeathLevel1;
        private SoundPlayer soundPlayerGameOverLevel1;

        // strat local variables
        bool gouplevel1;
        bool godownlevel1;
        bool goleftlevel1;
        bool gorightlevel1;

        //pacman speed
        int speedlevel1 = 6;

        //ghost 1 and 2 variables
        int ghost1level1 = 10;
        int ghost2level1 = 6;

        //ghost 3 
        int ghost3ylevel1 = 9;
        int ghost3xlevel1 = 9;

        //score borad
        int scorelevel1 = 0;

        //lifecount
        int life_Count = 0;

        //global score
        public static int totalscorelevel1 = 0;


        public frmLevel1_Game(int score)
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
            //disable action when you unpress the button
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
            else if (picYellowGhostlevel1.Bounds.IntersectsWith(picWall3level1.Bounds))
            {
                ghost2level1 = -ghost2level1;
            }

            //if the yellow ghost hits the wall "4" then go backwars 
            else if (picYellowGhostlevel1.Bounds.IntersectsWith(picWall4level1.Bounds))
            {
                ghost2level1 = -ghost2level1;
            }

            //for loop to check walls, ghost and points
            foreach (Control hitBox in Controls)
            {
                
                //if the player hits a "wall" or "ghost"
                if (hitBox is PictureBox && hitBox.Tag == "wallLevel1" || hitBox.Tag == "ghostLevel1")
                {
                    // check if the player hits the wall or ghost, then is the game over
                    if(((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel1.Bounds)|| scorelevel1 == 30)
                    {                       
                        //the game over reset

                        life_Count++;
                        //rest the possion
                        picPacManlevel1.Left = 0;
                        picPacManlevel1.Top = 20;
                       

                        //if the player gets hit by a ghost or wall lose a life
                        if (life_Count == 1)
                        {
                            soundPlayerDeathLevel1 = new SoundPlayer("pacman_death.wav");
                            soundPlayerDeathLevel1.Play();
                            picLife3Level1.Hide();
                        }
                        else if (life_Count == 2)
                        {
                            //plasys suond when you die
                            soundPlayerDeathLevel1 = new SoundPlayer("pacman_death.wav");
                            soundPlayerDeathLevel1.Play();
                            picLife2Level1.Hide();
                        }
                        else if (life_Count == 3)
                        {
                            //plays sond when you die
                            soundPlayerGameOverLevel1 = new SoundPlayer("Retro-game-over-sound-effect.wav");
                            soundPlayerGameOverLevel1.Play();

                            //display game over
                            picLife1Level1.Hide();
                            lblGameOverlevel1.Visible = true;

                            //pacman cant move
                            picPacManlevel1.Top = speedlevel1 = 0;
                            picPacManlevel1.Left = speedlevel1 = 0;
                            
                            //stop the game
                            tmrlevel1.Stop();

                            using (var form1 = new frmGameOver())
                            {
                                //gose to new game
                                Visible = false;
                                form1.ShowDialog();
                                Close();
                            }
                        }                      
                    }
                }

                //if player hits a "coin"
                if (hitBox is PictureBox && hitBox.Tag == "coinLevel1")
                {
                    if (((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel1.Bounds))
                    {
                        //plays the coin sound
                        soundPlayerCoinLevel1 = new SoundPlayer("pacManCoin.wav");
                        soundPlayerCoinLevel1.Play();

                        //roemove the coin that was hit
                        Controls.Remove(hitBox);

                        //adds score
                        scorelevel1++; 
                        
                        if(scorelevel1 == 30)
                        {
                            //stops the game
                            tmrlevel1.Stop();

                            soundPlayerWinLevel1 = new SoundPlayer("Win.wav");
                            soundPlayerWinLevel1.Play();

                            MessageBox.Show ("You Beat Level One!!");

                            using (var form1 = new frmLevles(scorelevel1))
                            {
                                //gose to new game
                                Visible = false;
                                form1.ShowDialog();
                                Close();
                            }
                        }
                        totalscorelevel1 = scorelevel1;
                    }
                }

                //displayBoard
                if (hitBox is PictureBox && hitBox.Tag == "noManLandTopLevel1")
                    if (((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel1.Bounds))
                    {
                        //if pacMan hit no man land go stay in bounds
                        picPacManlevel1.Top += speedlevel1;
                    }

                //thes are the bounds
                if (hitBox is PictureBox && hitBox.Tag == "noManLandLeftLevel1")
                    if(((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel1.Bounds))
                    {
                        //if pacMan hit no man land go stay in bounds
                        picPacManlevel1.Left  += speedlevel1;
                    }

                if (hitBox is PictureBox && hitBox.Tag == "noManLandRightLevel1")
                    if (((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel1.Bounds))
                    {
                        //if pacMan hit no man land go stay in bounds
                        picPacManlevel1.Left -= speedlevel1;
                    }
                if (hitBox is PictureBox && hitBox.Tag == "noManLandDownLevel1")
                    if (((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel1.Bounds))
                    {
                        //if pacMan hit no man land go stay in bounds
                        picPacManlevel1.Top -= speedlevel1;
                    }
            }

            //making the pink ghost move
            picPinkGhostlevel1.Left += ghost3xlevel1;
            picPinkGhostlevel1.Top += ghost3ylevel1;

            //if the ghost hits a wall or the side edege of the form go crazy move other way
            if (picPinkGhostlevel1.Left < 1 || 
                picPinkGhostlevel1.Left + picPinkGhostlevel1.Width > ClientSize.Width - 2 ||
                (picPinkGhostlevel1.Bounds.IntersectsWith(picWall1level1.Bounds))||
                (picPinkGhostlevel1.Bounds.IntersectsWith(picWall2level1.Bounds))||
                (picPinkGhostlevel1.Bounds.IntersectsWith(picWall3level1.Bounds))||
                (picPinkGhostlevel1.Bounds.IntersectsWith(picWall4level1.Bounds))
                )
            {
                ghost3xlevel1 = -ghost3xlevel1;
            }

            //if the ghost hits the top edege of the form go crazy move other way
            if (picPinkGhostlevel1.Top < 1 || picPinkGhostlevel1.Top + picPinkGhostlevel1.Height > ClientSize.Height - 2 || (picPinkGhostlevel1.Bounds.IntersectsWith(picDisplayBarLevel1.Bounds)))
            {
                ghost3ylevel1 = -ghost3ylevel1;
            }
        }

        private void frmLevel1_Game_Load(object sender, EventArgs e)
        {

        }
    }
}
