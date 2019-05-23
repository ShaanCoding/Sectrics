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
    public partial class nodes : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        public nodes()
        {
            InitializeComponent();

            //Adds The Array Coordinates Into ListBox
            nodeListView.Items.Clear();
            for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
            {
                nodeListView.Items.Add("Node X: " + Program.bridgeData.nodes[i].NodeX.ToString() + " | Node Y: " + Program.bridgeData.nodes[i].NodeY.ToString());
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

        private void addNodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool repeatedNode = false;
                for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
                {
                    if (Program.bridgeData.nodes[i].NodeX == Convert.ToDouble(xAxisTextbox.Text) && Program.bridgeData.nodes[i].NodeY == Convert.ToDouble(yAxisTextbox.Text))
                    {
                        repeatedNode = true;
                    }
                }

                if (xAxisTextbox.Text != null && yAxisTextbox.Text != null && repeatedNode == false)
                {
                    Program.bridgeData.nodes.Add(new Nodes());
                    Program.bridgeData.nodes[Program.bridgeData.nodesIndex].NodeX = Convert.ToDouble(xAxisTextbox.Text);
                    Program.bridgeData.nodes[Program.bridgeData.nodesIndex].NodeY = Convert.ToDouble(yAxisTextbox.Text);
                    Program.bridgeData.nodesIndex++;
                    xAxisTextbox.Text = "";
                    yAxisTextbox.Text = "";
                }
                else if (xAxisTextbox.Text == null)
                {
                    xAxisTextbox.Text = "Incorrect Variable Entered";
                }
                else if (yAxisTextbox.Text == null)
                {
                    yAxisTextbox.Text = "Incorrect Variable Entered";
                }
                else
                {
                    xAxisTextbox.Text = "Incorrect Variable Entered";
                    yAxisTextbox.Text = "Incorrect Variable Entered";
                }

                //Adds The Array Coordinates Into ListBox
                nodeListView.Items.Clear();
                for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
                {
                    nodeListView.Items.Add("Node X: " + Program.bridgeData.nodes[i].NodeX.ToString() + " | Node Y: " + Program.bridgeData.nodes[i].NodeY.ToString());
                }
            }
            catch
            {
                xAxisTextbox.Text = "Incorrect Variable Entered";
                yAxisTextbox.Text = "Incorrect Variable Entered";
            }
        }

        private void yAxisTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void xAxisTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nodeListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeNode_Click(object sender, EventArgs e)
        {
            if(nodeListView.SelectedIndex >= 0)
            {
                Program.bridgeData.nodes.RemoveAt(nodeListView.SelectedIndex);
                Program.bridgeData.nodesIndex--;

                //Adds The Array Coordinates Into ListBox
                nodeListView.Items.Clear();
                for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
                {
                    nodeListView.Items.Add("Node X: " + Program.bridgeData.nodes[i].NodeX.ToString() + " | Node Y: " + Program.bridgeData.nodes[i].NodeY.ToString());
                }
            }
            else
            {
                MessageBox.Show("Error: Must Select An Item Before Clicking It.");
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            Program.bridgeData.nodes.Clear();
            Program.bridgeData.nodesIndex = 0;

            //Adds The Array Coordinates Into ListBox
            nodeListView.Items.Clear();
            for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
            {
                nodeListView.Items.Add("Node X: " + Program.bridgeData.nodes[i].NodeX.ToString() + " | Node Y: " + Program.bridgeData.nodes[i].NodeY.ToString());
            }
        }

        private void saveBridge_Click(object sender, EventArgs e)
        {
            Program.generalFunctions.saveFileCSV();
        }

        private void loadBridge_Click(object sender, EventArgs e)
        {
            Program.generalFunctions.LoadFileCSV();
        }

        private void moveMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moveMenu_MouseDown(object sender, MouseEventArgs e)
        {
            Program.generalFunctions.mov = 1;
            Program.generalFunctions.movX = e.X;
            Program.generalFunctions.movY = e.Y;
        }

        private void moveMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if(Program.generalFunctions.mov == 1)
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
