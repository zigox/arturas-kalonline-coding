using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Reflection;
using Kml;
using System.Windows.Forms;

namespace Kml.KmlObjectMapping
{
    public class ObjectMapper
    {
        List<ClassMap> ClassMaps = new List<ClassMap>();

        /// <summary>
        /// Adds any class maps contained in an XML file.
        /// </summary>
        /// <param name="fileName">XML file.</param>
        public void AddClassMapFromFile(string fileName)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(fileName);

            AddClassMapFromXmlDocument(xdoc);
        }

        /// <summary>
        /// Adds any class maps contained within XML source.
        /// </summary>
        /// <param name="xml">XML source.</param>
        public void AddClassMapFromXml(string xml)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xml);

            AddClassMapFromXmlDocument(xdoc);
        }

        /// <summary>
        /// Adds any class maps inside an XML document.
        /// </summary>
        /// <param name="xmlDocument">XML Document</param>
        public void AddClassMapFromXmlDocument(XmlDocument xmlDocument)
        {
            //add each classmap inside the document.
            foreach (XmlNode xnode in xmlDocument.SelectNodes("classmaps/classmap"))
            {
                ClassMap classMap = ClassMap.FromXML(xnode);
                ClassMaps.Add(classMap);
            }
        }

        /// <summary>
        /// Returns the class map for the corresponding type.
        /// </summary>
        /// <param name="ClassType">The type to search for.</param>
        /// <returns></returns>
        private ClassMap GetClassMap(Type ClassType)
        {
            foreach (ClassMap classMap in ClassMaps)
            {
                if (classMap.ClassType == ClassType)
                {
                    return classMap;
                }
            }
            return null;
        }

        /// <summary>
        /// Loads a single object from the KML Node as a defined type.
        /// </summary>
        /// <typeparam name="T">The object type returned</typeparam>
        /// <param name="kNode">The KML node to load from.</param>
        /// <returns></returns>
        public T Load<T>(KmlNode kNode)
        {
            return (T)Load(kNode, typeof(T));
        }

        /// <summary>
        /// Loads a signle object from the KML Node as an object type.
        /// </summary>
        /// <param name="kNode">The KML node to load from</param>
        /// <param name="type">The type of object to load.</param>
        /// <returns></returns>
        public object Load(KmlNode kNode, Type type)
        {
            ClassMap classMap = GetClassMap(type);

            if (classMap == null)
            {
                throw new Exception("Unable to find class map for type: " + type);
            }

            object obj = Activator.CreateInstance(classMap.ClassType);

            LoadNode(kNode, classMap.Node, obj);

            return obj;
        }

        /// <summary>
        /// Loads a list of objects from an array of KmlNodes.
        /// </summary>
        /// <typeparam name="T">The type of object to be contained in the list</typeparam>
        /// <param name="nodes">An array of KML nodes to load from.</param>
        /// <returns></returns>
        public List<T> LoadList<T>(KmlNode[] nodes)
        {
            List<T> objects = new List<T>();
            foreach (KmlNode kNode in nodes)
            {
                objects.Add(Load<T>(kNode));
            }
            return objects;
        }

        private void LoadNode(KmlNode kmlNode, Node node, object outputObject)
        {
            Type type = outputObject.GetType();

            //capture values
            int i = 0;
            foreach (Value value in node.Values)
            {
                //check if we need to capture the value
                if (value.Capture)
                {
                    if (value.List)
                    {
                        //get the list object
                        PropertyInfo propertyInfo = type.GetProperty(value.Name);
                        object listObject = propertyInfo.GetValue(outputObject, null);
                        //enumerate the remaining values and add to list
                        while (i < kmlNode.Values.Count)
                        {
                            //now add the value
                            listObject.GetType().GetMethod("Add").Invoke(listObject, new object[] { Convert.ChangeType(kmlNode.Values[i].Value, value.Type) });
                            i++;
                        }
                        break;
                    }
                    else
                    {
                        if (kmlNode.Values.Count > i)
                        {
                            //set the field to the value
                            PropertyInfo propertyInfo = type.GetProperty(value.Name);
                            if (propertyInfo == null)
                            {
                                throw new Exception("Unable to find field: " + value.Name);
                            }
                            propertyInfo.SetValue(outputObject, Convert.ChangeType(kmlNode.Values[i].Value, value.Type), null);
                            
                        }
                    }
                }
                else
                {
                    //check if we are in the correct node to capture.
                    if (value.Name != kmlNode.Values[i].Value)
                    {
                        return;
                    }
                }
                i++;
            }

            //do nodes
            foreach (KmlNode kmlSubNode in kmlNode.ChildNodes)
            {
                //capture each node list
                foreach (NodeList nodeList in node.NodeLists)
                {
                    //get the list object
                    PropertyInfo propertyInfo = type.GetProperty(nodeList.Name);
                    object listObject = propertyInfo.GetValue(outputObject, null);
                    //now add the value
                    listObject.GetType().GetMethod("Add").Invoke(listObject, new[] { Load(kmlSubNode, nodeList.Type) });
                }

                //do the same for each sub node
                foreach (Node subNode in node.Nodes)
                {
                    LoadNode(kmlSubNode, subNode, outputObject);
                }
            }
        }

        /// <summary>
        /// Saves the object into KML.
        /// </summary>
        /// <param name="inputObject">The object to save.</param>
        /// <returns></returns>
        public KmlNode Save(object inputObject)
        {
            Type type = inputObject.GetType();
            ClassMap classMap = GetClassMap(type);

            if (classMap == null)
            {
                throw new Exception("Unable to find class map for type: " + type);
            }

            KmlNode kmlNode = new KmlNode();
            SaveNode(classMap.Node, kmlNode, inputObject);

            return kmlNode;
        }

        /// <summary>
        /// Saves an array of objects to an array of KML Nodes.
        /// </summary>
        /// <param name="inputObjects">An array of objects to save.</param>
        /// <returns></returns>
        public KmlNode[] SaveArray(object[] inputObjects)
        {
            List<KmlNode> savedNodes = new List<KmlNode>();
            foreach (object inputObject in inputObjects)
            {
                savedNodes.Add(Save(inputObject));
            }
            return savedNodes.ToArray();
        }

        private object GetPropertyValue(string field, object subject)
        {
            return subject.GetType().GetProperty(field).GetValue(subject, null);
        }

        private void SaveNode(Node node, KmlNode kmlNode, object inputObject)
        {
            //save all values
            bool discardNode = true;
            foreach (Value value in node.Values)
            {
                if (value.Capture)
                {
                    if (value.List)
                    {
                        //load the list
                        object list = GetPropertyValue(value.Name, inputObject);

                        //place into an array
                        Array array = (Array)list.GetType().GetMethod("ToArray").Invoke(list, new object[] { });

                        foreach (object arrayItem in array)
                        {
                            kmlNode.Values.Add(new KmlValue(arrayItem.ToString()));
                            discardNode = false;
                        }
                    }
                    else
                    {
                        string fieldValue = GetPropertyValue(value.Name, inputObject).ToString();
                        if (fieldValue != value.DefaultValue)
                        {
                            discardNode = false;
                            kmlNode.Values.Add(new KmlValue(fieldValue));
                        }
                    }
                }
                else
                {
                    kmlNode.Values.Add(new KmlValue(value.Name));
                }
            }

            //save node lists
            foreach (NodeList nodeList in node.NodeLists)
            {
                discardNode = false;
                //load the list
                object list = GetPropertyValue(nodeList.Name, inputObject);
                
                //place into an array
                object[] array = (object[])list.GetType().GetMethod("ToArray").Invoke(list, new object[] { });

                foreach (object arrayItem in array)
                {
                    kmlNode.ChildNodes.Add(Save(arrayItem));
                }
            }

            //save any sub nodes
            foreach (Node subNode in node.Nodes)
            {
                discardNode = false;
                KmlNode subKmlNode = new KmlNode(kmlNode);
                SaveNode(subNode, subKmlNode, inputObject);
            }

            if (discardNode)
            {
                kmlNode.Delete();
            }
        }

    }
}
