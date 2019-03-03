using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sectrics_V2
{
    public partial class solveMenus : Form
    {
        float zoom = 1f;

        public solveMenus()
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
            }
        }

        private void bridgeDrawing_Paint(object sender, PaintEventArgs e)
        {
            int nodeMultiplyFactor = 100;
            Graphics g = e.Graphics;
            Pen beamPen = new Pen(Color.Black, 10);
            Pen greenPen = new Pen(Color.Green, 10);
            Pen forcePen = new Pen(Color.Red, 10);
            forcePen.StartCap = LineCap.ArrowAnchor;
            forcePen.EndCap = LineCap.RoundAnchor;
            g.ScaleTransform(zoom, zoom);

            //Draws Nodes Coordinates
            for(int i = 0; i < Program.bridgeData.nodes.Count; i++)
            {
                g.DrawEllipse(greenPen, (Convert.ToSingle(Program.bridgeData.nodes[i].NodeX) * nodeMultiplyFactor), (Convert.ToSingle(Program.bridgeData.nodes[i].NodeY) * nodeMultiplyFactor), 20, 20);
            }

            //Draws Member Lines With Width
            for(int i = 0; i < Program.bridgeData.memberConnection.Count; i++)
            {
                if(Program.bridgeData.areas.Count > i)
                {
                    beamPen = new Pen(Color.Black, (10 * Convert.ToSingle(Program.bridgeData.areas[i])));
                }
                else
                {
                    beamPen = new Pen(Color.Black, 10);
                }

                g.DrawLine(beamPen, (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.memberConnection[i].fromConnection].NodeX) * nodeMultiplyFactor), (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.memberConnection[i].fromConnection].NodeY) * nodeMultiplyFactor), (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.memberConnection[i].toConnection].NodeX) * nodeMultiplyFactor), (Convert.ToSingle(Program.bridgeData.nodes[Program.bridgeData.memberConnection[i].toConnection].NodeY) * nodeMultiplyFactor));
            }

            //Draws Forces Applied
            for (int i = 0; i < Program.bridgeData.forces.Count; i++)
            {
                if(!(Program.bridgeData.forces[i].xMagnitudeForces == 0 && Program.bridgeData.forces[i].yMagnitudeForces == 0))
                {
                    g.DrawLine(forcePen, (Convert.ToSingle(Program.bridgeData.nodes[i].NodeX) * nodeMultiplyFactor), (Convert.ToSingle(Program.bridgeData.nodes[i].NodeY) * nodeMultiplyFactor), (Convert.ToSingle((Program.bridgeData.nodes[i].NodeX * nodeMultiplyFactor) + Program.bridgeData.forces[i].xMagnitudeForces)), Convert.ToSingle((Program.bridgeData.nodes[i].NodeY * nodeMultiplyFactor) + Program.bridgeData.forces[i].yMagnitudeForces));
                }
            }

            //Draws The Support Locations
        }

        private void zoomInBar_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
            zoom = zoomInBar.Value / 100f;
            bridgeDrawing.Invalidate();
        }
    }
}
