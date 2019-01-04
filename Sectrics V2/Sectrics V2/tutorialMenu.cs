using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sectrics_V2
{
    public partial class tutorialMenu : Form
    {

        public tutorialMenu()
        {
            InitializeComponent();
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void nodesMenu_Click(object sender, EventArgs e)
        {
            nodes node = new nodes();
            this.Hide();
            node.Show();
        }

        private void nodes_Load(object sender, EventArgs e)
        {

        }


    }
}
