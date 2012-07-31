using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharekalItemUpdate
{
    public class Item
    {
        public virtual int Index { get; set; }
        public virtual string Name { get; set; }
        public virtual string Icon { get; set; }
        public virtual string Class { get; set; }
        public virtual string SubClass { get; set; }
        public virtual int Code1 { get; set; }
        public virtual int Code2 { get; set; }
        public virtual int Code3 { get; set; }
        public virtual int Code4 { get; set; }
        public virtual int LevelLimit { get; set; }
        public virtual int ClassLimit { get; set; }
        public virtual string Description { get; set; }
        public virtual int Grade { get; set; }
        public virtual byte Endurance { get; set; }

        public override string ToString()
        {
            return Index + ": " + Name + ", Grade " + Grade + " " + Class + " " + SubClass;
        }
    }
}
