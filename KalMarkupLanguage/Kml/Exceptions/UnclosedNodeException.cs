using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ArturasServer.KalOnline.Kml.Exceptions
{
    [Serializable]
    public class UnclosedNodeException : Exception
    {
        public UnclosedNodeException(CharPosition Position)
            : base("Unclosed node at Line " + Position.Row + ", Col " + Position.Column)
        {
            this.Data.Add("Position", Position);
        }
    }
}
