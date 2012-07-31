using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kml;

namespace KalOnlineConfigs.Configs
{
    public class Number : ConfigProperty
    {
        public int Value;

        public Number(int Value)
        {
            this.Value = Value;
        }

    }
}
