using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;

namespace SharekalItemUpdate
{
    public class ShopItem
    {
        [CategoryAttribute("Info"), DescriptionAttribute("Unique Shop Item ID"), ReadOnlyAttribute(true)]
        public virtual int SIID { get; set; }
        [CategoryAttribute("Info"), DescriptionAttribute("The index of the item to be sold.")]
        public virtual int Index { get; set; }
        [CategoryAttribute("Info"), DescriptionAttribute("How many of this item will be sold (stackable items only.)")]
        public virtual int Num { get; set; }
        [CategoryAttribute("Stats"), DescriptionAttribute("Talisman Index")]
        public virtual byte Prefix { get; set; }
        [CategoryAttribute("Stats"), DescriptionAttribute("Info")]
        public virtual int Info { get; set; }

        [CategoryAttribute("Stats"), DescriptionAttribute("Maximum item endurance. (defaulted to max from inititem.)")]
        public virtual byte MaxEnd { get; set; }
        [CategoryAttribute("Stats"), DescriptionAttribute("Current item endurance. (defaulted to max from inititem.)")]
        public virtual byte CurEnd { get; set; }
        [CategoryAttribute("Stats"), DescriptionAttribute("Set Gem")]
        public virtual byte SetGem { get; set; }
        [CategoryAttribute("Stats"), DescriptionAttribute("XAttack")]
        public virtual byte XAttack { get; set; }
        [CategoryAttribute("Stats"), DescriptionAttribute("XMagic")]
        public virtual byte XMagic { get; set; }
        [CategoryAttribute("Stats"), DescriptionAttribute("XDefense")]
        public virtual byte XDefense { get; set; }
        [CategoryAttribute("Stats"), DescriptionAttribute("XHit")]
        public virtual byte XHit { get; set; }
        [CategoryAttribute("Stats"), DescriptionAttribute("XDodge")]
        public virtual byte XDodge { get; set; }
        [CategoryAttribute("Stats"), DescriptionAttribute("Protect")]
        public virtual byte Protect { get; set; }
        [CategoryAttribute("Stats"), DescriptionAttribute("UpgrLevel")]
        public virtual byte UpgrLevel { get; set; }
        [CategoryAttribute("Stats"), DescriptionAttribute("UpgrRate")]
        public virtual byte UpgrRate { get; set; }

        [CategoryAttribute("Info"), DescriptionAttribute("Cost of the item in KalPoints.")]
        public virtual int Cost { get; set; }
        [CategoryAttribute("Info"), DescriptionAttribute("The Server ID of which this item will be sold on.")]
        public virtual int SID { get; set; }
        [CategoryAttribute("Info"), DescriptionAttribute("Description of what is being sold. (Seperate to Message-E item description.)")]
        public virtual string Description { get; set; }
        [CategoryAttribute("Info"), DescriptionAttribute("Category in which to sell this item on the site store.")]
        public virtual string Category { get; set; }

        public virtual Item GetItem()
        {
            using (ISession session = Database.Factory.OpenSession())
            {
                IQuery query = session.CreateQuery("FROM Item WHERE Index = " + Index);
                return query.UniqueResult<Item>();
            }
        }
    }
}
