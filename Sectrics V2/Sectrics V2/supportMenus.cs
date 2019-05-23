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
    public partial class supportMenus : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        public supportMenus()
        {
            InitializeComponent();

            //Adds The Array Coordinates Into ListBox
            nodeListView.Items.Clear();
            for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
            {
                nodeListView.Items.Add("Node " + i + " " + "X Coordinate: " + Program.bridgeData.nodes[i].NodeX.ToString() + " | Y Coordinate: " + Program.bridgeData.nodes[i].NodeY.ToString());
            }

            //Adds The Array Coordinates Into ListBox
            supportListView.Items.Clear();
            for (int i = 0; i < Program.bridgeData.supportNode.Count; i++)
            {
                supportListView.Items.Add("Support Type: " + Program.bridgeData.supportType[i] + " | At Node: " + Program.bridgeData.supportNode[i].ToString());
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

        private void addSupportButton_Click(object sender, EventArgs e)
        {
            try
            {
                Program.bridgeData.ndof = Program.bridgeData.nodes.Count * 2;
                if (Program.bridgeData.degreesOfFreedom.Count != Program.bridgeData.ndof)
                {
                    int j = 0, k = 0;

                    for (int i = 1; i <= (Program.bridgeData.ndof); i++)
                    {
                        Program.bridgeData.degreesOfFreedom.Add(new degreesOfFreedom());
                        if (i % 2 == 1)
                        {
                            Program.bridgeData.degreesOfFreedom[j].xDegreeOfFreedom = i;
                            k++;
                        }
                        else if (i % 2 == 0)
                        {
                            Program.bridgeData.degreesOfFreedom[j].yDegreesOfFreedom = i;
                            k++;
                        }
                        if (k == 2)
                        {
                            k = 0;
                            j++;
                        }
                    }
                }

                if (Program.bridgeData.supportType.Count != Program.bridgeData.nodes.Count)
                {
                    for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
                    {
                        Program.bridgeData.supportType.Add("Null");
                    }
                }

                int XDOF = ((Convert.ToInt32(supportNodeTextbox.Text) + 1) * 2 - 1);
                int YDOF = ((Convert.ToInt32(supportNodeTextbox.Text) + 1) * 2);

                if (Convert.ToInt16(supportNodeTextbox.Text) < Program.bridgeData.nodes.Count)
                {
                    switch (supportType.Text)
                    {
                        case "Vertical Fixed Support":
                            Program.bridgeData.restrainedDegreesOfFreedom.Add(XDOF);
                            Program.bridgeData.restrainedDegreesOfFreedom.Add(YDOF);
                            Program.bridgeData.supportType[Convert.ToInt32(supportNodeTextbox.Text)] = "Vertical Fixed Support";
                            Program.bridgeData.supportNode.Add(Convert.ToInt16(supportNodeTextbox.Text));
                            supportNodeTextbox.Text = "";
                            break;
                        case "Horozontal Fixed Support":
                            Program.bridgeData.restrainedDegreesOfFreedom.Add(XDOF);
                            Program.bridgeData.restrainedDegreesOfFreedom.Add(YDOF);
                            Program.bridgeData.supportType[Convert.ToInt32(supportNodeTextbox.Text)] = "Horozontal Fixed Support";
                            Program.bridgeData.supportNode.Add(Convert.ToInt16(supportNodeTextbox.Text));
                            supportNodeTextbox.Text = "";
                            break;
                        case "Vertical Roller":
                            Program.bridgeData.restrainedDegreesOfFreedom.Add(XDOF);
                            Program.bridgeData.supportType[Convert.ToInt32(supportNodeTextbox.Text)] = "Vertical Roller";
                            Program.bridgeData.supportNode.Add(Convert.ToInt16(supportNodeTextbox.Text));
                            supportNodeTextbox.Text = "";
                            break;
                        case "Horozontal Roller":
                            Program.bridgeData.restrainedDegreesOfFreedom.Add(YDOF);
                            Program.bridgeData.supportType[Convert.ToInt32(supportNodeTextbox.Text)] = "Horozontal Roller";
                            Program.bridgeData.supportNode.Add(Convert.ToInt16(supportNodeTextbox.Text));
                            supportNodeTextbox.Text = "";
                            break;
                        default:
                            supportNodeTextbox.Text = "Incorrect Variable Entered";
                            break;
                    }

                    //Adds The Array Coordinates Into ListBox
                    supportListView.Items.Clear();
                    for (int i = 0; i < Program.bridgeData.supportNode.Count; i++)
                    {
                        supportListView.Items.Add("Support Type: " + Program.bridgeData.supportType[i] + " | At Node: " + Program.bridgeData.supportNode[i].ToString());
                    }
                }
                else
                {
                    supportNodeTextbox.Text = "Incorrect Variable Entered";
                }

            }
            catch
            {
                supportNodeTextbox.Text = "Incorrect Variable Entered";
            }

        }

        private void supportType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void supportNodeTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nodeListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void supportListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            Program.bridgeData.supportNode.Clear();
            Program.bridgeData.supportType.Clear();
            Program.bridgeData.restrainedDegreesOfFreedom.Clear();

            //Adds The Array Coordinates Into ListBox
            supportListView.Items.Clear();
            for (int i = 0; i < Program.bridgeData.supportNode.Count; i++)
            {
                supportListView.Items.Add("Support Type: " + Program.bridgeData.supportType[i] + " | At Node: " + Program.bridgeData.supportNode[i].ToString());
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
