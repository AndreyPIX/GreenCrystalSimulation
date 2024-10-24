using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCrystalSimulation
{
    public class BaseUI : Object
    {
        protected MouseState mouseState = Mouse.GetState();
        public BaseUI(Texture2D texture) : base(texture){}
    }
}
