using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kml;

namespace KalOnlineConfigs.Configs
{
    public class String : ConfigProperty
    {
        public string Value;

        public String(string Value)
        {
            this.Value = Value;
        }
    }
}
