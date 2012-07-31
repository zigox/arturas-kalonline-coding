using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharekalItemUpdate
{
    class ShopItemListViewItem : ListViewItem
    {
        public ShopItem ShopItem;

        public ShopItemListViewItem(ShopItem shopItem)
        {
            this.ShopItem = shopItem;
            UpdateText();
        }

        public void UpdateText()
        {
            this.SubItems.Clear();
            
            //Index
            this.Text = ShopItem.Index.ToString();
            //Name
            this.SubItems.Add(ShopItem.GetItem().Name);
            //Num
            this.SubItems.Add(ShopItem.Num.ToString());
            //Cost
            this.SubItems.Add(ShopItem.Cost.ToString());
            //Category
            this.SubItems.Add(ShopItem.Category);
        }
    }
}
