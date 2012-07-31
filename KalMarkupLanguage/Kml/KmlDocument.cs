using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ArturasServer.KalOnline.Kml
{
    public class KmlDocument : KmlNode
    {
        public void LoadFromFile(string FileName)
        {
            //create our reader
            KmlStreamReader kmlReader = new KmlStreamReader(new FileStream(FileName, FileMode.Open), this);
            kmlReader.Read();
        }

        public void LoadFromString(string Kml)
        {
            //put kml into a stream
            byte[] byteArray = Encoding.ASCII.GetBytes(Kml);
            MemoryStream stream = new MemoryStream(byteArray);

            //create the reader
            KmlStreamReader kmlReader = new KmlStreamReader(stream, this);
            kmlReader.Read();

            //close the stream
            stream.Close();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (KmlNode knode in this.ChildNodes)
            {
                sb.AppendLine(knode.ToString());
            }
            return sb.ToString();
        }

    }
}
