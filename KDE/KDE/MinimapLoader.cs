using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using KalOnline.SwordCrypt;

namespace ArturasServer.KalOnline.DataEditor
{
    static class MinimapLoader
    {
        public static string mapDirectory = @"J:\Kal Online\Client Files\data\HyperText\MiniMap";
        public static Minimap World = new Minimap("World");
        public static Minimap Dungeon = new Minimap("Dungeons");

        public static void LoadMaps()
        {
            foreach (FileInfo fi in new DirectoryInfo(mapDirectory).GetFiles("*.gtx", SearchOption.AllDirectories))
            {
                ConvertToDDS(fi.FullName);
            }

            //world tiles

            World.Tiles.Add(new MinimapTile(26, 28, "minimap_n_e_155"));
            World.Tiles.Add(new MinimapTile(28, 28, "minimap_n_e_156"));
            World.Tiles.Add(new MinimapTile(30, 28, "minimap_n_e_157"));
            World.Tiles.Add(new MinimapTile(32, 28, "minimap_n_e_158"));
            World.Tiles.Add(new MinimapTile(34, 28, "minimap_n_e_159"));

            World.Tiles.Add(new MinimapTile(26, 26, "minimap_n_e_170"));
            World.Tiles.Add(new MinimapTile(28, 26, "minimap_n_e_171"));
            World.Tiles.Add(new MinimapTile(30, 26, "minimap_n_e_172"));
            World.Tiles.Add(new MinimapTile(32, 26, "minimap_n_e_173"));
            World.Tiles.Add(new MinimapTile(34, 26, "minimap_n_e_174"));

            //dungeon tiles

            Dungeon.Tiles.Add(new MinimapTile(0, 0, "minimap_Dungeon_tomb_002"));
            Dungeon.Tiles.Add(new MinimapTile(0, 2, "minimap_Dungeon_tomb_01_000"));
        }

        private static byte[] DecodeGTX(byte[] bytes)
        {
            bytes[0] = Convert.ToByte('D');
            bytes[1] = Convert.ToByte('D');
            bytes[2] = Convert.ToByte('S');
            for (int i = 7; i < 64; i++)
            {
                bytes[i] = SwordCrypter.DecodeByte(0x04, bytes[i]);
            }
            return bytes;
        }

        public static void ConvertToDDS(string fileName)
        {
            FileInfo fi = new FileInfo(fileName);

            if (!Directory.Exists(@"Cache\Maps"))
            {
                Directory.CreateDirectory(@"Cache\Maps");
            }

            string newName = @"Cache\Maps\" + fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length) + ".dds";

            File.WriteAllBytes(newName, DecodeGTX(File.ReadAllBytes(fileName)));
        }
    }
}
