using Sectrics_V2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sectrics_V2
{
    public partial class solveMenus : Form
    {
        double[] stressForPanel = new double[Program.bridgeData.memberConnection.Count];
        double[] reactionForceForPanel = new double[Program.bridgeData.supportNode.Count];
        float zoom = 1f;
        double xMouseOffset;
        double yMouseOffset;
        private const int cGrip = 16;
        private const int cCaption = 32;


        public solveMenus()
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

        private void nodes_Load(object sender, EventArgs e)
        {
            if ((Program.generalFunctions.desktopX - Program.generalFunctions.movX) != 0 && (Program.generalFunctions.desktopY - Program.generalFunctions.movY) != null)
            {
                this.SetDesktopLocation(Program.generalFunctions.desktopX - Program.generalFunctions.movX, Program.generalFunctions.desktopY - Program.generalFunctions.movY);
            }
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void barStressesTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        static double[,] rotation_matrix(double[] deltaPoint)
        {
            double[] x_axis = { 1, 0 };
            double[] y_axis = { 0, 1 };

            double x_proj = Program.maths.dotProduct(deltaPoint, x_axis) * (1 / ((Program.maths.distanceFormula(0, 0, deltaPoint[0], deltaPoint[1])) * (Program.maths.distanceFormula(0, 0, x_axis[0], x_axis[1]))));
            double y_proj = Program.maths.dotProduct(deltaPoint, y_axis) * (1 / ((Program.maths.distanceFormula(0, 0, deltaPoint[0], deltaPoint[1])) * (Program.maths.distanceFormula(0, 0, y_axis[0], y_axis[1]))));
            double[,] returnMatrix = { { x_proj, y_proj, 0, 0 }, { 0, 0, x_proj, y_proj } };
            return returnMatrix;
        }

        private void solveForForces_Click(object sender, EventArgs e)
        {
            double[,] nodes = new double[Program.bridgeData.nodes.Count, 2];
            for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
            {
                nodes[i, 0] = Program.bridgeData.nodes[i].NodeX;
                nodes[i, 1] = Program.bridgeData.nodes[i].NodeY;
            }

            int[,] degreesOfFreedom = new int[Program.bridgeData.degreesOfFreedom.Count, 2];
            for (int i = 0; i < Program.bridgeData.degreesOfFreedom.Count; i++)
            {
                degreesOfFreedom[i, 0] = Program.bridgeData.degreesOfFreedom[i].xDegreeOfFreedom;
                degreesOfFreedom[i, 1] = Program.bridgeData.degreesOfFreedom[i].yDegreesOfFreedom;
            }

            int[,] memberConnections = new int[Program.bridgeData.memberConnection.Count, 2];
            for (int i = 0; i < Program.bridgeData.memberConnection.Count; i++)
            {
                memberConnections[i, 0] = Program.bridgeData.memberConnection[i].fromConnection;
                memberConnections[i, 1] = Program.bridgeData.memberConnection[i].toConnection;
            }

            double[,] forces = new double[Program.bridgeData.forces.Count, 2];
            for (int i = 0; i < Program.bridgeData.forces.Count; i++)
            {
                forces[i, 0] = Program.bridgeData.forces[i].xMagnitudeForces;
                forces[i, 1] = Program.bridgeData.forces[i].yMagnitudeForces;
            }


            int[] restrainedDegreesOfFreedom = Program.bridgeData.restrainedDegreesOfFreedom.ToArray();
            double[] stiffness = Program.bridgeData.stiffness.ToArray();
            double[] areas = Program.bridgeData.areas.ToArray();
            int ndof = Program.bridgeData.ndof;




            //M,K,F MATRIX
            double[,] M = Program.maths.zeroMatrix(ndof, ndof);
            double[,] K = Program.maths.zeroMatrix(ndof, ndof);
            double[] F = new double[forces.GetLength(0) * 2];

            for (int i = 0; i < memberConnections.GetLength(0); i++)
            {
                int fromNode = memberConnections[i, 0];
                int toNode = memberConnections[i, 1];
                double[] fromPoint = { nodes[fromNode, 0], nodes[fromNode, 1] };
                double[] toPoint = { nodes[toNode, 0], nodes[toNode, 1] };
                double[] deltaPoint = { (toPoint[0] - fromPoint[0]), (toPoint[1] - fromPoint[1]) };
                int[] dofs = { degreesOfFreedom[fromNode, 0], degreesOfFreedom[fromNode, 1], degreesOfFreedom[toNode, 0], degreesOfFreedom[toNode, 1] };

                //Find Element Mass & Stiffness Matrix
                double length = Program.maths.distanceFormula(toPoint[0], toPoint[1], fromPoint[0], fromPoint[1]);
                double area = areas[i];
                double Ck = stiffness[i] * area / length;

                double[,] k = { { 1, -1 }, { -1, 1 } };

                double[,] tau = rotation_matrix(deltaPoint);
                double[,] k_r = Program.maths.matrixMultiplication(Program.maths.matrixMultiplication(Program.maths.transposeSolver(tau), k), tau);
                //Change from element matrix to global matrix

                double[,] B = Program.maths.zeroMatrix(4, ndof);

                for (int l = 0; l < 4; l++)
                {
                    B[l, (dofs[l] - 1)] = 1.0;
                }

                double[,] K_rG = Program.maths.matrixMultiplication(Program.maths.matrixMultiplication(Program.maths.transposeSolver(B), k_r), B);
                K = Program.maths.matrixAddition(K, Program.maths.oneValueMultiplyMatrix(Ck, K_rG));

            }

            //Construct force vector
            int u = 0;
            int y = 0;
            for (int p = 0; p < F.GetLength(0); p++)
            {
                F[p] = forces[u, y];
                y++;
                if (y == 2)
                {
                    y = 0;
                    u++;
                }
            }

            //Remove Restrained Degrees Of Freedom Remove row & axis of the corresponding index of restrainedDOF
            int[] remove_indices = Program.maths.vectorAdditionByOne(-1, restrainedDegreesOfFreedom);
            double[,] MRemovedDOF = Program.maths.vectorMatrixRemove(M, remove_indices, remove_indices);
            double[,] KRemovedDOF = Program.maths.vectorMatrixRemove(K, remove_indices, remove_indices);
            double[] forceRemovedDOF = Program.maths.vectorVectorRemove(F, remove_indices);

            //Displacements
            double[] displacements = Program.maths.vectorMatrixDotProduct(Program.maths.inverseMatrix(KRemovedDOF), forceRemovedDOF);

            barStressesTextbox.AppendText("===== Displacements =====\r\n");
            for(int i = 0; i < displacements.GetLength(0); i++)
            {
                barStressesTextbox.AppendText(Convert.ToString(displacements[i])+ "\r\n");
            }
            barStressesTextbox.AppendText(Environment.NewLine);
            barStressesTextbox.AppendText(Environment.NewLine);
            barStressesTextbox.AppendText("===== Stresses =====\r\n");
            barStressesTextbox.AppendText(Environment.NewLine);

            for (int i = 0; i < memberConnections.GetLength(0); i++)
            {
                int fromNode = memberConnections[i, 0];
                int toNode = memberConnections[i, 1];
                double[] fromPoint = { nodes[fromNode, 0], nodes[fromNode, 1] };
                double[] toPoint = { nodes[toNode, 0], nodes[toNode, 1] };
                double[] deltaPoint = { (toPoint[0] - fromPoint[0]), (toPoint[1] - fromPoint[1]) };
                int[] dofs = { degreesOfFreedom[fromNode, 0], degreesOfFreedom[fromNode, 1], degreesOfFreedom[toNode, 0], degreesOfFreedom[toNode, 1] };
                double[,] tau = rotation_matrix(deltaPoint);
                double[] globalDisplacements = { 0, 0, displacements[0], displacements[1] };
                double[] q = Program.maths.vectorMatrixDotProduct(tau, globalDisplacements);
                double strain = (q[1] - q[0]) /Program. maths.distanceFormula(0, 0, deltaPoint[0], deltaPoint[1]);
                double stress = stiffness[i] * strain;
                barStressesTextbox.AppendText(Convert.ToString(stress)+ "\r\n");
                stressForPanel[i] = stress;
            }

            //Calculates reaction forces for each support
            for(int i = 0; i < Program.bridgeData.supportNode.Count; i++)
            {
                reactionForceForPanel[i] = 0;
                for(int j = 0; j < Program.bridgeData.memberConnection.Count; j++)
                {
                    if(Program.bridgeData.memberConnection[j].fromConnection == Program.bridgeData.supportNode[i] || Program.bridgeData.memberConnection[j].toConnection == Program.bridgeData.supportNode[i])
                    {
                        reactionForceForPanel[i] += stressForPanel[j];
                    }
                }
                reactionForceForPanel[i] = reactionForceForPanel[i] * -1;
            }

            bridgeDrawing.Refresh();
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
                forcePen.StartCap = LineCap.ArrowAnchor;
                forcePen.EndCap = LineCap.RoundAnchor;
                g.ScaleTransform(zoom, zoom);

                //Draws Nodes Coordinates
                for (int i = 0; i < Program.bridgeData.nodes.Count; i++)
                {
                    g.DrawEllipse(greenPen, (Convert.ToSingle(Program.bridgeData.nodes[i].NodeX) * nodeMultiplyFactor + Convert.ToSingle(xMouseOffset)), (Convert.ToSingle(Program.bridgeData.nodes[i].NodeY) * nodeMultiplyFactor + Convert.ToSingle(yMouseOffset)), 20, 20);
                }

                //Draws Member Lines With Width
                for (int i = 0; i < Program.bridgeData.memberConnection.Count; i++)
                {
                    Color penColor;

                    if (stressForPanel != null && stressForPanel[i] > 0)
                    {
                        penColor = Color.Red;
                    }
                    else if (stressForPanel != null && stressForPanel[i] < 0)
                    {
                        penColor = Color.Blue;
                    }
                    else
                    {
                        penColor = Color.Black;
                    }

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

                    //Draws Forces Applied Magnitude Text
                    if (stressForPanel[i] != null)
                    {
                        g.DrawString(stressForPanel[i].ToString(), font, blackBrush,
                            (((Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.memberConnection[i].fromConnection].NodeX) * nodeMultiplyFactor) + (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.memberConnection[i].toConnection].NodeX) * nodeMultiplyFactor)) / 2 + Convert.ToSingle(xMouseOffset)), (((Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.memberConnection[i].fromConnection].NodeY) * nodeMultiplyFactor) + (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.memberConnection[i].toConnection].NodeY) * nodeMultiplyFactor)) / 2 + Convert.ToSingle(yMouseOffset)));
                    }
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

                //Draws The Reaction Forces
                if(reactionForceForPanel != null)
                {
                    for (int i = 0; i < reactionForceForPanel.GetLength(0); i++)
                    {
                        g.DrawLine(reactionPen, (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.supportNode[i]].NodeX * nodeMultiplyFactor + Convert.ToSingle(xMouseOffset))), (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.supportNode[i]].NodeY * nodeMultiplyFactor + Convert.ToSingle(yMouseOffset))), (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.supportNode[i]].NodeX * nodeMultiplyFactor + Convert.ToSingle(xMouseOffset) + reactionForceForPanel[i])), (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.supportNode[i]].NodeY * nodeMultiplyFactor + Convert.ToSingle(yMouseOffset) + reactionForceForPanel[i])));
                        g.DrawString((reactionForceForPanel[i].ToString()), font, blackBrush, ((Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.supportNode[i]].NodeX * nodeMultiplyFactor)) + (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.supportNode[i]].NodeX * nodeMultiplyFactor + reactionForceForPanel[i]))) / 2 + Convert.ToSingle(xMouseOffset), ((Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.supportNode[i]].NodeY * nodeMultiplyFactor)) + (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.supportNode[i]].NodeY * nodeMultiplyFactor + reactionForceForPanel[i]))) / 2 + Convert.ToSingle(yMouseOffset));
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

            if(e.Button == MouseButtons.Left)
            {
                //Finds the change in mouse position when dragging
                float deltaX = Convert.ToSingle(Cursor.Position.X - oMouseXOffset) * 10;
                float deltaY = Convert.ToSingle(Cursor.Position.Y - oMouseYOffset) * 10;

                xMouseOffset += deltaX;
                yMouseOffset += deltaY;
                bridgeDrawing.Refresh();
            }
        }

        private void savePictureOfBridge_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveBridgePhoto = new SaveFileDialog();
                saveBridgePhoto.DefaultExt = "png";
                saveBridgePhoto.Filter = "PNG|*.png";

                if(saveBridgePhoto.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveBridgePhoto.FileName))
                    {
                        File.Delete(saveBridgePhoto.FileName);
                    }

                    int width = bridgeDrawing.Size.Width;
                    int height = bridgeDrawing.Size.Height;

                    Bitmap bitmap = new Bitmap(width, height);
                    bridgeDrawing.DrawToBitmap(bitmap, new Rectangle(0, 0, width, height));
                    bitmap.Save(saveBridgePhoto.FileName, ImageFormat.Png);
                }
            }
            catch
            {
                MessageBox.Show("ERROR: An Error Has Occured Whilst Saving");
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
