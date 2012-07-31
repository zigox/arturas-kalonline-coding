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
    public partial class EditShopItemsForm : Form
    {
        public EditShopItemsForm()
        {
            InitializeComponent();
            Database.LoadFactory();
            LoadItems();
            LoadServers();
        }

        public void LoadItems()
        {
            itemsListBox.Items.Clear();

            using (ISession session = Database.Factory.OpenSession())
            {
                IQuery query = session.CreateQuery("FROM Item");
                itemsListBox.Items.AddRange(query.List<Item>().ToArray());
            }

        }

        public void LoadServers()
        {
            using (ISession session = Database.Factory.OpenSession())
            {
                serverComboBox.Items.Clear();
                IQuery query = session.CreateQuery("FROM Server");
                serverComboBox.Items.AddRange(query.List<Server>().ToArray());
            }
        }

        public void LoadShopItems(int SID)
        {
            using (ISession session = Database.Factory.OpenSession())
            {
                shopItemsListView.Items.Clear();
                IQuery query = session.CreateQuery("FROM ShopItem WHERE SID = " + SID);
                foreach (ShopItem shopItem in query.List<ShopItem>())
                {
                    shopItemsListView.Items.Add(new ShopItemListViewItem(shopItem));
                }
            }

        }

        private void updateItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateItemsForm form = new UpdateItemsForm();
            form.ShowDialog();
            LoadItems();
        }

        private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server selectedServer = (Server)serverComboBox.SelectedItem;
            LoadShopItems(selectedServer.SID);
        }

        private void itemsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedItem != null)
            {
                if (serverComboBox.SelectedItem != null)
                {
                    Item selectedItem = (Item)itemsListBox.SelectedItem;
                    ShopItem newShopItem = new ShopItem();

                    newShopItem.Index = selectedItem.Index;
                    newShopItem.Num = 1;
                    newShopItem.Prefix = 0;
                    newShopItem.MaxEnd = selectedItem.Endurance;
                    newShopItem.CurEnd = selectedItem.Endurance;
                    newShopItem.Category = "Misc";

                    Server selectedServer = (Server)serverComboBox.SelectedItem;

                    newShopItem.SID = selectedServer.SID;
                    using (ISession session = Database.Factory.OpenSession())
                    {
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.SaveOrUpdate(newShopItem);
                            transaction.Commit();
                        }
                    }
                    LoadShopItems(selectedServer.SID);
                }
                else
                {
                    MessageBox.Show("No server selected");
                }
            }
        }

        public void SaveSelectedObjects()
        {
            using (ISession session = Database.Factory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    foreach (ShopItem shopItem in shopItemsPropertyGrid.SelectedObjects)
                    {
                        session.SaveOrUpdate(shopItem);
                    }
                    transaction.Commit();
                }
            }
        }

        private void shopItemsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shopItemsListView.SelectedItems.Count > 0)
            {
                SaveSelectedObjects();
                //change to new selected objects
                List<ShopItem> selectedItems = new List<ShopItem>();
                foreach (ListViewItem listViewItem in shopItemsListView.SelectedItems)
                {
                    ShopItemListViewItem selectedShopItemListViewItem = (ShopItemListViewItem)listViewItem;
                    selectedItems.Add(selectedShopItemListViewItem.ShopItem);
                }
                shopItemsPropertyGrid.SelectedObjects = selectedItems.ToArray();
            }
            else
            {
                shopItemsPropertyGrid.SelectedObject = null;
            }
        }

        private void EditShopItemsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.Close();
        }

        private void shopItemsListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (shopItemsListView.SelectedItems.Count > 0)
                {
                    shopItemsPropertyGrid.SelectedObject = null;
                    using (ISession session = Database.Factory.OpenSession())
                    {
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            //remove selected list view items
                            foreach (ShopItemListViewItem shopItemListViewItem in shopItemsListView.SelectedItems)
                            {
                                shopItemsListView.Items.Remove(shopItemListViewItem);
                                session.Delete(shopItemListViewItem.ShopItem);
                            }
                            transaction.Commit();
                        }
                    }
                }
            }
        }

        private void shopItemsPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            SaveSelectedObjects();
            Server selectedServer = (Server)serverComboBox.SelectedItem;
            LoadShopItems(selectedServer.SID);
        }



    }
}
