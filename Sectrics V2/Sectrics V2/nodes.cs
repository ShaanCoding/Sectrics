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

        private void membersMenu_Click(object sender, EventArgs e)
        {
            members member = new members();
            this.Hide();
            member.Show();
        }

        private void materialPropertiesMenu_Click(object sender, EventArgs e)
        {
            materialProperties materialProperty = new materialProperties();
            this.Hide();
            materialProperty.Show();
        }

        private void supportsMenu_Click(object sender, EventArgs e)
        {
            supportMenus supportMenu = new supportMenus();
            this.Hide();
            supportMenu.Show();
        }

        private void loadsMenu_Click(object sender, EventArgs e)
        {
            loadsMenus loadMenu = new loadsMenus();
            this.Hide();
            loadMenu.Show();
        }

        private void solveMenu_Click(object sender, EventArgs e)
        {
            solveMenus solveMenu = new solveMenus();
            this.Hide();
            solveMenu.Show();
        }

        private void nodes_Load(object sender, EventArgs e)
        {

        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            aboutMenus aboutMenu = new aboutMenus();
            this.Hide();
            aboutMenu.Show();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            exitMenus exitMenu = new exitMenus();
            this.Hide();
            exitMenu.Show();
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

                if (xAxisTextbox.Text != null && yAxisTextbox.Text != null && repeatedNode = false)
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
    }
}
