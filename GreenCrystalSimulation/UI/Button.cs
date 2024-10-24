using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GreenCrystalSimulation
{
    public class Button : Object
    {
        private bool click;
        public Button(Texture2D texture) : base(texture)
        {
            this.texture = texture;
        }
        public override void Update(GameTime gameTime)
        {

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
        private void Do()
        {

        }
    }
}
