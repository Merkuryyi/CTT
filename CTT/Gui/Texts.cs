using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace CTT
{
    public class Texts : BaseElements
    {
        private SFML.Graphics.Text textElement;

        protected Font FontElement;
        protected uint SizeText;
        public Color TextColor;
        protected string TextBox;

        public Texts(int x, int y, Font fontElement, uint sizeText, Color textColor, string textBox)
         
        {
            FontElement = fontElement;
            SizeText = sizeText;
            TextColor = textColor;
            TextBox = textBox;

            textElement = new SFML.Graphics.Text(textBox, fontElement);
            textElement.CharacterSize = sizeText;
            textElement.FillColor = textColor;
            textElement.Position = new Vector2f(x, y);
        }

        public override void Draw(RenderWindow _window)
        {
            _window.Draw(textElement);
        }
        

        public FloatRect GetGlobalBounds()
        {
            return textElement.GetGlobalBounds();
        }

        public bool IsPressed(Vector2i mousePosition)
        {
            return textElement.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y);
        }
        public void SetText(string newText)
        {
            
            textElement.DisplayedString = newText;
        }
        
        public void SetColor(Color newColor)
        {
            textElement.FillColor = newColor;
        }
        public void HideText(string newText)
        {
            string hiddenText = new string('*', newText.Length);
            SetText(hiddenText); 
        }
        public void SetPosition(int x, int y)
        {
            textElement.Position = new Vector2f(x, y); 
        }

       
    }
}