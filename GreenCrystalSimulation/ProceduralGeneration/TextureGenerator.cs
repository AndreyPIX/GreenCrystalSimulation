
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Linq;

namespace GreenCrystalSimulation.ProceduralGeneration
{
    public class TextureGenerator
    {
        public static Texture2D GenerateSquare(GraphicsDevice graphics, int size, Func<int, Color> paint)
        {
            Texture2D texture = new Texture2D(graphics, size, size);
            Color[] data = new Color[size * size];
            for (int pixel = 0; pixel < data.Count(); pixel++)
                data[pixel] = paint(pixel);
            texture.SetData(data);
            return texture;
        }
        public static Texture2D GenerateRectangle(GraphicsDevice graphics, int width, int height, Func<int, Color> paint)
        {
            Texture2D texture = new Texture2D(graphics, width, height);
            Color[] data = new Color[width * height];
            for (int pixel = 0; pixel < data.Count(); pixel++)
                data[pixel] = paint(pixel);
            texture.SetData(data);
            return texture;
        }
    }
}
