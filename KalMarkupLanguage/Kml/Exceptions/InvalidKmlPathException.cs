using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ArturasServer.KalOnline.Kml.Exceptions
{
    [Serializable]
    public class InvalidKmlPathException : Exception
    {
        public InvalidKmlPathException(string Path)
            : base("Invalid Kml Path: '" + Path + "'")
        {
            this.Data.Add("Path", Path);
        }
    }
}
