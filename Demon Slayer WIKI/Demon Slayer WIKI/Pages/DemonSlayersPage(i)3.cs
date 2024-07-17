using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demon_Slayer_WIKI.Pages
{
    public partial class DemonSlayersPage_i_3 : Form
    {
        public DemonSlayersPage_i_3()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OptionsPage2 optionsPage2 = new OptionsPage2();
            optionsPage2.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            DemonSlayersPage_ii_4 DemonSlayer = new DemonSlayersPage_ii_4();
            DemonSlayer.Visible = true;
        }
    }
}
