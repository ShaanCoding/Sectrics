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

        public supportMenus()
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


                int XDOF = ((Convert.ToInt32(supportNodeTextbox.Text) + 1) * 2 - 1);
                int YDOF = ((Convert.ToInt32(supportNodeTextbox.Text) + 1) * 2);

                if (Convert.ToInt16(supportNodeTextbox.Text) < Program.bridgeData.nodes.Count)
                {
                    switch (supportType.Text)
                    {
                        case "Fixed Support":
                            Program.bridgeData.restrainedDegreesOfFreedom.Add(XDOF);
                            Program.bridgeData.restrainedDegreesOfFreedom.Add(YDOF);
                            break;
                        case "Vertical Roller":
                            Program.bridgeData.restrainedDegreesOfFreedom.Add(XDOF);
                            break;
                        case "Horozontal Roller":
                            Program.bridgeData.restrainedDegreesOfFreedom.Add(YDOF);
                            break;
                        default:
                            supportNodeTextbox.Text = "Incorrect Variable Entered";
                            break;
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
    }
}
