using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharekalItemUpdate
{
    public class Server
    {
        public virtual int SID { get; set; }
        public virtual string Name { get; set; }
        public virtual string IP { get; set; }
        public virtual int Port { get; set; }
        public virtual string kal_db { get; set; }
        public virtual int Closed { get; set; }
        public virtual int Default { get; set; }

        public override string ToString()
        {
            if (Default == 1)
            {
                return SID + ": " + Name + " (Default)";
            }
            else
            {
                return SID + ": " + Name;
            }
            
        }
    }
}
