using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace Kml.KmlObjectMapping
{
    class ClassMap
    {
        public Node Node;
        public Type ClassType;

        public ClassMap(Type ClassType)
        {
            this.ClassType = ClassType;
        }

        public static ClassMap FromXML(XmlNode xnode)
        {
            string className = xnode.Attributes["class"].Value;
            ClassMap classMap = new ClassMap(Type.GetType(className));

            classMap.Node = LoadNode(xnode.SelectSingleNode("node"));

            return classMap;
        }

        private static Node LoadNode(XmlNode xnode)
        {
            
            Node node = new Node();

            XmlNodeList xnodeNodeList = xnode.SelectNodes("node");

            foreach (XmlNode nodeXnode in xnodeNodeList)
            {
                node.Nodes.Add(LoadNode(nodeXnode));
            }

            XmlNodeList xnodeValueList = xnode.SelectNodes("value");

            foreach (XmlNode valueXnode in xnodeValueList)
            {
                node.Values.Add(LoadValue(valueXnode));
            }

            XmlNodeList xnodeNodeListList = xnode.SelectNodes("nodelist");

            foreach (XmlNode nodeListXnode in xnodeNodeListList)
            {
                node.NodeLists.Add(LoadNodeList(nodeListXnode));
            }

            return node;
        }

        private static NodeList LoadNodeList(XmlNode xnode)
        {
            Type type = null;
            if (xnode.Attributes["type"] != null)
            {
                type = Type.GetType(xnode.Attributes["type"].Value);
            }

            string name = xnode.InnerText;

            NodeList nodeList = new NodeList(name, type);

            return nodeList;
        }

        private static Value LoadValue(XmlNode xnode)
        {
            bool capture = false;

            Type type = null;
            if (xnode.Attributes["type"] != null)
            {
                type = Type.GetType(xnode.Attributes["type"].Value);
                capture = true;
            }

            bool list = false;
            if (xnode.Attributes["list"] != null)
            {
                list = Convert.ToBoolean(xnode.Attributes["list"].Value);
            }

            string defaultValue = "";
            if (xnode.Attributes["default"] != null)
            {
                defaultValue = xnode.Attributes["default"].Value;
            }

            if (xnode.Attributes["capture"] != null)
            {
                capture = Convert.ToBoolean(xnode.Attributes["capture"].Value);
            }

            string name = xnode.InnerText;

            Value value = new Value(name);
            value.Capture = capture;
            value.Type = type;
            value.DefaultValue = defaultValue;
            value.List = list;

            return value;
        }
    }
}
