using System;
using System.Collections.Generic;
using System.Text;

namespace ArturasServer.KalOnline.Kml
{
    [Serializable]
    public class CharPosition
    {
        public int Row, Column, Offset;

        public CharPosition(int Row, int Column, int Offset)
        {
            this.Row = Row;
            this.Column = Column;
            this.Offset = Offset;
        }

        public override string ToString()
        {
            return "Row " + this.Row + ", Column " + this.Column + ", Offset " + this.Offset;
        }

        public CharPosition Clone()
        {
            return (CharPosition)this.MemberwiseClone();
        }
    }
}
