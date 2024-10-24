using GreenCrystalSimulation.ProceduralGeneration;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GreenCrystalSimulation
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Object crystal;
        private Button startButton;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            crystal = new Object(TextureGenerator.GenerateSquare(graphics.GraphicsDevice, 16, pixel => Color.Green));
            startButton = new Button(TextureGenerator.GenerateRectangle(graphics.GraphicsDevice, 32, 16, pixel => Color.Gray));
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            crystal.Draw(spriteBatch);
            startButton.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
        /* Личные заметки
           добаление кнопки Start при нажатии кнопка изщезает при нажатии и начинается игра (Пусть отрисовываются объекты и их действия)
         */
    }
}
