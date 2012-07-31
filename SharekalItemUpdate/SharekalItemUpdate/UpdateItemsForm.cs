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
using Kml;

namespace SharekalItemUpdate
{
    public partial class UpdateItemsForm : Form
    {
        
        string InitItem = "";
        string MessageE = "";

        Dictionary<int, string> ItemNames;
        Dictionary<int, string> ItemDescriptions;

        public UpdateItemsForm()
        {
            InitializeComponent();

            //for debugging
            MessageE = @"J:\Kal Online\message-e.txt";
            InitItem = @"J:\Kal Online\Server\Config\InitItem.txt";
        }


        private void openInitItemButton_Click(object sender, EventArgs e)
        {
            openInitItemDialog.ShowDialog();
        }

        private void openMessageEButton_Click(object sender, EventArgs e)
        {
            openMessageEDialog.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, maybe you need to clear your item table first!");
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Done!");
        }

        private void openMessageEDialog_FileOk(object sender, CancelEventArgs e)
        {
            MessageE = openMessageEDialog.FileName;
            updateButton.Enabled = true;
        }

        private void openInitItemDialog_FileOk(object sender, CancelEventArgs e)
        {
            InitItem = openInitItemDialog.FileName;
            openMessageEButton.Enabled = true;
        }

        private void UpdateItems()
        {
            KmlDocument kdoc = new KmlDocument();
            kdoc.LoadFromFile(MessageE);
            kdoc.LoadFromFile(InitItem);

            ItemNames = new Dictionary<int, string>();
            ItemDescriptions = new Dictionary<int, string>();

            //load item names
            foreach (KmlNode knode in kdoc.SelectNodes("itemname"))
            {
                int Index = knode.Values[1].ValueAsInt;
                string Name = knode.Values[2].Value;

                if (!ItemNames.ContainsKey(Index))
                {
                    ItemNames.Add(Index, Name);
                }
            }

            //load prefix names
            using (ISession session = Database.Factory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    foreach (KmlNode knode in kdoc.SelectNodes("prefixname"))
                    {
                        int Index = knode.Values[1].ValueAsInt;
                        string Name = knode.Values[2].Value;
                        Prefix prefix = new Prefix();
                        prefix.Index = Index;
                        prefix.Name = Name;
                        session.SaveOrUpdate(prefix);
                    }
                    transaction.Commit();
                }
            }
            //load item descriptions
            foreach (KmlNode knode in kdoc.SelectNodes("itemdesc"))
            {
                int Index = knode.Values[1].ValueAsInt;
                string Name = knode.Values[2].Value;

                if (!ItemDescriptions.ContainsKey(Index))
                {
                    ItemDescriptions.Add(Index, Name);
                }
            }

            //delete current items

            //load items

            using (ISession session = Database.Factory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {

                    foreach (KmlNode knode in kdoc.SelectNodes("item"))
                    {

                        int Index = knode.SelectSingleNode("index").Values[1].ValueAsInt;
                        int NameIndex = knode.SelectSingleNode("name").Values[1].ValueAsInt;

                        //description
                        int DescIndex = -1;
                        if (knode.ContainsNode("desc"))
                        {
                            DescIndex = knode.SelectSingleNode("desc").Values[1].ValueAsInt;
                        }

                        string Icon = knode.SelectSingleNode("image").Values[1].Value;
                        string Class = knode.SelectSingleNode("class").Values[1].Value;
                        string SubClass = knode.SelectSingleNode("class").Values[2].Value;
                        int Code1 = knode.SelectSingleNode("code").Values[1].ValueAsInt;
                        int Code2 = knode.SelectSingleNode("code").Values[2].ValueAsInt;
                        int Code3 = knode.SelectSingleNode("code").Values[3].ValueAsInt;
                        int Code4 = knode.SelectSingleNode("code").Values[4].ValueAsInt;

                        byte Endurance = 0;
                        if (knode.ContainsNode("endurance"))
                        {
                            Endurance = (byte)knode.SelectSingleNode("endurance").Values[1].ValueAsInt;
                        }

                        int Grade = 0;
                        if (knode.ContainsNode("level"))
                        {
                            Grade = knode.SelectSingleNode("level").Values[1].ValueAsInt;
                        }

                        //limit
                        int ClassLimit = -1;
                        int LevelLimit = -1;
                        if (knode.ContainsNode("limit"))
                        {

                            LevelLimit = knode.SelectSingleNode("limit").Values[2].ValueAsInt;

                            switch (knode.SelectSingleNode("limit").Values[2].Value.ToLower())
                            {
                                case "knight":
                                    ClassLimit = 0;
                                    break;
                                case "archer":
                                    ClassLimit = 2;
                                    break;
                                case "mage":
                                    ClassLimit = 1;
                                    break;
                            }
                        }

                        Item item = new Item();

                        item.Index = Index;
                        if (ItemNames.ContainsKey(NameIndex))
                        {
                            item.Name = ItemNames[NameIndex];
                        }
                        if (ItemDescriptions.ContainsKey(DescIndex))
                        {
                            item.Description = ItemDescriptions[DescIndex];
                        }

                        item.Icon = Icon;
                        item.Class = Class;
                        item.SubClass = SubClass;
                        item.Code1 = Code1;
                        item.Code2 = Code2;
                        item.Code3 = Code3;
                        item.Code4 = Code4;
                        item.Grade = Grade;
                        item.LevelLimit = LevelLimit;
                        item.ClassLimit = ClassLimit;
                        item.Endurance = Endurance;

                        session.SaveOrUpdate(item);

                    }

                    transaction.Commit();
                }
            
            }
        }
    }
}
