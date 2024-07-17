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
    public partial class BreathingTechniquesPage5 : Form
    {
        public BreathingTechniquesPage5()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OptionsPage2 optionsPage2 = new OptionsPage2();
            optionsPage2.Visible = true;
        }
    }
}
