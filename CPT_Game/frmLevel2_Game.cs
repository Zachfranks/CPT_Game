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

        //ghost 5
        int ghost5ylevel2 = 9;
        int ghost5xlevel2 = 9;

        //score borad
        int scorelevel2 = 0;

        //lifecount
        int life_CountLevel2 = 0;

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
            lblscorelevel2.Text = "Score:" + scorelevel2;

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
            picUPGhostlevel2.Top += ghost3level2;

            //move pink ghost

            if (picPinkGhostlevel2.Bounds.IntersectsWith(picWall1level2.Bounds))
            {
                ghost1level2 = -ghost1level2;
                picPinkGhostlevel2.Image = Properties.Resources.pinkghostlevel2;
                
            }

            //if the red ghost hits the wall "2" then go back
            else if (picPinkGhostlevel2.Bounds.IntersectsWith(picWall2level2.Bounds))
            {
                ghost1level2 = -ghost1level2;
                picPinkGhostlevel2.Image = Properties.Resources.ghostlevel2pink;
            }

            //move yellow ghsot
            //if the yellow ghost hits the wall "3" then go back
            if (picYellowGhostlevel2.Bounds.IntersectsWith(picWall3level2.Bounds))
            {
                ghost2level2 = -ghost2level2;
                picYellowGhostlevel2.Image = Properties.Resources.rightlevel2;
            }

            //if the yellow ghost hits the wall "4" then go back
            else if (picYellowGhostlevel2.Bounds.IntersectsWith(picWall4level2.Bounds))
            {
                ghost2level2 = -ghost2level2;
                picYellowGhostlevel2.Image = Properties.Resources.chostlevel2;
            }
            
            //move the Up/down Ghost
            //if the ghost hits wall "5" go back
            if (picUPGhostlevel2.Bounds.IntersectsWith(picWall5level2.Bounds))
            {
                ghost3level2 = -ghost3level2;
            }
            //if he ghost hits the wall "6" go back
            else if (picUPGhostlevel2.Bounds.IntersectsWith(picWall6level2.Bounds))
            {
                ghost3level2 = -ghost3level2;
            }

            //for loop to check walls, ghost and points
            foreach (Control hitBox in Controls)
            {
                //if the player hits a "wall" or "ghost"
                if (hitBox is PictureBox && hitBox.Tag == "wallLevel2" || hitBox.Tag == "ghostLevel2")
                {
                    // check if the player hits the wall or ghost, then is the game over
                    if (((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel2.Bounds) || scorelevel2 == 30)
                    {
                        // the game over reset

                        life_CountLevel2++;
                        //rest the possion
                        picPacManlevel2.Left = 0;
                        picPacManlevel2.Top = 20;

                        if (life_CountLevel2 == 1)
                        {
                            soundPlayerDeathLevel2 = new SoundPlayer("pacman_death.wav");
                            soundPlayerDeathLevel2.Play();
                        }
                        else if (life_CountLevel2 == 2)
                        {
                            soundPlayerDeathLevel2 = new SoundPlayer("pacman_death.wav");
                            soundPlayerDeathLevel2.Play();                           
                        }
                        else if (life_CountLevel2 == 3)
                        {
                            soundPlayerGameOverLevel2 = new SoundPlayer("Retro-game-over-sound-effect.wav");
                            soundPlayerGameOverLevel2.Play();
                            //display game over

                            //pacman cant move
                            picPacManlevel2.Top = speedlevel2 = 0;
                            picPacManlevel2.Left = speedlevel2 = 0;

                            //stop the game
                            tmrlevel2.Stop();

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
                if (hitBox is PictureBox && hitBox.Tag == "coinLevel2")
                {
                    if (((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel2.Bounds))
                    {
                        //plays the coin sound
                        soundPlayerCoinLevel2 = new SoundPlayer("pacManCoin.wav");
                        soundPlayerCoinLevel2.Play();

                        //roemove the coin that was hit
                        Controls.Remove(hitBox);

                        //adds score
                        scorelevel2++;

                        if (scorelevel2 == 30)
                        {
                            //stops the game
                            tmrlevel2.Stop();

                            soundPlayerWinLevel2 = new SoundPlayer("Win.wav");
                            soundPlayerWinLevel2.Play();

                            MessageBox.Show("You Beat Level One!!");

                            using (var form1 = new frmLevles())
                            {
                                //gose to new game
                                Visible = false;
                                form1.ShowDialog();
                                Close();
                            }
                        }
                    }
                }

                //displayboard
                if (hitBox is PictureBox && hitBox.Tag == "noManLandTopLevel2")
                    if (((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel2.Bounds))
                    {
                        //if pacMan hit no man land go stay in bounds
                        picPacManlevel2.Top += speedlevel2;
                    }

                //thes are the bounds
                if (hitBox is PictureBox && hitBox.Tag == "noManLandLeftLevel2")
                    if (((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel2.Bounds))
                    {
                        //if pacMan hit no man land go stay in bounds
                        picPacManlevel2.Left += speedlevel2;
                    }

                if (hitBox is PictureBox && hitBox.Tag == "noManLandRightLevel2")
                    if (((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel2.Bounds))
                    {
                        //if pacMan hit no man land go stay in bounds
                        picPacManlevel2.Left -= speedlevel2;
                    }
                if (hitBox is PictureBox && hitBox.Tag == "noManLandDownLevel2")
                    if (((PictureBox)hitBox).Bounds.IntersectsWith(picPacManlevel2.Bounds))
                    {
                        //if pacMan hit no man land go stay in bounds
                        picPacManlevel2.Top -= speedlevel2;
                    }
            }
            //making the pink ghost move
            picMovingGhostLevel2.Left += ghost5xlevel2;
            picMovingGhostLevel2.Top += ghost5ylevel2;

            //if the ghost hits a wall or the side edege of the form go crazy move other way
            if (picMovingGhostLevel2.Left < 1 ||
                picMovingGhostLevel2.Left + picMovingGhostLevel2.Width > ClientSize.Width - 2 ||
                (picMovingGhostLevel2.Bounds.IntersectsWith(picWall1level2.Bounds)) ||
                (picMovingGhostLevel2.Bounds.IntersectsWith(picWall2level2.Bounds)) ||
                (picMovingGhostLevel2.Bounds.IntersectsWith(picWall3level2.Bounds)) ||
                (picMovingGhostLevel2.Bounds.IntersectsWith(picWall4level2.Bounds))                
                )
            {
                ghost5xlevel2 = -ghost5xlevel2;
            }
            if (picMovingGhostLevel2.Left < 1 ||
                (picMovingGhostLevel2.Bounds.IntersectsWith(picWall5level2.Bounds)) ||
                (picMovingGhostLevel2.Bounds.IntersectsWith(picWall6level2.Bounds))
                )
            {
                ghost5ylevel2 = -ghost5ylevel2;
            }

            //if the ghost hits the top edege of the form go crazy move other way
            if (picMovingGhostLevel2.Top < 1 || picMovingGhostLevel2.Top + picMovingGhostLevel2.Height > ClientSize.Height - 2 || (picMovingGhostLevel2.Bounds.IntersectsWith(picDisplayBarLevel2.Bounds)))
            {
                ghost5ylevel2 = -ghost5ylevel2;
            }
        }
    }
}
