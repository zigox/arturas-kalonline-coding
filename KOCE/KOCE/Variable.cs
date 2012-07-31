using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KOCE
{
    [Serializable]
    public class Variable
    {
        public string Key, Value;

        public Variable(string Key, string Value)
        {
            this.Key = Key;
            this.Value = Value;
        }

        public override string ToString()
        {
            return Key + ": " + Value;
        }
    }
}
