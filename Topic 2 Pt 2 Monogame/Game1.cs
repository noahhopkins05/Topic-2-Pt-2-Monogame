using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Topic_2_Pt_2_Monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D white_square;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 640;
            _graphics.PreferredBackBufferHeight = 640;
            _graphics.ApplyChanges();

            this.Window.Title = "Topic 2 Pt 2";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            white_square = Content.Load<Texture2D>("white_square");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();



            GraphicsDevice.Clear(Color.Black);
            for (int coords_x = 0; coords_x < _graphics.PreferredBackBufferWidth; coords_x += 160)
            {
                for (int coords_y = 0; coords_y < _graphics.PreferredBackBufferHeight; coords_y += 160)
                {
                    _spriteBatch.Draw(white_square, new Rectangle(coords_x, coords_y, 80, 80), Color.White);
                }
            }
            for (int coords_x = 80; coords_x < _graphics.PreferredBackBufferWidth; coords_x += 160)
            {
                for (int coords_y = 80; coords_y < _graphics.PreferredBackBufferHeight; coords_y += 160)
                {
                    _spriteBatch.Draw(white_square, new Rectangle(coords_x, coords_y, 80, 80), Color.White);
                }
            }

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
