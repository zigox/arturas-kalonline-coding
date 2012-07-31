using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using AlphaSubmarines;

namespace ArturasServer.KalOnline.DataEditor
{
    class MinimapTile
    {
        public int X;
        public int Y;
        public string Name;
        public Texture2D Texture;

        public MinimapTile(int x, int y, string name)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
        }

        public void LoadTexture(GraphicsDevice GraphicsDevice)
        {
            DDSLib.DDSFromFile(@"Cache\Maps\" + Name + ".dds", GraphicsDevice, true, out Texture);
        }
    }
}
