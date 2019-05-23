using Sectrics_V2.Properties;
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
    public partial class buildBridgeMenu : Form
    {
        float zoom = 1f;
        double xMouseOffset;
        double yMouseOffset;
        private const int cGrip = 16;
        private const int cCaption = 32;

        public buildBridgeMenu()
        {
            InitializeComponent();
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
            if ((Program.generalFunctions.desktopX - Program.generalFunctions.movX) != 0 && (Program.generalFunctions.desktopY - Program.generalFunctions.movY) != null)
            {
                this.SetDesktopLocation(Program.generalFunctions.desktopX - Program.generalFunctions.movX, Program.generalFunctions.desktopY - Program.generalFunctions.movY);
            }
            this.BackgroundImageLayout = ImageLayout.Stretch;
            bridgeDrawing.Refresh();
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

        private void bridgeDrawing_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                this.DoubleBuffered = true;
                int nodeMultiplyFactor = 100;
                Graphics g = e.Graphics;
                Pen beamPen = new Pen(Color.Black, 10);
                Pen greenPen = new Pen(Color.Green, 10);
                Pen forcePen = new Pen(Color.Red, 10);
                Pen reactionPen = new Pen(Color.Aqua, 10);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Font font = new Font("Arial", 16);
                g.ScaleTransform(zoom, zoom);

                //Draws Nodes Coordinates
                for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
                {
                    g.DrawEllipse(greenPen, (Convert.ToSingle(Program.bridgeData.nodes[i].NodeX) * nodeMultiplyFactor + Convert.ToSingle(xMouseOffset)), (Convert.ToSingle(Program.bridgeData.nodes[i].NodeY) * nodeMultiplyFactor + Convert.ToSingle(yMouseOffset)), 20, 20);
                }

                //Draws Member Lines With Width
                for (int i = 0; i < Program.bridgeData.memberConnection.Count; i++)
                {
                    Color penColor = Color.Black;

                    if (Program.bridgeData.areas.Count > i)
                    {
                        beamPen = new Pen(penColor, (10 * Convert.ToSingle(Program.bridgeData.areas[i])));
                    }
                    else
                    {
                        beamPen = new Pen(penColor, 10);
                    }
                    g.DrawLine(beamPen, (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.memberConnection[i].fromConnection].NodeX) * nodeMultiplyFactor + Convert.ToSingle(xMouseOffset)),
                        (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.memberConnection[i].fromConnection].NodeY) * nodeMultiplyFactor + Convert.ToSingle(yMouseOffset)),
                        (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.memberConnection[i].toConnection].NodeX) * nodeMultiplyFactor + Convert.ToSingle(xMouseOffset)),
                        (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.memberConnection[i].toConnection].NodeY) * nodeMultiplyFactor + Convert.ToSingle(yMouseOffset)));
                }

                //Draws Forces Applied
                for (int i = 0; i < Program.bridgeData.forces.Count; i++)
                {
                    if (!(Program.bridgeData.forces[i].xMagnitudeForces == 0 && Program.bridgeData.forces[i].yMagnitudeForces == 0))
                    {
                        g.DrawLine(forcePen, (Convert.ToSingle(Program.bridgeData.nodes[i].NodeX) * nodeMultiplyFactor + Convert.ToSingle(xMouseOffset)), (Convert.ToSingle(Program.bridgeData.nodes[i].NodeY) * nodeMultiplyFactor + Convert.ToSingle(yMouseOffset)), (Convert.ToSingle((Program.bridgeData.nodes[i].NodeX * nodeMultiplyFactor) + Program.bridgeData.forces[i].xMagnitudeForces) + Convert.ToSingle(xMouseOffset)), (Convert.ToSingle((Program.bridgeData.nodes[i].NodeY * nodeMultiplyFactor) + Program.bridgeData.forces[i].yMagnitudeForces) + Convert.ToSingle(yMouseOffset)));
                    }
                }

                //Draws The Support Locations
                Image verticalFixed = Resources.verticalSupport;
                Image horozontalFixed = Resources.horozontalSupport;
                Image verticalRoller = Resources.verticalRoller;
                Image horozontalRoller = Resources.horozontalRoller;
                for (int i = 0; i < Program.bridgeData.supportType.Count; i++)
                {
                    switch (Program.bridgeData.supportType[i])
                    {
                        case "Vertical Fixed Support":
                            g.DrawImage(verticalFixed, (Convert.ToSingle(Program.bridgeData.nodes[i].NodeX) * nodeMultiplyFactor + Convert.ToSingle(xMouseOffset)), (Convert.ToSingle(Program.bridgeData.nodes[i].NodeY) * nodeMultiplyFactor + Convert.ToSingle(yMouseOffset)));
                            break;
                        case "Horozontal Fixed Support":
                            g.DrawImage(horozontalFixed, (Convert.ToSingle(Program.bridgeData.nodes[i].NodeX) * nodeMultiplyFactor + Convert.ToSingle(xMouseOffset)), (Convert.ToSingle(Program.bridgeData.nodes[i].NodeY) * nodeMultiplyFactor + Convert.ToSingle(yMouseOffset)));
                            break;
                        case "Vertical Roller":
                            g.DrawImage(verticalRoller, (Convert.ToSingle(Program.bridgeData.nodes[i].NodeX) * nodeMultiplyFactor + Convert.ToSingle(xMouseOffset)), (Convert.ToSingle(Program.bridgeData.nodes[i].NodeY) * nodeMultiplyFactor + Convert.ToSingle(yMouseOffset)));
                            break;
                        case "Horozontal Roller":
                            g.DrawImage(horozontalRoller, (Convert.ToSingle(Program.bridgeData.nodes[i].NodeX) * nodeMultiplyFactor + Convert.ToSingle(xMouseOffset)), (Convert.ToSingle(Program.bridgeData.nodes[i].NodeY) * nodeMultiplyFactor + Convert.ToSingle(yMouseOffset)));
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR: An Error Has Occured Drawing The Bridge");
            }
        }

        private void zoomInBar_Scroll(object sender, EventArgs e)
        {
            zoom = zoomInBar.Value / 100f;
            bridgeDrawing.Refresh();
        }

        private void bridgeDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            double oMouseXOffset = Cursor.Position.X;
            double oMouseYOffset = Cursor.Position.Y;

            if (e.Button == MouseButtons.Left)
            {
                //Finds the change in mouse position when dragging
                float deltaX = Convert.ToSingle(Cursor.Position.X - oMouseXOffset) * 10;
                float deltaY = Convert.ToSingle(Cursor.Position.Y - oMouseYOffset) * 10;

                xMouseOffset += deltaX;
                yMouseOffset += deltaY;
                bridgeDrawing.Refresh();
            }
        }
    }
}
