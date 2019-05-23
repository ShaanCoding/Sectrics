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
        private const int cGrip = 16;
        private const int cCaption = 32;

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

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            buildBridgeMenu buildBridgeMenu = new buildBridgeMenu();
            this.Hide();
            buildBridgeMenu.Show();
        }
    }
}
