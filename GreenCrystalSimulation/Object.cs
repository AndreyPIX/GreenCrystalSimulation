using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Object
{
	protected Texture2D texture;
	protected Vector2 position;
	protected Rectangle? sourseRectangle;
	protected Color color;
	protected float rotation;
    protected Vector2 origin;
    protected Vector2 scale;

	protected bool visibleActive;

	protected int id;

    public Object(Texture2D texture)
	{
		this.texture = texture;
        position = new Vector2(0);
		sourseRectangle = null;
        color = Color.White;
        rotation = 0;
        origin = Vector2.Zero;
		scale = new Vector2(1);

		visibleActive = true;
    }
	public virtual void Update(GameTime gameTime)
	{
		if (visibleActive)
		{

		}
	}
	public virtual void Draw(SpriteBatch spriteBatch)
	{
        if (visibleActive)
        {
            spriteBatch.Draw(texture, position, sourseRectangle, color, rotation, origin, scale, SpriteEffects.None, 1);
        }
	}
}
