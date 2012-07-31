using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArturasServer.KalOnline.Kml.ObjectMapping;
using ArturasServer.KalOnline.Kml;

namespace KmlObjectMappingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectMapper mapper = new ObjectMapper();
            mapper.AddClassMapFromFile("Goods.xml");

            mapper.ClassMaps[0].ToXmlFile(@"C:\test.xml");
            mapper.ClassMaps[1].ToXmlFile(@"C:\test1.xml");

            mapper.ClassMaps.Clear();

            mapper.AddClassMapFromXmlFile(@"C:\test.xml");
            mapper.AddClassMapFromXmlFile(@"C:\test1.xml");

            Console.WriteLine(mapper.ClassMaps[1].ClassType.ToString());

            KmlDocument kdoc = new KmlDocument();
            kdoc.LoadFromFile("Goods.txt");

            //clone first node

            kdoc.ChildNodes.Add(kdoc.ChildNodes[0].Clone());

            List<Goods> goodsList = mapper.LoadList<Goods>(kdoc.SelectNodes("goods"));

            foreach (Goods goods in goodsList)
            {

               Console.WriteLine("Index: {0}", goods.Index);


                Console.WriteLine("Items =>");
                foreach (GoodsItem goodsItem in goods.Items)
                {
                    Console.WriteLine("   Value1: {0}", goodsItem.Value1);
                    Console.WriteLine("   Value2: {0}", goodsItem.Value2);
                    Console.WriteLine("   Value3: {0}", goodsItem.Value3);
                }
            }

            Console.WriteLine("KML > Object done.");

            Goods goods0 = goodsList[0];
            KmlNode goodsKml = mapper.Save(goods0);

            Console.WriteLine(goodsKml);

            Console.ReadLine();

        }
    }
}
