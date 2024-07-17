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
    public partial class StartPage1 : Form
    {
        public StartPage1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OptionsPage2 optionsPage2 = new OptionsPage2();
            optionsPage2.Visible = true;
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: Raiyen Zayed Rakin\n University: AIUB\n Course: OOP2");
        }
    }
}
