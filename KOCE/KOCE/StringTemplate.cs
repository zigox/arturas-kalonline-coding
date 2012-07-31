using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KOCE
{
    class StringTemplate
    {
        public Dictionary<string, string> Replacements = new Dictionary<string, string>();

        public void Assign(object Key, object Value)
        {
            Replacements.Add(Key.ToString(), Value.ToString());
        }

        public void Assign(object Key, object[] Values, object Splitter)
        {
            StringBuilder sb = new StringBuilder();

            bool first = true;

            foreach (object obj in Values)
            {
                if (!first)
                {
                    sb.Append(Splitter.ToString());
                }
                first = false;
                sb.Append(obj.ToString());
            }

            Replacements.Add(Key.ToString(), sb.ToString());
        }

        public string GetOutput(string Input)
        {
            foreach (string Key in Replacements.Keys)
            {
                Input = Input.Replace("{" + Key + "}", Replacements[Key]);
            }

            return Input;
        }
    }
}
