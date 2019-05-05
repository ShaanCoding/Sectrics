using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sectrics_V2
{
    class generalFunctions
    {
        public void saveFileCSV()
        {
            try
            {
                SaveFileDialog saveBridge = new SaveFileDialog();
                saveBridge.DefaultExt = "csv";
                saveBridge.Filter = "CSV|*.csv";
                if (saveBridge.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(saveBridge.FileName, FileMode.CreateNew))
                    {
                        using (StreamWriter sw = new StreamWriter(s))
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

                            int[] supportNode = new int[Program.bridgeData.supportNode.Count];
                            for(int i = 0; i < Program.bridgeData.supportNode.Count;i++)
                            {
                                supportNode[i] = Program.bridgeData.supportNode[i];
                            }

                            string[] supportType = new string[Program.bridgeData.supportType.Count];
                            for(int i = 0; i < Program.bridgeData.supportType.Count; i++)
                            {
                                supportType[i] = Program.bridgeData.supportType[i];
                            }

                            int[] restrainedDegreesOfFreedom = Program.bridgeData.restrainedDegreesOfFreedom.ToArray();
                            double[] stiffness = Program.bridgeData.stiffness.ToArray();
                            double[] areas = Program.bridgeData.areas.ToArray();
                            int ndof = Program.bridgeData.ndof;

                            //Finds the maximum length array
                            int maxLength = 0;
                            if (nodes.GetLength(0) > maxLength)
                            {
                                maxLength = nodes.GetLength(0);
                            }
                            if (degreesOfFreedom.GetLength(0) > maxLength)
                            {
                                maxLength = degreesOfFreedom.GetLength(0);
                            }
                            if (memberConnections.GetLength(0) > maxLength)
                            {
                                maxLength = memberConnections.GetLength(0);
                            }
                            if (forces.GetLength(0) > maxLength)
                            {
                                maxLength = forces.GetLength(0);
                            }
                            if (restrainedDegreesOfFreedom.Length > maxLength)
                            {
                                maxLength = restrainedDegreesOfFreedom.Length;
                            }
                            if (stiffness.Length > maxLength)
                            {
                                maxLength = stiffness.Length;
                            }
                            if (areas.Length > maxLength)
                            {
                                maxLength = areas.Length;
                            }
                            if (supportNode.Length > maxLength)
                            {
                                maxLength = supportNode.Length;
                            }
                            if(supportType.Length > maxLength)
                            {
                                maxLength = supportType.Length;
                            }

                           
                            //Writes Into CSV
                            sw.WriteLine("Nodes X,Nodes Y,X Degree Of Freedom,Y Degree Of Freedom,From Member,To Member,X Force,Y Force,Restrained Degree Of Freedom,Stiffness,Area,Support Node,Support Type,Ndof");
                            for (int i = 0; i < maxLength; i++)
                            {
                                if (i < nodes.GetLength(0))
                                {
                                    sw.Write(nodes[i, 0] + "," + nodes[i, 1] + ",");
                                }
                                else
                                {
                                    sw.Write(",,");
                                }

                                if (i < degreesOfFreedom.GetLength(0))
                                {
                                    sw.Write(degreesOfFreedom[i, 0] + "," + degreesOfFreedom[i, 1] + ",");
                                }
                                else
                                {
                                    sw.Write(",,");
                                }

                                if (i < memberConnections.GetLength(0))
                                {
                                    sw.Write(memberConnections[i, 0] + "," + memberConnections[i, 1] + ",");
                                }
                                else
                                {
                                    sw.Write(",,");
                                }

                                if (i < forces.GetLength(0))
                                {
                                    sw.Write(forces[i, 0] + "," + forces[i, 1] + ",");
                                }
                                else
                                {
                                    sw.Write(",,");
                                }

                                if (i < restrainedDegreesOfFreedom.Length)
                                {
                                    sw.Write(restrainedDegreesOfFreedom[i] + ",");
                                }
                                else
                                {
                                    sw.Write(",");
                                }

                                if (i < areas.Length)
                                {
                                    sw.Write(areas[i] + ",");
                                }
                                else
                                {
                                    sw.Write(",");
                                }

                                if (i < stiffness.Length)
                                {
                                    sw.Write(stiffness[i] + ",");
                                }
                                else
                                {
                                    sw.Write(",");
                                }

                                if (i < supportNode.Length)
                                {
                                    sw.Write(supportNode[i] + ",");
                                }
                                else
                                {
                                    sw.Write(",");
                                }

                                if (i < supportType.Length)
                                {
                                    sw.Write(supportType[i] + ",");
                                }
                                else
                                {
                                    sw.Write(",");
                                }

                                if (i == 0)
                                {
                                    sw.Write(ndof+"\n");
                                }
                                else
                                {
                                    sw.Write(",\n");
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR: An Error Has Occured Whilst Saving");
            }
        }

        public void LoadFileCSV()
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
