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
    public partial class DemonSlayersPage_ii_4 : Form
    {
        public DemonSlayersPage_ii_4()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DemonSlayersPage_i_3 DemonSlayer = new DemonSlayersPage_i_3();
            DemonSlayer.Visible = true;
        }
    }
}
