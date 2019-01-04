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

        public loadsMenus()
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
            loadsMenus node = new loadsMenus();
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
                if (Program.bridgeData.forces.Count != Program.bridgeData.nodes.Count)
                {
                    for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
                    {
                        Program.bridgeData.forces.Add(new forces());
                        Program.bridgeData.forces[i].xMagnitudeForces = 0;
                        Program.bridgeData.forces[i].yMagnitudeForces = 0;
                        nodeTextbox.Text = "";
                        xForceTextbox.Text = "";
                        yForceTextbox.Text = "";
                    }
                }


                if (Convert.ToInt16(nodeTextbox.Text) < Program.bridgeData.nodes.Count && nodeTextbox.Text != null && xForceTextbox.Text != null && yForceTextbox.Text != null)
                {
                    Program.bridgeData.forces[Convert.ToInt32(nodeTextbox.Text)].xMagnitudeForces = Convert.ToDouble(xForceTextbox.Text);
                    Program.bridgeData.forces[Convert.ToInt32(nodeTextbox.Text)].yMagnitudeForces = Convert.ToDouble(yForceTextbox.Text);
                }
                else
                {
                    if (nodeTextbox.Text == null || Convert.ToInt32(nodeTextbox.Text) < Program.bridgeData.nodes.Count)
                    {
                        nodeTextbox.Text = "Incorrect Variable Entered"; ;
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
    }
}
