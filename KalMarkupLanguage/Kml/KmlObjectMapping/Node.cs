using System;
using System.Collections.Generic;
using System.Text;

namespace Kml.KmlObjectMapping
{
    class Node
    {
        public List<Value> Values = new List<Value>();
        public List<NodeList> NodeLists = new List<NodeList>();
        public List<NodeList> ValueLists = new List<NodeList>();
        public List<Node> Nodes = new List<Node>();
    }
}
