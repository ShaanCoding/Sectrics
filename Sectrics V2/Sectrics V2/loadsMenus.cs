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
    public partial class loadsMenus : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        public loadsMenus()
        {
            InitializeComponent();

            if (Program.bridgeData.forces.Count != Program.bridgeData.nodes.Count)
            {
                for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
                {
                    Program.bridgeData.forces.Add(new forces());
                    Program.bridgeData.forces[i].xMagnitudeForces = 0;
                    Program.bridgeData.forces[i].yMagnitudeForces = 0;
                }
            }

            //Adds The Array Coordinates Into ListBox
            nodeListView.Items.Clear();
            for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
            {
                nodeListView.Items.Add("Node " + i + " " + "X Coordinate: " + Program.bridgeData.nodes[i].NodeX.ToString() + " | Y Coordinate: " + Program.bridgeData.nodes[i].NodeY.ToString());
            }

            //Adds The Array Coordinates Into ListBox
            loadsListView.Items.Clear();
            for(int i = 0; i < Program.bridgeData.forces.Count; i++)
            {
                loadsListView.Items.Add("Node " + i + " X Magnitude: " + Program.bridgeData.forces[i].xMagnitudeForces + " | Y Magnitude: " + Program.bridgeData.forces[i].yMagnitudeForces);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
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
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void yForceTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void xForceTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nodeTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addLoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(nodeTextbox.Text) < Program.bridgeData.nodes.Count && nodeTextbox.Text != null && xForceTextbox.Text != null && yForceTextbox.Text != null)
                {
                    Program.bridgeData.forces[Convert.ToInt32(nodeTextbox.Text)].xMagnitudeForces = Convert.ToDouble(xForceTextbox.Text);
                    Program.bridgeData.forces[Convert.ToInt32(nodeTextbox.Text)].yMagnitudeForces = Convert.ToDouble(yForceTextbox.Text);

                    nodeTextbox.Text = "";
                    xForceTextbox.Text = "";
                    yForceTextbox.Text = "";

                    //Adds The Array Coordinates Into ListBox
                    loadsListView.Items.Clear();
                    for (int i = 0; i < Program.bridgeData.forces.Count; i++)
                    {
                        loadsListView.Items.Add("Node " + i + " X Magnitude: " + Program.bridgeData.forces[i].xMagnitudeForces + " | Y Magnitude: " + Program.bridgeData.forces[i].yMagnitudeForces);
                    }
                }
                else
                {
                    if (nodeTextbox.Text == null || Convert.ToInt32(nodeTextbox.Text) < Program.bridgeData.nodes.Count)
                    {
                        nodeTextbox.Text = "Incorrect Variable Entered";
                    }
                    if (xForceTextbox.Text == null)
                    {
                        xForceTextbox.Text = "Incorrect Variable Entered";
                    }
                    if (yForceTextbox.Text == null)
                    {
                        yForceTextbox.Text = "Incorrect Variable Entered";
                    }
                }
            }
            catch
            {
                nodeTextbox.Text = "Incorrect Variable Entered";
                xForceTextbox.Text = "Incorrect Variable Entered";
                yForceTextbox.Text = "Incorrect Variable Entered";
            }
        }

        private void nodeListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeLoad_Click(object sender, EventArgs e)
        {
            if(loadsListView.SelectedIndex >= 0)
            {
                Program.bridgeData.forces[loadsListView.SelectedIndex].xMagnitudeForces = 0;
                Program.bridgeData.forces[loadsListView.SelectedIndex].yMagnitudeForces = 0;

                //Adds The Array Coordinates Into ListBox
                loadsListView.Items.Clear();
                for (int i = 0; i < Program.bridgeData.forces.Count; i++)
                {
                    loadsListView.Items.Add("Node " + i + " X Magnitude: " + Program.bridgeData.forces[i].xMagnitudeForces + " | Y Magnitude: " + Program.bridgeData.forces[i].yMagnitudeForces);
                }
            }
            else
            {
                MessageBox.Show("Error: Must Select An Item Before Clicking It.");
            }
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Program.bridgeData.forces.Count; i++)
            {
                Program.bridgeData.forces[i].xMagnitudeForces = 0;
                Program.bridgeData.forces[i].yMagnitudeForces = 0;
            }

            //Adds The Array Coordinates Into ListBox
            loadsListView.Items.Clear();
            for (int i = 0; i < Program.bridgeData.forces.Count; i++)
            {
                loadsListView.Items.Add("Node " + i + " X Magnitude: " + Program.bridgeData.forces[i].xMagnitudeForces + " | Y Magnitude: " + Program.bridgeData.forces[i].yMagnitudeForces);
            }
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

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            buildBridgeMenu buildBridgeMenu = new buildBridgeMenu();
            this.Hide();
            buildBridgeMenu.Show();
        }
    }
}
