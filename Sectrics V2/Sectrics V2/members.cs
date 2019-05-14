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
    public partial class members : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        public members()
        {
            InitializeComponent();
            this.SetDesktopLocation(Program.generalFunctions.desktopX - Program.generalFunctions.movX, Program.generalFunctions.desktopY - Program.generalFunctions.movY);

            //Adds The Array Coordinates Into ListBox
            nodeListView.Items.Clear();
            for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
            {
                nodeListView.Items.Add("Node " + i + " " + "X Coordinate: " + Program.bridgeData.nodes[i].NodeX.ToString() + " | Y Coordinate: " + Program.bridgeData.nodes[i].NodeY.ToString());
            }

            //Adds The Array Coordinates Into ListBox
            membersListView.Items.Clear();
            for (int i = 0; i < Program.bridgeData.memberConnection.Count; i++)
            {
                membersListView.Items.Add("To Member: " + Program.bridgeData.memberConnection[i].toConnection.ToString() + " | From Member: " + Program.bridgeData.memberConnection[i].fromConnection.ToString());
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
            if((Program.generalFunctions.desktopX - Program.generalFunctions.movX) != 0 && (Program.generalFunctions.desktopY - Program.generalFunctions.movY) != null)
            {
                this.SetDesktopLocation(Program.generalFunctions.desktopX - Program.generalFunctions.movX, Program.generalFunctions.desktopY - Program.generalFunctions.movY);
            }
            this.BackgroundImageLayout = ImageLayout.Stretch;
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

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool repeatedMember = false;
                for(int i = 0; i < Program.bridgeData.memberConnection.Count; i++)
                {
                    if(Program.bridgeData.memberConnection[i].toConnection == Convert.ToInt16(toMemberTextbox.Text) && Program.bridgeData.memberConnection[i].fromConnection == Convert.ToInt16(fromMemberTextbox.Text)
                        || Program.bridgeData.memberConnection[i].toConnection == Convert.ToInt16(fromMemberTextbox.Text) && Program.bridgeData.memberConnection[i].fromConnection == Convert.ToInt16(toMemberTextbox.Text))
                    {
                        repeatedMember = true;
                    }
                }
                if (toMemberTextbox.Text != null && fromMemberTextbox.Text != null && Convert.ToInt16(toMemberTextbox.Text) < Program.bridgeData.nodes.Count && Convert.ToInt16(fromMemberTextbox.Text) < Program.bridgeData.nodes.Count && repeatedMember == false)
                {
                    Program.bridgeData.memberConnection.Add(new connectedMembers());
                    Program.bridgeData.memberConnection[Program.bridgeData.memberIndex].fromConnection = Convert.ToInt16(fromMemberTextbox.Text);
                    Program.bridgeData.memberConnection[Program.bridgeData.memberIndex].toConnection = Convert.ToInt16(toMemberTextbox.Text);
                    Program.bridgeData.memberIndex++;
                    fromMemberTextbox.Text = "";
                    toMemberTextbox.Text = "";
                }
                else if (toMemberTextbox.Text == null)
                {
                    toMemberTextbox.Text = "Incorrect Variable Entered";
                }
                else if (fromMemberTextbox.Text == null)
                {
                    fromMemberTextbox.Text = "Incorrect Variable Entered";
                }
                else
                {
                    toMemberTextbox.Text = "Incorrect Variable Entered";
                    fromMemberTextbox.Text = "Incorrect Variable Entered";
                }

                //Adds The Array Coordinates Into ListBox
                membersListView.Items.Clear();
                for (int i = 0; i < Program.bridgeData.memberConnection.Count; i++)
                {
                    membersListView.Items.Add("To Member: " + Program.bridgeData.memberConnection[i].toConnection.ToString() + " | From Member: " + Program.bridgeData.memberConnection[i].fromConnection.ToString());
                }
            }
            catch
            {
                toMemberTextbox.Text = "Incorrect Variable Entered";
                fromMemberTextbox.Text = "Incorrect Variable Entered";
            }
        }

        private void fromMemberTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toMemberTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeMember_Click(object sender, EventArgs e)
        {
            if (membersListView.SelectedIndex >= 0)
            {
                Program.bridgeData.memberConnection.RemoveAt(membersListView.SelectedIndex);
                Program.bridgeData.memberIndex--;

                //Adds The Array Coordinates Into ListBox
                membersListView.Items.Clear();
                for (int i = 0; i < Program.bridgeData.memberConnection.Count; i++)
                {
                    membersListView.Items.Add("To Member: " + Program.bridgeData.memberConnection[i].toConnection.ToString() + " | From Member: " + Program.bridgeData.memberConnection[i].fromConnection.ToString());
                }
            }
            else
            {
                MessageBox.Show("Error: Must Select An Item Before Clicking It.");
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            Program.bridgeData.memberConnection.Clear();
            Program.bridgeData.memberIndex = 0;

            //Adds The Array Coordinates Into ListBox
            membersListView.Items.Clear();
            for (int i = 0; i < Program.bridgeData.memberConnection.Count; i++)
            {
                membersListView.Items.Add("To Member: " + Program.bridgeData.memberConnection[i].toConnection.ToString() + " | From Member: " + Program.bridgeData.memberConnection[i].fromConnection.ToString());
            }
        }

        private void membersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nodeListView_SelectedIndexChanged(object sender, EventArgs e)
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
