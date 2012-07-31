using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Kml;

namespace KalOnlineConfigs
{
    public class Serializer
    {
        public KmlNode Serialize(string RootName, ConfigPropertyGroup Group)
        {
            //create node
            KmlNode parent = new KmlNode();
            //add rootname to values
            parent.Values.Add(new KmlValue(RootName));

            //get fields
            FieldInfo[] fields = Group.GetType().GetFields();

            //cycle each field
            foreach (FieldInfo fi in fields)
            {
                object value = fi.GetValue(Group);
                Type type = fi.FieldType;
                Type baseType = fi.FieldType.BaseType;

                //check if its a config property
                if (baseType.Equals(typeof(ConfigProperty)) && value != null)
                {
                    //add field name
                    KmlNode kNode = new KmlNode(parent);
                    kNode.Values.Add(new KmlValue(fi.Name));

                    //Console.WriteLine(fi.Name);

                    //get values from inside field
                    FieldInfo[] fields2 = type.GetFields();

                    foreach(FieldInfo fi2 in fields2)
                    {
                        object value2 = fi2.GetValue(value);
                        Type type2 = fi2.FieldType;
                        Type baseType2 = fi2.FieldType.BaseType;

                       // Console.WriteLine("type: " + type2);
                        //enum
                        if (baseType2.Equals(typeof(Enum)))
                        {
                            //Console.WriteLine("-e" + (int)value2);
                            kNode.Values.Add(new KmlValue((int)value2));
                        }
                        //string
                        else if(type2.Equals(typeof(System.String)))
                        {
                            //Console.WriteLine("-s" + value2);
                            kNode.Values.Add(new KmlValue(value2.ToString(), true));
                        }
                        //bool
                        else if (type2.Equals(typeof(System.Boolean)))
                        {
                            //Console.WriteLine("-b" + value2);
                            bool bval = (bool)value2;
                            if (bval)
                            {
                                kNode.Values.Add(new KmlValue(1));
                            }
                            else
                            {
                                kNode.Values.Add(new KmlValue(0));
                            }
                        }
                        else
                        {
                            //Console.WriteLine("--" + value2);
                            kNode.Values.Add(new KmlValue(value2));
                        }
                    }

                }

                //check if its a group
                if (fi.FieldType.BaseType.Equals(typeof(ConfigPropertyGroup)))
                {
                    
                    //serialize the group and add it to parent
                    parent.ChildNodes.Add(Serialize(fi.Name, (ConfigPropertyGroup)fi.GetValue(Group)));
                }
          
            }

            return parent;
        }

        public void Deserialize(ConfigPropertyGroup Output, KmlNode Node)
        {
            Type obj = (Type)Activator.CreateInstance(Type);
        }

    }
}
