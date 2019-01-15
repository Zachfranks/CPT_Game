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
    public partial class frmLevles : Form
    {
        int score;
        public frmLevles(int scoreFromPrevLvl)
        {
            InitializeComponent();
        }

        private void btnlevle1_Click(object sender, EventArgs e)
        {
            using (var form1 = new frmLevel1_Game(score))
            {
                //gose to new game
                Visible = false;
                form1.ShowDialog();
                Close();
            }
        }

        private void btnlevel2_Click(object sender, EventArgs e)
        {
            using (var form1 = new frmLevel2_Game(score))
            {
                //gose to new game
                Visible = false;
                form1.ShowDialog();
                Close();
            }
        }
    }
}
