namespace CPT_Game
{
    partial class Level1_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pinkGhost = new System.Windows.Forms.PictureBox();
            this.yellowGhost = new System.Windows.Forms.PictureBox();
            this.redGhost = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall = new System.Windows.Forms.PictureBox();
            this.PacMan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacMan)).BeginInit();
            this.SuspendLayout();
            // 
            // pinkGhost
            // 
            this.pinkGhost.BackColor = System.Drawing.SystemColors.Desktop;
            this.pinkGhost.Image = global::CPT_Game.Properties.Resources.pink_guy;
            this.pinkGhost.Location = new System.Drawing.Point(439, 424);
            this.pinkGhost.Name = "pinkGhost";
            this.pinkGhost.Size = new System.Drawing.Size(36, 38);
            this.pinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkGhost.TabIndex = 7;
            this.pinkGhost.TabStop = false;
            this.pinkGhost.Tag = "ghost";
            // 
            // yellowGhost
            // 
            this.yellowGhost.BackColor = System.Drawing.SystemColors.Desktop;
            this.yellowGhost.Image = global::CPT_Game.Properties.Resources.yellow_guy;
            this.yellowGhost.Location = new System.Drawing.Point(164, 424);
            this.yellowGhost.Name = "yellowGhost";
            this.yellowGhost.Size = new System.Drawing.Size(36, 38);
            this.yellowGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowGhost.TabIndex = 6;
            this.yellowGhost.TabStop = false;
            this.yellowGhost.Tag = "ghost";
            // 
            // redGhost
            // 
            this.redGhost.BackColor = System.Drawing.SystemColors.Desktop;
            this.redGhost.Image = global::CPT_Game.Properties.Resources.red_guy;
            this.redGhost.Location = new System.Drawing.Point(402, 106);
            this.redGhost.Name = "redGhost";
            this.redGhost.Size = new System.Drawing.Size(36, 38);
            this.redGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redGhost.TabIndex = 5;
            this.redGhost.TabStop = false;
            this.redGhost.Tag = "ghost";
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.MidnightBlue;
            this.picWall4.Location = new System.Drawing.Point(300, 379);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(35, 150);
            this.picWall4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWall4.TabIndex = 4;
            this.picWall4.TabStop = false;
            this.picWall4.Tag = "Wall";
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.MidnightBlue;
            this.picWall3.Location = new System.Drawing.Point(12, 379);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(35, 150);
            this.picWall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            this.picWall3.Tag = "Wall";
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.MidnightBlue;
            this.picWall2.Location = new System.Drawing.Point(562, 60);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(35, 150);
            this.picWall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWall2.TabIndex = 2;
            this.picWall2.TabStop = false;
            this.picWall2.Tag = "Wall";
            // 
            // picWall
            // 
            this.picWall.BackColor = System.Drawing.Color.MidnightBlue;
            this.picWall.Location = new System.Drawing.Point(270, 60);
            this.picWall.Name = "picWall";
            this.picWall.Size = new System.Drawing.Size(35, 150);
            this.picWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWall.TabIndex = 1;
            this.picWall.TabStop = false;
            this.picWall.Tag = "Wall";
            // 
            // PacMan
            // 
            this.PacMan.Image = global::CPT_Game.Properties.Resources.Left;
            this.PacMan.Location = new System.Drawing.Point(40, 40);
            this.PacMan.Name = "PacMan";
            this.PacMan.Size = new System.Drawing.Size(40, 40);
            this.PacMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PacMan.TabIndex = 0;
            this.PacMan.TabStop = false;
            // 
            // Level1_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(609, 531);
            this.Controls.Add(this.pinkGhost);
            this.Controls.Add(this.yellowGhost);
            this.Controls.Add(this.redGhost);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall);
            this.Controls.Add(this.PacMan);
            this.Name = "Level1_Game";
            this.Text = "PACMAN Level 1";
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PacMan;
        private System.Windows.Forms.PictureBox picWall;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox redGhost;
        private System.Windows.Forms.PictureBox yellowGhost;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox pinkGhost;
    }
}