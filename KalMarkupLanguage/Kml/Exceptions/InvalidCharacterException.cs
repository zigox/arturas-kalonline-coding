using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using ArturasServer.KalOnline.Kml;

namespace ArturasServer.KalOnline.Kml.Exceptions
{
    [Serializable]
    public class InvalidCharacterException : Exception
    {
        public InvalidCharacterException(char c, CharPosition Position)
            : base("Invalid character '" + c + "' at Line " + Position.Row + ", Col " + Position.Column)
        {
            this.Data.Add("Character", c);
            this.Data.Add("Position", Position);
        }
    }
}
