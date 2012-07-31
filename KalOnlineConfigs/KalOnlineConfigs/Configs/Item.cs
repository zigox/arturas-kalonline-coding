using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KalOnlineConfigs.Configs._Item;
using Kml;

namespace KalOnlineConfigs.Configs
{
    public class Item : ConfigPropertyGroup
    {
        /// <summary>
        /// Name index of the item.
        /// </summary>
        public Number Name;
        /// <summary>
        /// Unique item index.
        /// </summary>
        public Number Index;
        /// <summary>
        /// Icon used for the item (bitmap file without extension, relative to hypertext directory.
        /// </summary>
        public String Image;
        /// <summary>
        /// Determins which model will be used for the item.
        /// </summary>
        public _Item.Action Action;
        /// <summary>
        /// Icons for different animal stages.
        /// </summary>
        public ImageEx ImageEx;
        /// <summary>
        /// How much the item costs to buy from an NPC.
        /// </summary>
        public Number Buy;
        /// <summary>
        /// The type of item.
        /// </summary>
        public Class Class;
        /// <summary>
        /// 
        /// </summary>
        public Cocoon Cocoon;
        /// <summary>
        /// Determins the type of item.
        /// </summary>
        public Code Code;
        /// <summary>
        /// Cooldown time before the item can be used again in milliseconds.
        /// </summary>
        public Number Cooltime;
        /// <summary>
        /// Country the item is available in.
        /// </summary>
        public Country Country;
        /// <summary>
        /// Item description index.
        /// </summary>
        public Number Desc;
        /// <summary>
        /// Effect displayed when item is used.
        /// </summary>
        public Number Effect;
        /// <summary>
        /// Durability of item.
        /// </summary>
        public Number Endurance;
        /// <summary>
        /// Item grade.
        /// </summary>
        public Number Level;
        /// <summary>
        /// Limits the item to class/level.
        /// </summary>
        public Limit Limit;
        /// <summary>
        /// 
        /// </summary>
        public Number MaxProtect;
        /// <summary>
        /// 
        /// </summary>
        public Boolean Pay;
        /// <summary>
        /// Determins whether or not the item can be stacked.
        /// </summary>
        public Boolean Plural;
        /// <summary>
        /// The race to transform Numbero on item use.
        /// </summary>
        public Number Race;
        /// <summary>
        /// Attack range of item.
        /// </summary>
        public Number Range;
        /// <summary>
        /// Sell value to NPC.
        /// </summary>
        public Number Sell;
        /// <summary>
        /// Specialty values.
        /// </summary>
        public Specialty Specialty;
        /// <summary>
        /// 
        /// </summary>
        public STBuff STBuff;
        /// <summary>
        /// Determines if the item can be used.
        /// </summary>
        public Boolean Use;
        /// <summary>
        /// 
        /// </summary>
        public Boolean WarRelation;
    }
}
