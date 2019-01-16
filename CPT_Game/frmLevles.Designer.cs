namespace CPT_Game
{
    partial class frmLevles
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
            this.lblLevels = new System.Windows.Forms.Label();
            this.btnlevle1 = new System.Windows.Forms.Button();
            this.btnlevel2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLevels
            // 
            this.lblLevels.AutoSize = true;
            this.lblLevels.BackColor = System.Drawing.Color.Black;
            this.lblLevels.Font = new System.Drawing.Font("Stencil Std", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLevels.Location = new System.Drawing.Point(146, 38);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Size = new System.Drawing.Size(153, 46);
            this.lblLevels.TabIndex = 0;
            this.lblLevels.Text = "Levels";
            // 
            // btnlevle1
            // 
            this.btnlevle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlevle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnlevle1.Location = new System.Drawing.Point(22, 142);
            this.btnlevle1.Name = "btnlevle1";
            this.btnlevle1.Size = new System.Drawing.Size(89, 31);
            this.btnlevle1.TabIndex = 1;
            this.btnlevle1.Text = "level1";
            this.btnlevle1.UseVisualStyleBackColor = true;
            this.btnlevle1.Click += new System.EventHandler(this.btnlevle1_Click);
            // 
            // btnlevel2
            // 
            this.btnlevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlevel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnlevel2.Location = new System.Drawing.Point(324, 142);
            this.btnlevel2.Name = "btnlevel2";
            this.btnlevel2.Size = new System.Drawing.Size(89, 31);
            this.btnlevel2.TabIndex = 2;
            this.btnlevel2.Text = "level2";
            this.btnlevel2.UseVisualStyleBackColor = true;
            this.btnlevel2.Click += new System.EventHandler(this.btnlevel2_Click);
            // 
            // frmLevles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(442, 267);
            this.Controls.Add(this.btnlevel2);
            this.Controls.Add(this.btnlevle1);
            this.Controls.Add(this.lblLevels);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmLevles";
            this.Text = "frmLevles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLevels;
        private System.Windows.Forms.Button btnlevle1;
        private System.Windows.Forms.Button btnlevel2;
    }
}