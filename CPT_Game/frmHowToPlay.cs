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
    public partial class frmHowToPlay : Form
    {
        public frmHowToPlay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form1 = new frmIntroScreen())
            {
                //gose to intro
                Visible = false;
                form1.ShowDialog();
                Close();
            }
        }

        private void HowToPlay_Load(object sender, EventArgs e)
        {
            
        }
    }
}
