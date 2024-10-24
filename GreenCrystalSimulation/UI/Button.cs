using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

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
            base.Update(gameTime);
            
        }
        private void Do()
        {

        }
    }
}
