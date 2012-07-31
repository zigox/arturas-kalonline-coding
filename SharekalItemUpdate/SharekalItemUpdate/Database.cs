using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using System.Windows.Forms;

namespace SharekalItemUpdate
{
    public static class Database
    {
        public static ISessionFactory Factory;

        public static void LoadFactory()
        {
            Configuration cfg = new Configuration().Configure("Database.cfg.xml");

            //load resources
            cfg.AddResource(@"SharekalItemUpdate.Item.hbm.xml", System.Reflection.Assembly.GetExecutingAssembly());
            cfg.AddResource(@"SharekalItemUpdate.ShopItem.hbm.xml", System.Reflection.Assembly.GetExecutingAssembly());
            cfg.AddResource(@"SharekalItemUpdate.Server.hbm.xml", System.Reflection.Assembly.GetExecutingAssembly());
            cfg.AddResource(@"SharekalItemUpdate.Prefix.hbm.xml", System.Reflection.Assembly.GetExecutingAssembly());

            try
            {
                Factory = cfg.BuildSessionFactory();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                System.Environment.Exit(0);
            }

        }

        public static void Close()
        {
            Factory.Close();
        }
    }
}
