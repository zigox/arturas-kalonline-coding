using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace KOCE
{
    class Serializer
    {
        public void SerializeObject(string FileName, Project Project)
        {
            Stream stream = File.Open(FileName, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, Project);
            stream.Close();
        }

        public Project DeSerializeObject(string FileName)
        {
            Project objectToSerialize;
            Stream stream = File.Open(FileName, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            objectToSerialize = (Project)bFormatter.Deserialize(stream);
            stream.Close();
            objectToSerialize.FileName = FileName;
            return objectToSerialize;
        }
    }
}
