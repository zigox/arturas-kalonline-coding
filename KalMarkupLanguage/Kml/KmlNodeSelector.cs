using System;
using System.Collections.Generic;
using System.Text;
using ArturasServer.KalOnline.Kml.Exceptions;

namespace ArturasServer.KalOnline.Kml
{
    public static class KmlNodeSelector
    {
        public static KmlNode[] SelectNodes(KmlNode ParentNode, string Path)
        {
            //check that the path is not blank
            if (Path != "")
            {
                List<KmlNode> SelectedNodes = new List<KmlNode>();
                string[] nodeNames = Path.Split('/');
                foreach (KmlNode kNode in ParentNode.ChildNodes)
                {
                    if (String.Compare(kNode.FirstValue.Value, nodeNames[0], true) == 0 && nodeNames.Length == 1)
                    {
                        SelectedNodes.Add(kNode);
                        //MessageBox.Show("Ad1");

                    }
                    if (nodeNames.Length > 1)
                    {
                        //MessageBox.Show(GetNextPath(nodeNames));
                        SelectedNodes.AddRange(SelectNodes(kNode, GetNextPath(nodeNames)));
                    }
                }
                return SelectedNodes.ToArray();
            }
            else
            {
                throw new InvalidKmlPathException(Path);
            }
        }

        public static string GetNextPath(string[] nodeNames)
        {
            string str = "";
            int i = 1;
            while(i < nodeNames.Length)
            {
                str += nodeNames[i] + "/";
                i++;
            }
            str = str.Substring(0, str.Length - 1);
            //MessageBox.Show(str);
            return str;
        }
    }
}
