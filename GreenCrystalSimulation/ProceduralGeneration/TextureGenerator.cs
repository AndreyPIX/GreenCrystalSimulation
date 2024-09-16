
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GreenCrystalSimulation.ProceduralGeneration
{
    public class TextureGenerator
    {
        GraphicsDeviceManager graphics;
        public TextureGenerator()
        {

        }

        public Texture2D GenaratePixel(Color color)
        {
            Color[] colors;
            Texture2D texture;
            return texture;
        }
        private Color[] FillColors(Color color)
        {
            Color[] colors;
            for (int i = 0; i > 0; i++)
            {
                colors[i] = color;
            }
            return colors;
        }
    }
}
