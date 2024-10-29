using SFML.Graphics;
using SFML.Window;
using System.Text.RegularExpressions;

using SFML.System;
namespace CTT
{
    public class Line : BaseElements
    {
        
        public static string displayedText;
        private static bool flagP = false;
        
        
        private static Button Buttons;
        private static int Cursors = 0;
        public static string Lines = "";
        private static bool Flag = true;
        private static bool IsVisible = false;
       
        private SFML.Graphics.Text textElement;

        protected Font FontElement;
        protected uint SizeText;
        public Color TextColor;
        protected string TextBox;
        
        //  private static int x;
        public Line(int x, int y, Font fontElement, uint sizeText, Color textColor, string line, Button button, int cursors, bool flag, bool isVisible)
        {
            Buttons = button;
            Cursors = cursors;
            Lines = line;
            Flag = flag;
            
            FontElement = fontElement;
            SizeText = sizeText;
            TextColor = textColor;

            textElement = new SFML.Graphics.Text(line, fontElement);
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
        public void OnKeyPressedName(object sender, KeyEventArgs e)
        {
            
            Buttons = Frame2.buttonNameSprite;
         //   TextBox = Frame2.nameMiniText;
            Flag = Frame2.flagName;
            IsVisible = Frame2.isVisiblePassword;
          //  float textWidth = TextBox.GetGlobalBounds().Width;
         //   float buttonWidth = Buttons.GetGlobalBounds().Width;

            if (Flag)
            {
                HandleNavigationKeys(e);
                
                if ((Lines == Frame2.nameMiniTextFrame2
                     || Lines == Frame2.lMiniTextFrame2 ))
                {
                    HandleCharacterInput(e);
                }

                if ((Lines == Frame2.passwordMiniTextFrame2 
                           || Lines == Frame2.repeatPasswordMiniTextFrame2
                           || Lines == Frame2.emailMiniTextFrame2))
                {
                    HandleNumberInput(e);
                    HandleCharacterInput(e);
                }
               if ( Lines == Frame2.numberPhoneMiniTextFrame2 )
                          //|| Lines == Frame3.numberPhoneMiniTextFrame2 
                         // || Lines == Frame3.emailMiniTextFrame2 )
                {
                    HandleNumbersInput(e);
                }
                
               
                

                
            }
        }

        private void HandleNavigationKeys(KeyEventArgs e)
        { 
          
               switch (e.Code)
                {
                    case Keyboard.Key.BackSpace:
                        if (Cursors > 0)
                        {
                            Lines = Lines.Remove(Cursors - 1, 1);
                            Cursors--;
                        }
                        break;

                    case Keyboard.Key.Delete:
                        if (Cursors < Lines.Length)
                        {
                            Lines = Lines.Remove(Cursors, 1);
                        }
                        break;

                    case Keyboard.Key.Left:
                        if (Cursors > 0)
                        {
                            Cursors--;
                        }
                        break;

                    case Keyboard.Key.Right:
                        if (Cursors < Lines.Length)
                        {
                            Cursors++;
                        }
                        break;
                }
       
           
        }

        private void HandleCharacterInput(KeyEventArgs e)
        {
          
            
            float buttonWidth = Buttons.GetGlobalBounds().Width;
            if (System.Text.RegularExpressions.Regex.IsMatch(e.Code.ToString(), @"^[a-zA-Z]$"))
            {
                string charToAdd = Keyboard.IsKeyPressed(Keyboard.Key.LShift) || 
                                   Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? 
                                   e.Code.ToString().ToUpper() : 
                                   e.Code.ToString().ToLower();
                
               
                    Lines = Lines.Insert(Cursors, charToAdd);
                    Cursors++;
                
                
                
                
            }
        }

        public void ClearLine()
        {
            Lines = "";
            Cursors = 0;
        }
        private void HandleNumberInput(KeyEventArgs e)
        {
            string symbol = string.Empty;

            switch (e.Code)
            {
                case Keyboard.Key.Num1:
                    symbol = (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || 
                              Keyboard.IsKeyPressed(Keyboard.Key.RShift)) ? "!" : "1";
                    break;
                case Keyboard.Key.Num2:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift)|| 
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "@" : "2";
                    break;
                case Keyboard.Key.Num3:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift)|| 
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "#" : "3";
                    break;
                case Keyboard.Key.Num4:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift)|| 
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "$" : "4";
                    break;
                case Keyboard.Key.Num5:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift)|| 
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "%" : "5";
                    break;
                case Keyboard.Key.Num6:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift)|| 
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "^" : "6";
                    break;
                case Keyboard.Key.Num7:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift)|| 
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "&" : "7";
                    break;
                case Keyboard.Key.Num8:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift)|| 
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "*" : "8";
                    break;
                case Keyboard.Key.Num9:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift)|| 
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "(" : "9";
                    break;
                case Keyboard.Key.Num0:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift)|| 
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? ")" : "0";
                    break;
                case Keyboard.Key.Equal:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift)|| 
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "+" : "=";
                    break;
                case Keyboard.Key.Period:
                    symbol =  "." ;
                    break;
            }

            if (!string.IsNullOrEmpty(symbol))
            {
                Lines = Lines.Insert(Cursors, symbol);
                Cursors++;
            }
        }
        private void HandleNumbersInput(KeyEventArgs e)
        {
            string symbol = string.Empty;

            switch (e.Code)
            {
                case Keyboard.Key.Num1:
                    symbol =  "1";
                    break;
                case Keyboard.Key.Num2:
                    symbol =  "2";
                    break;
                case Keyboard.Key.Num3:
                    symbol =  "3";
                    break;
                case Keyboard.Key.Num4:
                    symbol =  "4";
                    break;
                case Keyboard.Key.Num5:
                    symbol =  "5";
                    break;
                case Keyboard.Key.Num6:
                    symbol =  "6";
                    break;
                case Keyboard.Key.Num7:
                    symbol = "7";
                    break;
                case Keyboard.Key.Num8:
                    symbol =  "8";
                    break;
                case Keyboard.Key.Num9:
                    symbol =  "9";
                    break;
                case Keyboard.Key.Num0:
                    symbol = "0";
                    break;
                case Keyboard.Key.Equal:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift)|| 
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "+" : "";
                    break;
               
            }

            if (!string.IsNullOrEmpty(symbol))
            {
                Lines = Lines.Insert(Cursors, symbol);
                Cursors++;
            }
        }

        public string GetLine()
        {
            return Lines;
        }

        public int GetCursor()
        {
            return Cursors;
        }

        

        public void Update(RenderWindow _window)
        { 
            
            if ((Lines == Frame2.passwordMiniTextFrame2 
                        || Lines == Frame2.repeatPasswordMiniTextFrame2) && IsVisible)
            {
                displayedText = Flag && IsVisible ? Lines.Insert(Cursors, "|") : Lines;
              
            }
            else if (Lines == Frame2.nameMiniTextFrame2 
                     || Lines == Frame2.lMiniTextFrame2 
                     || Lines == Frame2.numberPhoneMiniTextFrame2 
                     || Lines == Frame2.emailMiniTextFrame2)
                   //  ||Lines == Frame3.numberPhoneMiniTextFrame2 
                    // || Lines == Frame3.emailMiniTextFrame2)
            {
                displayedText = Flag ? Lines.Insert(Cursors, "|") : Lines;
                
            
             
            }

        }
      


        public bool ContainsSpecialCharsOrDigits()
        {
            string lineBox = Frame2.passwordMiniTextFrame2;
            
            foreach (char c in lineBox)
            {
                if (char.IsDigit(c) || !char.IsLetterOrDigit(c)) 
                {
                    return true;
                }
            }
            

            return false; 
        }
      

        public bool NumberPhoneFormat(string linebox)
        {
            if (string.IsNullOrEmpty(linebox))
            {
                return false;
            }
            string pattern = @"^(\+7|8)\d{10}$";
            return Regex.IsMatch(linebox, pattern);
        }
        public bool EmailFormat(string linebox)
        {
            if (string.IsNullOrEmpty(linebox))
            {
                return false;
            }

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
    
            return Regex.IsMatch(linebox, pattern);
        }
        

    }
}
