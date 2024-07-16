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
    public partial class ChoosePage : Form
    {
        public ChoosePage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StartPage s = new StartPage();
            s.Visible = true;
            this.Visible = false;
        }
    }
}
