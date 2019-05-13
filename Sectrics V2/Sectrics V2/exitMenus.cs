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
    public partial class exitMenus : Form
    {

        public exitMenus()
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

        private void nodes_Load(object sender, EventArgs e)
        {
            if ((Program.generalFunctions.desktopX - Program.generalFunctions.movX) != 0 && (Program.generalFunctions.desktopY - Program.generalFunctions.movY) != null)
            {
                this.SetDesktopLocation(Program.generalFunctions.desktopX - Program.generalFunctions.movX, Program.generalFunctions.desktopY - Program.generalFunctions.movY);
            }
        }

        private void exitConfirm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitDecline_Click(object sender, EventArgs e)
        {
            nodes node = new nodes();
            this.Hide();
            node.Show();
        }

        private void moveMenu_MouseDown(object sender, MouseEventArgs e)
        {
            Program.generalFunctions.mov = 1;
            Program.generalFunctions.movX = e.X;
            Program.generalFunctions.movY = e.Y;
        }

        private void moveMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (Program.generalFunctions.mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Program.generalFunctions.movX, MousePosition.Y - Program.generalFunctions.movY);
                Program.generalFunctions.desktopX = MousePosition.X;
                Program.generalFunctions.desktopY = MousePosition.Y;
            }
        }

        private void moveMenu_MouseUp(object sender, MouseEventArgs e)
        {
            Program.generalFunctions.mov = 0;
        }
    }
}
