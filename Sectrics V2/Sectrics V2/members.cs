﻿using System;
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
        public members()
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
            members node = new members();
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

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (toMemberTextbox.Text != null && fromMemberTextbox.Text != null && Convert.ToInt16(toMemberTextbox.Text) < Program.bridgeData.nodes.Count && Convert.ToInt16(fromMemberTextbox.Text) < Program.bridgeData.nodes.Count)
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
    }
}