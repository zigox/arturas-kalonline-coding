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
    public static class ObjectClassManager
    {
        public static Dictionary<string, Type> ObjectTypes = new Dictionary<string, Type>();
        public static List<DataFile> DataFiles = new List<DataFile>();
        public static ObjectMapper ObjectMapper = new ObjectMapper();
        public static DataFileLoader DataFileLoader = new DataFileLoader();
        public static List<ObjectClass> ObjectClasses = new List<ObjectClass>();

        public static void LoadObjectMaps()
        {
            //ObjectMapper.AddClassMapFromXml(Utilities.GetResourceTextFile("ObjectClasses.Monster.xml"));
            //ObjectMapper.AddClassMapFromXml(Utilities.GetResourceTextFile("ObjectClasses.MonsterName.xml"));
            //ObjectMapper.AddClassMapFromXml(Utilities.GetResourceTextFile("ObjectClasses.GenMonster.xml"));
            //ObjectMapper.AddClassMapFromXml(Utilities.GetResourceTextFile("ObjectClasses.ItemName.xml"));
            //ObjectMapper.AddClassMapFromXml(Utilities.GetResourceTextFile("ObjectClasses.ItemDesc.xml"));

            ObjectMapper.SaveAllClassMaps(@"C:\KDEClassMaps");
        }

        public static void AddDataFile(DataFile dataFile)
        {
            DataFiles.Add(dataFile);
        }

        public static void LoadDataFiles()
        {
            foreach (DataFile dataFile in DataFiles)
            {
                ObjectClasses.AddRange(dataFile.Load());
            }
        }

        public static void LoadDataFilesAsync()
        {
            DataFileLoader.LoadDataFilesAsync(DataFiles);
        }
    }
}
