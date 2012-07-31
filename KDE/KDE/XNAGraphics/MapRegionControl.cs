using System.Diagnostics;
using System.Windows.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;
using AlphaSubmarines;
using ArturasServer.KalOnline.DataEditor.ObjectClasses;

namespace ArturasServer.KalOnline.DataEditor.XNAGraphics
{
    using Keys = Microsoft.Xna.Framework.Input.Keys;

    class MapRegionControl : GraphicsDeviceControl
    {
        private bool IsMouseDown = false;

        private Vector2 LastMousePosition;

        private Vector3 CameraPosition;
        private float WorldScale = 0.5f;

        private Matrix ViewMatrix;
        private Matrix WorldMatrix;

        private ContentManager Content;
        private Texture2D RegionTexture;
        private SpriteFont WorldFont;


        private Minimap Minimap;
        public MapRegion MapRegion = new MapRegion(6834, 6856, 7012, 7060);

        protected override void Initialize()
        {
            Content = new ContentManager(Services, "Content");
            RegionTexture = Content.Load<Texture2D>("region");
            WorldFont = Content.Load<SpriteFont>("worldFont");

            CameraPosition = new Vector3(MapRegion.X1, MapRegion.Y1, 0);
            
            LoadMinimap(MinimapLoader.World);
           
            this.MouseDown += new MouseEventHandler(MapRegionControl_MouseDown);
            this.MouseUp += new MouseEventHandler(MapRegionControl_MouseUp);
            this.MouseMove += new MouseEventHandler(MapRegionControl_MouseMove);
            this.MouseWheel += new MouseEventHandler(MapRegionControl_MouseWheel);

            // Hook the idle event to constantly redraw our animation.
            Application.Idle += delegate { Invalidate(); };

            
        }

        public void LoadMinimap(Minimap Minimap)
        {
            this.Minimap = Minimap;
            //load tile textures
            foreach (MinimapTile tile in Minimap.Tiles)
            {
                tile.LoadTexture(GraphicsDevice);
            }
        }

        void MapRegionControl_MouseWheel(object sender, MouseEventArgs e)
        {
            WorldScale += e.Delta * (WorldScale / 1000);
        }

        void MapRegionControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                Vector2 worldMousePos = ScreenToWorld(new Vector2(LastMousePosition.X, LastMousePosition.Y)) - ScreenToWorld(new Vector2(e.X, e.Y));
                CameraPosition.X += worldMousePos.X;
                CameraPosition.Y += worldMousePos.Y;
            }
            LastMousePosition.X = e.X;
            LastMousePosition.Y = e.Y;
        }

        void MapRegionControl_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        void MapRegionControl_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            LastMousePosition.X = e.X;
            LastMousePosition.Y = e.Y;
        }

        private Vector2 ScreenToWorld(Vector2 clientPosition)
        {
            Vector2 position = clientPosition;
            position.X = ((position.X / Width) * 2) - 1;
            position.Y = ((position.Y / Height) * -2) + 1;

            Vector2 screenSize = new Vector2(Width, Height);

            Vector2 worldSpace = screenSize / WorldScale/2;

            position.X = position.X * worldSpace.X;
            position.Y = position.Y * worldSpace.Y;

            position.X += CameraPosition.X;
            position.Y += CameraPosition.Y;

            return position;
        }

        private Rectangle ClientToScreen(Rectangle rectangle)
        {
            rectangle.Y += rectangle.Height;
            rectangle.Y *= -1;

            return rectangle;
        }

        private Vector2 ClientToScreen(Vector2 vector2)
        {
            vector2.Y *= -1;

            return vector2;
        }

        private void UpdateView()
        {
            ViewMatrix = Matrix.CreateTranslation(new Vector3(CameraPosition.X, -CameraPosition.Y, 0));
            ViewMatrix = Matrix.Invert(ViewMatrix) * Matrix.CreateScale(WorldScale);
            WorldMatrix = Matrix.CreateWorld(new Vector3(Width/2, Height/2, 0), new Vector3(0, 0, -1), new Vector3(0, 1, 0));
        }

        private void UpdateInputs()
        {
            KeyboardState keyState = Keyboard.GetState();

            float speed = 5/WorldScale;

            if (keyState.IsKeyDown(Keys.W))
            {
                CameraPosition += new Vector3(0, speed, 0);
            }
            if (keyState.IsKeyDown(Keys.S))
            {
                CameraPosition += new Vector3(0, -speed, 0);
            }

            if (keyState.IsKeyDown(Keys.A))
            {
                CameraPosition += new Vector3(-speed, 0, 0);
            }

            if (keyState.IsKeyDown(Keys.D))
            {
                CameraPosition += new Vector3(speed, 0, 0);
            }

            if (keyState.IsKeyDown(Keys.Space))
            {
                WorldScale -= 10 * (WorldScale / 1000);
            }
            if (keyState.IsKeyDown(Keys.LeftControl))
            {
                WorldScale += 10 * (WorldScale / 1000);
            }
        }


        protected override void Draw()
        {
            try
            {
                UpdateInputs();
                UpdateView();
                GraphicsDevice.Clear(Color.Black);

                SpriteBatch worldSpriteBatch = new SpriteBatch(GraphicsDevice);
                SpriteBatch clientSpriteBatch = new SpriteBatch(GraphicsDevice);

                clientSpriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null);
                worldSpriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ViewMatrix * WorldMatrix);

                foreach (MinimapTile tile in Minimap.Tiles)
                {
                    Texture2D texture = tile.Texture;
                    worldSpriteBatch.Draw(texture, ClientToScreen(new Rectangle(tile.X * 256, tile.Y * 256, 256 *2, 256 * 2)), Color.White);
                    worldSpriteBatch.DrawString(WorldFont, String.Format("{0}, {1}", tile.X, tile.Y), ClientToScreen(new Vector2((tile.X * 256) + 30, (tile.Y * 256) + 50 )), Color.Red);

                }

                worldSpriteBatch.Draw(Content.Load<Texture2D>("region"), ClientToScreen(MapRegion.XNARectangle), Color.White);

                Vector2 mouseWorldPos = ScreenToWorld(new Vector2(LastMousePosition.X, LastMousePosition.Y));

                clientSpriteBatch.DrawString(Content.Load<SpriteFont>("hudFont"), string.Format("Camera Position: {0}, {1}", CameraPosition.X, CameraPosition.Y), new Vector2(8, Height - 24), Color.Blue);
                clientSpriteBatch.DrawString(Content.Load<SpriteFont>("hudFont"), string.Format("Scale: {0}", WorldScale), new Vector2(8, Height - 38), Color.Blue);
                clientSpriteBatch.DrawString(Content.Load<SpriteFont>("hudFont"), string.Format("Mouse Position: {0}, {1}", mouseWorldPos.X, mouseWorldPos.Y), new Vector2(9, Height - 52), Color.Blue);

                
                worldSpriteBatch.End();
                clientSpriteBatch.End();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

    }
}
