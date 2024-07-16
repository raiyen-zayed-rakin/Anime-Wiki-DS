using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breathing_Techniques_DS
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            ChoosePage c = new ChoosePage();
            c.Visible = true;
            this.Visible = false;
        }
        private void btnCredit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Name: Raiyen Zayed Rakin\n University: AIUB\n ID:23-50071-1\n Year: 2024");
        }

        
    }
}
