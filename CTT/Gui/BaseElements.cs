using SFML.Graphics;
using SFML.System;


namespace CTT;

public abstract  class BaseElements
{
    
    protected int X { get; set; }
    protected int Y { get; set; }
    
    protected Texture TextureElement { get; set; }
    protected Sprite spriteElement { get; set; }
    protected Vector2f Position { get; set; }
    
    protected Text textElement  { get; set; }
   
    
    
    
    
    public abstract void Draw(RenderWindow _window);
    
    
    
    
    

}

 


