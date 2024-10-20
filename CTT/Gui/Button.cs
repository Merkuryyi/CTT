using SFML.Graphics;
using SFML.System;

namespace CTT;

public class Button : BaseElements
{
    public Button(int x, int y, Texture textureElement)
    {
        
        X = x;
        Y = y;
        TextureElement = textureElement;
        spriteElement = new Sprite(textureElement);
        spriteElement.Position = new Vector2f(x, y); 
    
        

    }
        
    public override void Draw(RenderWindow _window)
    {
        _window.Draw(spriteElement);
 
    }
    public FloatRect GetGlobalBounds()
    {
        return spriteElement.GetGlobalBounds();
    }


    public bool IsPressed(Vector2i mousePosition)
    {
        return spriteElement.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y);
    }
    
    
    public void SetTexture(Texture newTextureElement)
    {
        TextureElement = newTextureElement; 
        spriteElement.Texture = newTextureElement;
    }
   
    
}