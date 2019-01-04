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
    public partial class materialProperties : Form
    {

        public materialProperties()
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
            materialProperties node = new materialProperties();
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

        private void addMaterialPropertiesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (youngModulusTextbox.Text != null && areaTextbox.Text != null&& Program.bridgeData.stiffness.Count!=Program.bridgeData.memberConnection.Count&&Program.bridgeData.areas.Count!=Program.bridgeData.memberConnection.Count)
                {
                    Program.bridgeData.stiffness.Add(Convert.ToDouble(youngModulusTextbox.Text));
                    Program.bridgeData.areas.Add(Convert.ToDouble(areaTextbox.Text));
                    youngModulusTextbox.Text = "";
                    areaTextbox.Text = "";
                }
                else if (youngModulusTextbox.Text == null || Program.bridgeData.stiffness.Count == Program.bridgeData.memberConnection.Count)
                {
                    youngModulusTextbox.Text = "Incorrect Variable Entered";
                }
                else if (areaTextbox.Text == null || Program.bridgeData.areas.Count == Program.bridgeData.memberConnection.Count)
                {
                    areaTextbox.Text = "Incorrect Variable Entered";
                }
                else
                {
                    youngModulusTextbox.Text = "Incorrect Variable Entered";
                    areaTextbox.Text = "Incorrect Variable Entered";
                }
            }
            catch
            {
                youngModulusTextbox.Text = "Incorrect Variable Entered";
                areaTextbox.Text = "Incorrect Variable Entered";
            }
        }

        private void areaTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void youngModulusTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
