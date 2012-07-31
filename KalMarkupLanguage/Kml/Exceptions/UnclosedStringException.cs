using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using ArturasServer.KalOnline.Kml;

namespace ArturasServer.KalOnline.Kml.Exceptions
{
    [Serializable]
    public class UnclosedStringException : Exception
    {
        public UnclosedStringException(CharPosition Position)
            : base("Invalid unclosed string starting at Line " + Position.Row + ", Col " + Position.Column)
        {
            this.Data.Add("Position", Position);
        }
    }
}
