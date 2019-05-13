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
        public int mov;
        public int movX;
        public int movY;
        public int desktopX;
        public int desktopY;

        public void saveFileCSV()
        {
            try
            {
                SaveFileDialog saveBridge = new SaveFileDialog();
                saveBridge.DefaultExt = "csv";
                saveBridge.Filter = "CSV|*.csv";
                if (saveBridge.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveBridge.FileName))
                    {
                        File.Delete(saveBridge.FileName);
                    }
                    
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
                            int nodeIndex = Program.bridgeData.nodesIndex;
                            int memberIndex = Program.bridgeData.memberIndex;
                            int materialPropertIndex = Program.bridgeData.materialPropertiesIndex;

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
                            sw.WriteLine("Nodes X,Nodes Y,X Degree Of Freedom,Y Degree Of Freedom,From Member,To Member,X Force,Y Force,Restrained Degree Of Freedom,Stiffness,Area,Support Node,Support Type,Ndof, Node Index, Member Index, Material Properties Index");
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

                                if (i < stiffness.Length)
                                {
                                    sw.Write(stiffness[i] + ",");
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
                                    sw.Write(nodeIndex + ",");
                                    sw.Write(memberIndex + ",");
                                    sw.Write(materialPropertIndex + ",");
                                    sw.Write(ndof+"\n");
                                }
                                else
                                {
                                    sw.Write(",,,\n");
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("ERROR: An Error Has Occured Whilst Saving ");
            }
        }

        public void LoadFileCSV()
        {
            try
            {
                Program.bridgeData.supportType.Clear();
                Program.bridgeData.supportNode.Clear();
                Program.bridgeData.nodes.Clear();
                Program.bridgeData.degreesOfFreedom.Clear();
                Program.bridgeData.memberConnection.Clear();
                Program.bridgeData.restrainedDegreesOfFreedom.Clear();
                Program.bridgeData.forces.Clear();
                Program.bridgeData.stiffness.Clear();
                Program.bridgeData.areas.Clear();

                Program.bridgeData.ndof = 0;
                Program.bridgeData.nodesIndex = 0;
                Program.bridgeData.memberIndex = 0;
                Program.bridgeData.materialPropertiesIndex = 0;

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.DefaultExt = "csv";
                openFileDialog.Filter = "CSV|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(openFileDialog.FileName, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(s))
                        {
                            string data = sr.ReadLine();
                            int i = 0;
                            while((data = sr.ReadLine()) != null)
                            {
                                var dataSplit = data.Split(',');
                                MessageBox.Show(data);

                                if (string.IsNullOrEmpty(dataSplit[0]) && string.IsNullOrEmpty(dataSplit[1]))
                                {
                                    Program.bridgeData.nodes.Add(new Nodes());
                                    Program.bridgeData.nodes[i].NodeX = Convert.ToDouble(dataSplit[0]);
                                    Program.bridgeData.nodes[i].NodeY = Convert.ToDouble(dataSplit[1]);
                                    Program.bridgeData.nodesIndex++;
                                }

                                if (string.IsNullOrEmpty(dataSplit[2]) && string.IsNullOrEmpty(dataSplit[3]))
                                {
                                    Program.bridgeData.degreesOfFreedom.Add(new degreesOfFreedom());
                                    Program.bridgeData.degreesOfFreedom[i].xDegreeOfFreedom = Convert.ToInt16(dataSplit[2]);
                                    Program.bridgeData.degreesOfFreedom[i].yDegreesOfFreedom = Convert.ToInt16(dataSplit[3]);
                                }

                                if (string.IsNullOrEmpty(dataSplit[4]) && string.IsNullOrEmpty(dataSplit[5]))
                                {
                                    Program.bridgeData.memberConnection.Add(new connectedMembers());
                                    Program.bridgeData.memberConnection[i].fromConnection = Convert.ToInt16(dataSplit[4]);
                                    Program.bridgeData.memberConnection[i].toConnection = Convert.ToInt16(dataSplit[5]);
                                    Program.bridgeData.memberIndex++;
                                }

                                if (string.IsNullOrEmpty(dataSplit[6]) && string.IsNullOrEmpty(dataSplit[7]))
                                {
                                    Program.bridgeData.forces.Add(new forces());
                                    Program.bridgeData.forces[i].xMagnitudeForces = Convert.ToDouble(dataSplit[6]);
                                    Program.bridgeData.forces[i].yMagnitudeForces = Convert.ToDouble(dataSplit[7]);
                                }

                                if (string.IsNullOrEmpty(dataSplit[8]))
                                {
                                    Program.bridgeData.restrainedDegreesOfFreedom.Add(Convert.ToInt32(dataSplit[8]));
                                }

                                if (string.IsNullOrEmpty(dataSplit[9]))
                                {
                                    Program.bridgeData.stiffness.Add(Convert.ToDouble(dataSplit[9]));
                                }

                                if (string.IsNullOrEmpty(dataSplit[10]))
                                {
                                    Program.bridgeData.areas.Add(Convert.ToDouble(dataSplit[10]));
                                }

                                if (string.IsNullOrEmpty(dataSplit[11]))
                                {
                                    Program.bridgeData.supportNode.Add(Convert.ToInt16(dataSplit[11]));
                                }

                                if (string.IsNullOrEmpty(dataSplit[12]))
                                {
                                    Program.bridgeData.supportType.Add(Convert.ToString(dataSplit[12]));
                                }

                                if (i == 0)
                                {
                                    Program.bridgeData.ndof = Convert.ToInt16(dataSplit[13]);
                                    Program.bridgeData.nodesIndex = Convert.ToInt16(dataSplit[14]);
                                    Program.bridgeData.memberIndex = Convert.ToInt16(dataSplit[15]);
                                    Program.bridgeData.materialPropertiesIndex = Convert.ToInt16(dataSplit[16]);
                                }

                                i++;
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: An Error Has Occured Whilst Loading"+e);
            }
        }
    }
}
