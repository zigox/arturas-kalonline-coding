using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArturasServer.KalOnline.DataEditor
{
    class Minimap
    {
        public List<MinimapTile> Tiles = new List<MinimapTile>();
        public string Name;

        public Minimap(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
