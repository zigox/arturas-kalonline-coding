using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace ArturasServer.KalOnline.DataEditor.ObjectClasses
{
    public class MapRegion
    {
        private int _X1;
        private int _Y1;
        private int _X2;
        private int _Y2;

        public MapRegion()
        {
        }

        public MapRegion(int x1, int y1, int x2, int y2)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }

        public Microsoft.Xna.Framework.Rectangle XNARectangle
        {
            get
            {
                return new Microsoft.Xna.Framework.Rectangle(X1, Y1, X2 - X1, Y2 - Y1);
            }
        }

        public override string ToString()
        {
            return "Edit Spawn Location";
        }

        [CategoryAttribute("Location")]
        public int X1
        {
            get { return _X1; }
            set { _X1 = value; }
        }

        [CategoryAttribute("Location")]
        public int Y1
        {
            get { return _Y1; }
            set { _Y1 = value; }
        }

        [CategoryAttribute("Location")]
        public int X2
        {
            get { return _X2; }
            set { _X2 = value; }
        }

        [CategoryAttribute("Location")]
        public int Y2
        {
            get { return _Y2; }
            set { _Y2 = value; }
        }
    }
}
