using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArturasServer.KalOnline.Kml;
using ArturasServer.KalOnline.Kml.ObjectMapping;
using ArturasServer.KalOnline.DataEditor.ObjectClasses;
using System.Windows.Forms;

namespace ArturasServer.KalOnline.DataEditor
{
    [Serializable]
    public class DataFile
    {
        public string FileName = "";
        public bool Saved = true;
        public string Name = "Unknown data file.";

        public delegate void DataFileLoadedEventHandler();

        public DataFile()
        {
        }

        public DataFile(string name, string fileName)
        {
            this.Name = name;
            this.FileName = fileName;
        }

        public List<ObjectClass> ObjectClasses()
        {
            var selectedObjectClasses =
                    from o in ObjectClassManager.ObjectClasses
                    where o.DataFile == this
                    select o;

            return selectedObjectClasses.ToList<ObjectClass>();
        }

        public List<ObjectClass> Load()
        {
            KmlDocument kmlDocument = new KmlDocument();
            kmlDocument.LoadFromFile(FileName);

            List<ObjectClass> objectClasses = new List<ObjectClass>();

            foreach (KmlNode node in kmlDocument.ChildNodes)
            {
                //get first key from each node
                string key = node.Values[0].Value;
                //get type
                if (ObjectClassManager.ObjectTypes.ContainsKey(key))
                {
                    Type type = ObjectClassManager.ObjectTypes[key];
                    //load value
                    ObjectClass objectClass = (ObjectClass)ObjectClassManager.ObjectMapper.Load(node, type);
                    objectClass.DataFile = this;
                    objectClasses.Add(objectClass);
                }
            }

            return objectClasses;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
