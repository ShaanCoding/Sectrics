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

            //Adds The Array Coordinates Into ListBox
            membersListView.Items.Clear();
            for (int i = 0; i < Program.bridgeData.memberConnection.Count; i++)
            {
                membersListView.Items.Add("To Member: " + Program.bridgeData.memberConnection[i].toConnection.ToString() + " | From Member: " + Program.bridgeData.memberConnection[i].fromConnection.ToString());
            }

            //Adds The Array Coordinates Into ListBox
            materialsListView.Items.Clear();
            for(int i = 0; i < Program.bridgeData.areas.Count; i++)
            {
                materialsListView.Items.Add("Young Modulus: " + Program.bridgeData.stiffness[i] + " | Cross-Sectional Area: " + Program.bridgeData.areas[i]); 
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
            if ((Program.generalFunctions.desktopX - Program.generalFunctions.movX) != 0 && (Program.generalFunctions.desktopY - Program.generalFunctions.movY) != null)
            {
                this.SetDesktopLocation(Program.generalFunctions.desktopX - Program.generalFunctions.movX, Program.generalFunctions.desktopY - Program.generalFunctions.movY);
            }
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

                //Adds The Array Coordinates Into ListBox
                materialsListView.Items.Clear();
                for (int i = 0; i < Program.bridgeData.areas.Count; i++)
                {
                    materialsListView.Items.Add("Young Modulus: " + Program.bridgeData.stiffness[i] + " | Cross-Sectional Area: " + Program.bridgeData.areas[i]);
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

        private void membersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            Program.bridgeData.stiffness.Clear();
            Program.bridgeData.areas.Clear();
            Program.bridgeData.materialPropertiesIndex = 0;

            //Adds The Array Coordinates Into ListBox
            materialsListView.Items.Clear();
            for (int i = 0; i < Program.bridgeData.areas.Count; i++)
            {
                materialsListView.Items.Add("Young Modulus: " + Program.bridgeData.stiffness[i] + " | Cross-Sectional Area: " + Program.bridgeData.areas[i]);
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
    }
}
