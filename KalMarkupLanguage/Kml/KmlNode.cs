using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ArturasServer.KalOnline.Kml
{
    [Serializable]
    public class KmlNode
    {
        //child nodes
        public KmlNodeCollection ChildNodes;
        //values that the node holds
        public KmlValueCollection Values;
        //parent node
        private KmlNode _Parent;
        //comments
        public List<KmlComment> Comments = new List<KmlComment>();

        //start position in source
        public CharPosition StartPosition;
        public CharPosition EndPosition;

        public KmlNode()
        {
            this.Parent = null;
            ChildNodes = new KmlNodeCollection(this);
            Values = new KmlValueCollection(this);
        }

        public KmlNode(CharPosition StartPosition)
        {
            this.StartPosition = StartPosition;
            ChildNodes = new KmlNodeCollection(this);
            Values = new KmlValueCollection(this);
        }

        public KmlNode(CharPosition StartPosition, CharPosition EndPosition)
        {
            this.StartPosition = StartPosition;
            this.EndPosition = EndPosition;
            ChildNodes = new KmlNodeCollection(this);
            Values = new KmlValueCollection(this);
        }

        /// <summary>
        /// Gets or sets the parent node.
        /// </summary>
        public KmlNode Parent
        {
            get
            {
                return _Parent;
            }
            set
            {
                if (value == _Parent)
                {
                    return;
                }

                if (_Parent != null)
                {
                    _Parent.ChildNodes.Remove(this);
                }

                if (value != null && !value.ChildNodes.Contains(this))
                {
                    value.ChildNodes.Add(this);
                }

                _Parent = value;
            }
        }

        /// <summary>
        /// Returns the first value, if there is no value, null will be returned.
        /// </summary>
        public KmlValue FirstValue
        {
            get
            {
                 if (Values.Count > 0)
                 {
                     return Values[0];
                 }
                 return null;
            }
        }

        /// <summary>
        /// Deletes the node and all sub-nodes.
        /// </summary>
        public void Delete()
        {
            foreach (KmlNode knode in ChildNodes)
            {
                knode.Delete();
            }

            if (Parent != null)
            {
                this.Parent.ChildNodes.Remove(this);
            }
            
        }

        /// <summary>
        /// Gets the depth of the node.
        /// </summary>
        public int Depth
        {
            get
            {
                int depth = 0;
                KmlNode node = this;
                while (node.Parent != null)
                {
                    node = node.Parent;
                    depth++;
                }

                return depth;
            }
        }
        
        /// <summary>
        /// Balances the depth with spaces.
        /// </summary>
        /// <returns></returns>
        private string DepthBalance()
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 1; j < Depth; j++)
            {
                sb.Append("	");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            //comments
            
            foreach (KmlComment comment in Comments)
            {
                sb.Append(DepthBalance()); 
                sb.Append(";" + comment.Value + "\r\n");
            }

            int CurrentDepth = this.Depth;

            //balance depth
            sb.Append(DepthBalance());      

            sb.Append("(");

            //values
            int i = 0;
            foreach (KmlValue value in Values)
            {
                if (value.Comments.Count > 0)
                {
                    sb.Append("\r\n");
                    foreach (KmlComment comment in value.Comments)
                    {
                        sb.Append(DepthBalance()); 
                        sb.Append(";" + comment.Value + "\r\n");
                        sb.Append(DepthBalance()); 
                    }
                }

                sb.Append(value.ValueAsString);
                if (i != Values.Count - 1)
                {
                    sb.Append(" ");
                }
                i++;
                if (value.Comments.Count > 0)
                {
                    
                    sb.Append("\r\n");
                    sb.Append(DepthBalance()); 
                }
            }

            if (this.ChildNodes.Count > 0)
            {
                sb.Append("\r\n");
            }

            foreach (KmlNode node in ChildNodes)
            {
                sb.Append(" ");
                sb.Append(node.ToString());
            }

            if (this.ChildNodes.Count > 0)
            {
                //balance depth
                sb.Append(DepthBalance());
            }

            sb.Append(")\r\n");

            return sb.ToString();
        }

        /// <summary>
        /// Returns true if there are any child nodes whose first value is the name.
        /// </summary>
        /// <param name="Name">The first value to check.</param>
        /// <returns></returns>
        public bool ContainsNode(string name)
        {
            KmlNode[] kcoll = SelectNodes(name);
            if (kcoll.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Merges the node with the target node.
        /// </summary>
        /// <param name="target">The target to merge with.</param>
        public void Merge(KmlNode target)
        {
            if (target == null || target == this)
            {
                return;
            }

            //merge values
            for(int i = this.Values.Count; i < target.Values.Count; i++)
            {
                this.Values.Add(target.Values[i]);
               // MessageBox.Show(target.Values[i].Value);
            }

            List<KmlNode> subNodesToAdd = new List<KmlNode>();
            //match first values that are not numeric

            foreach (KmlNode targetSubNode in target.ChildNodes)
            {
                //merge current subnodes
                foreach (KmlNode subNode in this.ChildNodes)
                {
                    //if it is numeric then it is probably an array.
                    if (targetSubNode.FirstValue.IsNumeric)
                    {
                        if (subNode.FirstValue.IsNumeric)
                        {
                            //they are both numeric so we can merge the values
                            subNode.Merge(targetSubNode);
                        }
                    }
                    else
                    {
                        //check if the subnodes have the same key
                        if (targetSubNode.FirstValue.Value == subNode.FirstValue.Value)
                        {
                            //merge them
                            //MessageBox.Show(targetSubNode.FirstValue.Value);
                            subNode.Merge(targetSubNode);
                        }
                    }
                }

                //for subnodes that don't exist
                if (!this.ChildNodes.ContainsKey(targetSubNode.FirstValue.Value))
                {
                    subNodesToAdd.Add(targetSubNode);
                }
            }

            foreach (KmlNode kNode in subNodesToAdd)
            {
                this.ChildNodes.Add(kNode);
            }

            //we have stolen any nodes needed from target, now we kill the target.
            target.ChildNodes.Clear();
        }

        /// <summary>
        /// Selects all nodes with the KML path.
        /// </summary>
        /// <param name="Path">The path of the nodes to select.</param>
        /// <returns></returns>
        public KmlNode[] SelectNodes(string Path)
        {
            return KmlNodeSelector.SelectNodes(this, Path);
        }

        /// <summary>
        /// Selects a single node.
        /// </summary>
        /// <param name="Path">The path of the node.</param>
        /// <returns></returns>
        public KmlNode SelectSingleNode(string Path)
        {
            KmlNode[] kcoll = KmlNodeSelector.SelectNodes(this, Path);
            return kcoll[0]; 
        }

        public KmlNode Clone()
        {
            KmlNode newNode = new KmlNode(StartPosition.Clone(), EndPosition.Clone());
            
            newNode.ChildNodes = ChildNodes.Clone(newNode);
            newNode.Values = Values.Clone(newNode);
            newNode.Values.Parent = newNode;

            if (StartPosition != null)
            {
                newNode.StartPosition = StartPosition.Clone();
            }
            if (EndPosition != null)
            {
                newNode.EndPosition = EndPosition.Clone();
            }

            //comments
            foreach (KmlComment comment in Comments)
            {
                newNode.Comments.Add(comment.Clone());
            }

            return newNode;
        }
    }
}
