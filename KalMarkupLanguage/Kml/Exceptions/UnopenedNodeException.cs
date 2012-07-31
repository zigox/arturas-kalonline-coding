using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ArturasServer.KalOnline.Kml.Exceptions
{
    [Serializable]
    public class UnopenedNodeException : Exception
    {
        public UnopenedNodeException(CharPosition Position)
            : base("Unopened node at Line " + Position.Row + ", Col " + Position.Column)
        {
            this.Data.Add("Position", Position);
        }
    }
}
