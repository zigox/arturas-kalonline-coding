using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ArturasServer.KalOnline.DataEditor.ObjectClasses
{
    public class ItemDesc : ObjectClass
    {
        private Int32 _Index;
        private String _Value;

        public override Dictionary<string, ObjectClass> GetLinks
        {
            get
            {
                return base.GetLinks;
            }
        }

        public override string ToString()
        {
            return Value;
        }

        [CategoryAttribute("System")]
        public Int32 Index
        {
            get { return _Index; }
            set { _Index = value; }
        }

        [CategoryAttribute("Display")]
        public String Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
    }
}
