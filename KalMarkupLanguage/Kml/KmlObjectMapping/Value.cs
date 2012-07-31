using System;
using System.Collections.Generic;
using System.Text;

namespace Kml.KmlObjectMapping
{
    class Value
    {
        public bool Capture = false;
        public Type Type;
        public string Name;
        public string DefaultValue = "";
        public bool List;

        public Value(string Name)
        {
            this.Name = Name;
        }
    }
}
