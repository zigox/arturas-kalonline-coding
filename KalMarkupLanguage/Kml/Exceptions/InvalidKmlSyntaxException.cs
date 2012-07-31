using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ArturasServer.KalOnline.Kml.Exceptions
{
    [Serializable]
    public class InvalidKmlSyntaxException : Exception
    {
        public InvalidKmlSyntaxException(CharPosition Position, Exception innerException)
            : base("Invalid KML Syntax at position: " + Position,innerException)
        {
            this.Data.Add("Position", Position);
        }
    }
}
