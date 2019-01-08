namespace CPT_Game
{
    partial class frmGameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameOver));
            this.btnlevels = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlevels
            // 
            this.btnlevels.BackColor = System.Drawing.Color.White;
            this.btnlevels.Font = new System.Drawing.Font("Stencil Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlevels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnlevels.Location = new System.Drawing.Point(362, 341);
            this.btnlevels.Name = "btnlevels";
            this.btnlevels.Size = new System.Drawing.Size(144, 64);
            this.btnlevels.TabIndex = 0;
            this.btnlevels.Text = "Go to Levels";
            this.btnlevels.UseVisualStyleBackColor = false;
            this.btnlevels.Click += new System.EventHandler(this.btnlevels_Click);
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(836, 441);
            this.Controls.Add(this.btnlevels);
            this.Name = "frmGameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlevels;
    }
}