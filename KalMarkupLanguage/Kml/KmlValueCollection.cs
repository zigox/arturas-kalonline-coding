using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ArturasServer.KalOnline.Kml
{
    [Serializable]
    public class KmlValueCollection : CollectionBase
    {
        private KmlNode _Parent;

        /// <summary>
        /// Creates a new collection with no parent.
        /// </summary>
        public KmlValueCollection()
        {
            this.Parent = null;
        }

        /// <summary>
        /// Creates a new collection with the specified parent.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public KmlValueCollection(KmlNode parent)
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
                    _Parent.Values = this;
                }
            }
        }

        public KmlValue this[int index]
        {
            get { return (KmlValue)List[index]; }
            set { List[index] = value; }
        }

        /// <summary>
        /// Adds an item to the collection.
        /// </summary>
        /// <param name="item">The item to add to the collection.</param>
        /// <returns></returns>
        public KmlValue Add(KmlValue item)
        {
            List.Add(item);
            item.Parent = Parent;
            return item;
        }

        /// <summary>
        /// Adds a range of items to the collection
        /// </summary>
        /// <param name="range">The range of values to add to the collection.</param>
        public void AddRange(KmlValue[] range)
        {
            foreach (KmlValue value in range)
            {
                List.Add(value);
                value.Parent = Parent;
            }
        }

        /// <summary>
        /// Adds another collection to this collection.
        /// </summary>
        /// <param name="collection">The collection the add.</param>
        public void AddCollection(KmlValueCollection collection)
        {
            foreach (KmlValue value in collection)
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
        public void Set(int index, KmlValue item)
        {
            List[index] = item;
            item.Parent = Parent;
        }

        /// <summary>
        /// Removes the item from the collection.
        /// </summary>
        /// <param name="item"></param>
        public void Remove(KmlValue item)
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
        public bool Contains(KmlValue item)
        {
            return List.Contains(item);
        }

        /// <summary>
        /// Gets the index of the specified item.
        /// </summary>
        /// <param name="item">The item to get the index of.</param>
        /// <returns></returns>
        public int IndexOf(KmlValue item)
        {
            return List.IndexOf(item);
        }

        /// <summary>
        /// Returns the collection as an array.
        /// </summary>
        /// <returns></returns>
        public KmlValue[] ToArray()
        {
            List<KmlValue> items = new List<KmlValue>();
            foreach (KmlValue item in List)
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
        public void CopyTo(KmlValue[] array, int index)
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
        /// Checks if the collection contains the specified value.
        /// </summary>
        /// <param name="value">The key to check for</param>
        /// <returns></returns>
        public bool ContainsValue(string value)
        {
            foreach (KmlValue kmlValue in this)
            {
                if (String.Compare(kmlValue.Value, value, true) == 0)
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
        public KmlValueCollection Clone(KmlNode parent)
        {
            KmlValueCollection newCollection = new KmlValueCollection(parent);

            foreach (KmlValue value in List)
            {
                newCollection.Add(value.Clone());
            }

            return newCollection;
        }

       
    }
}
