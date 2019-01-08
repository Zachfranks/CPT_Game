namespace CPT_Game
{
    partial class frmLevel2_Game
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
            this.components = new System.ComponentModel.Container();
            this.tmrlevel2 = new System.Windows.Forms.Timer(this.components);
            this.lblscorelevel2 = new System.Windows.Forms.Label();
            this.picPinkGhostlevel2 = new System.Windows.Forms.PictureBox();
            this.picPacManlevel2 = new System.Windows.Forms.PictureBox();
            this.picYellowGhostlevel2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPinkGhostlevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacManlevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowGhostlevel2)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrlevel2
            // 
            this.tmrlevel2.Enabled = true;
            this.tmrlevel2.Interval = 20;
            this.tmrlevel2.Tick += new System.EventHandler(this.tmrlevel2_Tick);
            // 
            // lblscorelevel2
            // 
            this.lblscorelevel2.AutoSize = true;
            this.lblscorelevel2.ForeColor = System.Drawing.Color.White;
            this.lblscorelevel2.Location = new System.Drawing.Point(118, 29);
            this.lblscorelevel2.Name = "lblscorelevel2";
            this.lblscorelevel2.Size = new System.Drawing.Size(33, 13);
            this.lblscorelevel2.TabIndex = 1;
            this.lblscorelevel2.Text = "score";
            // 
            // picPinkGhostlevel2
            // 
            this.picPinkGhostlevel2.Image = global::CPT_Game.Properties.Resources.original;
            this.picPinkGhostlevel2.Location = new System.Drawing.Point(106, 205);
            this.picPinkGhostlevel2.Name = "picPinkGhostlevel2";
            this.picPinkGhostlevel2.Size = new System.Drawing.Size(45, 50);
            this.picPinkGhostlevel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPinkGhostlevel2.TabIndex = 2;
            this.picPinkGhostlevel2.TabStop = false;
            // 
            // picPacManlevel2
            // 
            this.picPacManlevel2.Image = global::CPT_Game.Properties.Resources.Left;
            this.picPacManlevel2.Location = new System.Drawing.Point(12, 91);
            this.picPacManlevel2.Name = "picPacManlevel2";
            this.picPacManlevel2.Size = new System.Drawing.Size(40, 40);
            this.picPacManlevel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPacManlevel2.TabIndex = 0;
            this.picPacManlevel2.TabStop = false;
            // 
            // picYellowGhostlevel2
            // 
            this.picYellowGhostlevel2.Location = new System.Drawing.Point(267, 192);
            this.picYellowGhostlevel2.Name = "picYellowGhostlevel2";
            this.picYellowGhostlevel2.Size = new System.Drawing.Size(100, 50);
            this.picYellowGhostlevel2.TabIndex = 3;
            this.picYellowGhostlevel2.TabStop = false;
            // 
            // frmLevel2_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 657);
            this.Controls.Add(this.picYellowGhostlevel2);
            this.Controls.Add(this.picPinkGhostlevel2);
            this.Controls.Add(this.lblscorelevel2);
            this.Controls.Add(this.picPacManlevel2);
            this.Name = "frmLevel2_Game";
            this.Text = "frmLevel2_Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDownlevel2);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeysIsUplevel2);
            ((System.ComponentModel.ISupportInitialize)(this.picPinkGhostlevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacManlevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowGhostlevel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPacManlevel2;
        private System.Windows.Forms.Timer tmrlevel2;
        private System.Windows.Forms.Label lblscorelevel2;
        private System.Windows.Forms.PictureBox picPinkGhostlevel2;
        private System.Windows.Forms.PictureBox picYellowGhostlevel2;
    }
}