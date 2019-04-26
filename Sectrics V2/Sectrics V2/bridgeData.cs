using System;
using System.Collections.Generic;
using System.Text;

namespace Sectrics_V2
{
    public class Nodes
    {
        public double NodeX { get; set; }
        public double NodeY { get; set; }
    }

    public class connectedMembers
    {
        public int toConnection { get; set; }
        public int fromConnection { get; set; }
    }
    public class forces
    {
        public double xMagnitudeForces { get; set; }
        public double yMagnitudeForces { get; set; }
    }
    public class degreesOfFreedom
    {
        public int xDegreeOfFreedom { get; set; }
        public int yDegreesOfFreedom { get; set; }
    }
    class BridgeData
    {
        public List<string> supportType = new List<string>();
        public List<int> supportNode = new List<int>();
        public List<Nodes> nodes = new List<Nodes>();
        public List<degreesOfFreedom> degreesOfFreedom = new List<degreesOfFreedom>();
        public List<connectedMembers> memberConnection = new List<connectedMembers>();
        public List<int> restrainedDegreesOfFreedom = new List<int>();
        public List<forces> forces = new List<forces>();
        public List<double> stiffness = new List<double>();
        public List<double> areas = new List<double>();
        public int ndof;

        public int nodesIndex = 0;
        public int memberIndex = 0;
        public int materialPropertiesIndex = 0;
    }
}
