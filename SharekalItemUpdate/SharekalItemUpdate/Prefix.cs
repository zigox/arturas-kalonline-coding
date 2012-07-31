using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharekalItemUpdate
{
    public class Prefix
    {
        public virtual int Index { get; set; }
        public virtual string Name { get; set; }

        public override string ToString()
        {
            return Index + ": " + Name;
        }
    }
}
