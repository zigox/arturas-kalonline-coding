using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ArturasServer.KalOnline.DataEditor.ObjectClasses
{
    public class ObjectClass
    {
        public DataFile DataFile;

        //for icon
        public virtual string ImageKey
        {
            get { return this.GetType().Name; }
        }

        [BrowsableAttribute(false)]
        public virtual Dictionary<string, ObjectClass> GetLinks
        {
            get { return new Dictionary<string, ObjectClass>(); }
        }
    }
}
