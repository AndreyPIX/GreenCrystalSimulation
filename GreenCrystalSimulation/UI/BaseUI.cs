using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GreenCrystalSimulation
{
    public class BaseUI : Object
    {
        protected MouseState mouseState = Mouse.GetState();
        protected Object[] puppets;
        public BaseUI(Texture2D texture) : base(texture){}
        
    }
}
