using System;
using System.Collections.Generic;
using System.Text;

namespace Kml.KmlObjectMapping
{
    class NodeList
    {
        public Type Type;
        public string Name;

        public NodeList(string name, Type type)
        {
            this.Name = name;
            this.Type = type;
        }
    }
}
