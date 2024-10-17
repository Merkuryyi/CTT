namespace CTT;
using SFML.Graphics;
using SFML.System;
public class Text: BaseElements
{
    
    protected Font FontElement;
    protected int SizeText;
    protected Color TextColor;
    
    protected string TextBox;


    public Text(int x, int y, Font fontElement, int sizeText, Color textColor, string textBox)
    {
        
        X = x;
        Y = y;
        
        
        FontElement = fontElement;
        SizeText = sizeText;
        TextColor = textColor;
        TextBox = textBox;
        textElement.Position = new Vector2f(x, y);
        textElement = new Text(x, y, fontElement, sizeText, textColor, textBox);
        textElement.TextColor = (textColor);
        
        
        
        


    }

    

    public override void Draw(RenderWindow _window)
    {
    
        _window.Draw(textElement);
        
        
    }
    public FloatRect GetGlobalBounds()
    {
        return spriteElement.GetGlobalBounds();
    }


    public bool IsPressed(Vector2i mousePosition)
    {
        return spriteElement.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y);
    }
    
}