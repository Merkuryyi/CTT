using SFML.Graphics;
using SFML.System;
namespace CTT;

public class Texts : BaseElements
{
    private Text textElement;
    public Texts(int x, int y, Font fontElement, uint sizeText, Color textColor, string textBox)
    {
        textElement = new Text(textBox, fontElement);
        textElement.CharacterSize = sizeText;
        textElement.FillColor = textColor;
        textElement.Position = new Vector2f(x, y);
    }
    public override void Draw(RenderWindow _window)
    { _window.Draw(textElement); }
    public FloatRect GetGlobalBounds()
    { return textElement.GetGlobalBounds(); }
    public void SetText(string newText)
    { textElement.DisplayedString = newText; }
    public bool IfTexts(string texts)
    { return textElement.DisplayedString == texts; }
    public string GetTextString()
    { return textElement.DisplayedString; }
    public void SetColor(Color newColor)
    { textElement.FillColor = newColor; }
    public void HideText(string newText)
    {
        string hiddenText = new string('*', newText.Length);
        SetText(hiddenText); 
    }
    public void SetPosition(int x, int y)
    { textElement.Position = new Vector2f(x, y); }
}
