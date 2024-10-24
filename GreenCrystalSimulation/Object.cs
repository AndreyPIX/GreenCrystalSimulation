using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public class Object
{
	protected Texture2D texture;
	protected Vector2 position;
	protected Rectangle? sourseRectangle;
	protected Color color;
	protected float rotation;
    protected Vector2 origin;
    protected Vector2 scale;

	private int id;

    public Object(Texture2D texture)
	{
		this.texture = texture;
        position = new Vector2(0);
		sourseRectangle = null;
        color = Color.White;
        rotation = 0;
        origin = Vector2.Zero;
		scale = new Vector2(1);
    }
	public virtual void Update(GameTime gameTime)
	{

	}
	public virtual void Draw(SpriteBatch spriteBatch)
	{
		spriteBatch.Draw(texture, position, sourseRectangle, color, rotation, origin, scale, SpriteEffects.None, 1);
	}
}
