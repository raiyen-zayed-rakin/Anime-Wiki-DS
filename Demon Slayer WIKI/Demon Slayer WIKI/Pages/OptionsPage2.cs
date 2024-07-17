using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demon_Slayer_WIKI.Pages
{
    
    public partial class OptionsPage2 : Form
    {
        public OptionsPage2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartPage1 startPage1 = new StartPage1();
            startPage1.Visible = true;
        }

        private void btnNextDemonSlayers_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DemonSlayersPage_i_3 DemonSlayer = new DemonSlayersPage_i_3();
            DemonSlayer.Visible = true; 
        }

        private void btnNextBreathingTech_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            BreathingTechniquesPage5 breathingTechniquesPage5 = new BreathingTechniquesPage5();
            breathingTechniquesPage5.Visible = true;
        }

        private void btnNextDemons_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DemonsPage6 demonsPage6 = new DemonsPage6();
            demonsPage6.Visible = true;
        }
    }
}
