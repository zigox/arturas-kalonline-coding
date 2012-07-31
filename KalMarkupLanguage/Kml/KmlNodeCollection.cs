using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ArturasServer.KalOnline.Kml
{
    [Serializable]
    public class KmlNodeCollection : CollectionBase
    {
        private KmlNode _Parent;

        /// <summary>
        /// Creates a new collection with no parent.
        /// </summary>
        public KmlNodeCollection()
        {
            this.Parent = null;
        }

        /// <summary>
        /// Creates a new collection with the specified parent.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public KmlNodeCollection(KmlNode parent)
        {
            this.Parent = parent;
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

                _Parent = value;

                if (_Parent != null)
                {
                    _Parent.ChildNodes = this;
                }
            }
        }

        public KmlNode this[int index]
        {
            get { return (KmlNode)List[index]; }
            set { List[index] = value; }
        }

        /// <summary>
        /// Adds an item to the collection.
        /// </summary>
        /// <param name="item">The item to add to the collection.</param>
        /// <returns></returns>
        public KmlNode Add(KmlNode item)
        {
            List.Add(item);
            item.Parent = Parent;
            return item;
        }

        /// <summary>
        /// Adds a range of items to the collection
        /// </summary>
        /// <param name="range">The range of values to add to the collection.</param>
        public void AddRange(KmlNode[] range)
        {
            foreach (KmlNode value in range)
            {
                List.Add(value);
                value.Parent = Parent;
            }
        }

        /// <summary>
        /// Adds another collection to this collection.
        /// </summary>
        /// <param name="collection">The collection the add.</param>
        public void AddCollection(KmlNodeCollection collection)
        {
            foreach (KmlNode value in collection)
            {
                List.Add(value);
                value.Parent = Parent;
            }
        }

        /// <summary>
        /// Sets the item at the specified index in the collection.
        /// </summary>
        /// <param name="index">The index to set.</param>
        /// <param name="item">The item to set.</param>
        public void Set(int index, KmlNode item)
        {
            List[index] = item;
            item.Parent = Parent;
        }

        /// <summary>
        /// Removes the item from the collection.
        /// </summary>
        /// <param name="item"></param>
        public void Remove(KmlNode item)
        {
            if (List.Contains(item))
            {
                List.Remove(item);
                item.Parent = null;
            }
        }

        /// <summary>
        /// Checks if the collection contains the specified item.
        /// </summary>
        /// <param name="item">The item to check for.</param>
        /// <returns></returns>
        public bool Contains(KmlNode item)
        {
            return List.Contains(item);
        }

        /// <summary>
        /// Gets the index of the specified item.
        /// </summary>
        /// <param name="item">The item to get the index of.</param>
        /// <returns></returns>
        public int IndexOf(KmlNode item)
        {
            return List.IndexOf(item);
        }

        /// <summary>
        /// Returns the collection as an array.
        /// </summary>
        /// <returns></returns>
        public KmlNode[] ToArray()
        {
            List<KmlNode> items = new List<KmlNode>();
            foreach (KmlNode item in List)
            {
                items.Add(item);
            }
            return items.ToArray();
        }

        /// <summary>
        /// Copies the collection to an array starting at a specified index.
        /// </summary>
        /// <param name="array">The array to copy the collection to.</param>
        /// <param name="index">The index to start copying from.</param>
        public void CopyTo(KmlNode[] array, int index)
        {
            List.CopyTo(array, index);
        }
        
        /// <summary>
        /// Gets the collections enumerator.
        /// </summary>
        /// <returns></returns>
        public new IEnumerator GetEnumerator()
        {
            return List.GetEnumerator();
        }

        /// <summary>
        /// Checks if the collection contains a key (first value of each node).
        /// </summary>
        /// <param name="key">The key to search for</param>
        /// <returns></returns>
        public bool ContainsKey(string key)
        {
            foreach (KmlNode kNode in this)
            {
                if (String.Compare(kNode.FirstValue.Value, key, true) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns a deep-copy of the collection.
        /// </summary>
        /// <returns></returns>
        public KmlNodeCollection Clone(KmlNode parent)
        {
            KmlNodeCollection newCollection = new KmlNodeCollection(parent);
            foreach (KmlNode item in List)
            {
                newCollection.Add(item.Clone());
            }

            return newCollection;
        }

       
    }
}
