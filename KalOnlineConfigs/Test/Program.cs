using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KalOnlineConfigs.Configs;
using KalOnlineConfigs;
using Kml;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //monster test
            GenMonster mon = new GenMonster();
            mon.Area = new Number(1);
            mon.Cycle = new Number(2);
            mon.Index = new Number(3);
            mon.Rect = new KalOnlineConfigs.Configs._GenMonster.Rect(10, 20, 30, 40);
            mon.Map = new Number(90);

            Serializer ser = new Serializer();

            KmlNode kNode = ser.Serialize("GenMonster", mon);

            Console.WriteLine();

            Console.WriteLine(kNode.ToString());

            //item test

            Item item = new Item();
            item.Index = new Number(1);
            item.Image = new KalOnlineConfigs.Configs.String("test\" string test");
            item.Specialty = new KalOnlineConfigs.Configs._Item.Specialty();
            item.Use = new KalOnlineConfigs.Configs.Boolean(true);
            item.Class = new KalOnlineConfigs.Configs._Item.Class(0, 1);
            item.Specialty.Teleport = new KalOnlineConfigs.Configs._Item._Specialty.Teleport(KalOnlineConfigs.Configs._Item._Specialty.TeleportType.Party, KalOnlineConfigs.Configs._Item._Specialty.TeleportLocation.Geum_Oh_Mine);
            item.Specialty.Attack = new KalOnlineConfigs.Configs._Item._Specialty.Attack(0, 20);

            kNode = ser.Serialize("Item", item);

            Console.WriteLine();

            Console.WriteLine(kNode.ToString());

            Console.Read();

            
        }
    }
}
