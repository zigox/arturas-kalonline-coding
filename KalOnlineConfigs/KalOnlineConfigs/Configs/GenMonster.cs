using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KalOnlineConfigs.Configs._GenMonster;

namespace KalOnlineConfigs.Configs
{
    public class GenMonster : ConfigPropertyGroup
    {
        /// <summary>
        /// Monster index.
        /// </summary>
        public Number Index;
        /// <summary>
        /// Map to spawn monster on.
        /// </summary>
        public Number Map;
        /// <summary>
        /// Unique Index.
        /// </summary>
        public Number Area;
        /// <summary>
        /// Maximum spawn count.
        /// </summary>
        public Number Max;
        /// <summary>
        /// Delay between spawns.
        /// </summary>
        public Number Cycle;
        /// <summary>
        /// Monster spawn location.
        /// </summary>
        public Rect Rect;
    }
}
