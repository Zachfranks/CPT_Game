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
    public partial class Level1_Game : Form
    {

        // strat local variables
        bool goop;
        bool dodown;
        bool goleft;
        bool goright;

        int spped = 5;

        //ghost 1 and 2 variables
        int ghost1 = 8;
        int ghost2 = 8;

        //ghost 3 
        int ghost3y = 8;
        int ghost3x = 8;

        public Level1_Game()
        {
            InitializeComponent();
            
        }


    }
}
