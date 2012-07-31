using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace ArturasServer.KalOnline.DataEditor
{
    [Serializable]
    public class Project
    {
        public string Name;

        public List<DataFile> DataFiles = new List<DataFile>();
        public List<DataPack> DataPacks = new List<DataPack>();

        /// <summary>
        /// Saves the project to a file.
        /// </summary>
        /// <param name="fileName">File to save the project to.</param>
        public void Save(string fileName)
        {
            XmlSerializer ser = new XmlSerializer(this.GetType());
            TextWriter writer = new StreamWriter(new FileStream(fileName, FileMode.OpenOrCreate));
            ser.Serialize(writer, this);
        }

        /// <summary>
        /// Loads a project from a file.
        /// </summary>
        /// <param name="fileName">File to load the project from.</param>
        /// <returns></returns>
        public static Project Load(string fileName)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Project));
            return (Project)ser.Deserialize(new FileStream(fileName, FileMode.OpenOrCreate));
        }
    }
}
