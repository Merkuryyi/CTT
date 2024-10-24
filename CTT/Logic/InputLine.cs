using SFML.Graphics;
using SFML.Window;
using System.Text.RegularExpressions;
namespace CTT
{
    public class InputLine
    {
        private static Button button;
        private static Texts text;
        private static int cursor;
        public static string line;
        private static bool flag = true;
        private static bool isVisible = false;
        public static string displayedText;
        private static float offset;
           
        public void parametr()
        {
            if (Frame2.flagLName)
            {
                button = Frame2.buttonLNameSprite;
                text = Frame2.lNameMiniText;
                flag = Frame2.flagLName;
            }
            else if (Frame2.flagName)
            {
                button = Frame2.buttonNameSprite;
                text = Frame2.nameMiniText;
                flag = Frame2.flagName;
            }
            else if (Frame2.flagPassword)
            {
                button = Frame2.buttonPasswordSprite;
                text = Frame2.passwordMiniText;
                flag = Frame2.flagPassword;
                isVisible = Frame2.isVisiblePassword;
            }
            else if (Frame2.flagRepeatPassword)
            {
                button = Frame2.buttonRepeatPasswordSprite;
                text = Frame2.repeatPasswordMiniText;
                flag = Frame2.flagRepeatPassword;
                isVisible = Frame2.isVisibleRepeatPassword;
            }
            else if (Frame2.flagNumberPhone)
            {
                button = Frame2.buttonNumberPhoneSprite;
                text = Frame2.numberPhoneMiniText;
                flag = Frame2.flagNumberPhone;
                
            }
            else if (Frame2.flagEmail)
            {
                button = Frame2.buttonEmailSprite;
                text = Frame2.emailMiniText;
                flag = Frame2.flagEmail;
                
            }
        }
        public void OnKeyPressedName(object sender, KeyEventArgs e)
        {
            button = Frame2.buttonNameSprite;
            text = Frame2.nameMiniText;
            flag = Frame2.flagName;
            isVisible = Frame2.isVisiblePassword;
            float textWidth = text.GetGlobalBounds().Width;
            parametr();
            float buttonWidth = button.GetGlobalBounds().Width;

            if (flag)
            {
                HandleNavigationKeys(e);
                
                if ((line == Frame2.nameMiniTextFrame2
                     || line == Frame2.lMiniTextFrame2 ))
                {
                    HandleCharacterInput(e);
                }

               else  if ((line == Frame2.passwordMiniTextFrame2 
                     || line == Frame2.repeatPasswordMiniTextFrame2 || line == Frame2.emailMiniTextFrame2))
                {
                    HandleNumberInput(e);
                    HandleCharacterInput(e);
                }
                else if (( line == Frame2.numberPhoneMiniTextFrame2))
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
                    if (cursor > 0)
                    {
                        line = line.Remove(cursor - 1, 1);
                        cursor--;
                    }
                    break;

                case Keyboard.Key.Delete:
                    if (cursor < line.Length)
                    {
                        line = line.Remove(cursor, 1);
                    }
                    break;

                case Keyboard.Key.Left:
                    if (cursor > 0)
                    {
                        cursor--;
                    }
                    break;

                case Keyboard.Key.Right:
                    if (cursor < line.Length)
                    {
                        cursor++;
                    }
                    break;
            }
        }

        private void HandleCharacterInput(KeyEventArgs e)
        {
            float buttonWidth = button.GetGlobalBounds().Width;
            if (System.Text.RegularExpressions.Regex.IsMatch(e.Code.ToString(), @"^[a-zA-Z]$"))
            {
                string charToAdd = Keyboard.IsKeyPressed(Keyboard.Key.LShift) || 
                                   Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? 
                                   e.Code.ToString().ToUpper() : 
                                   e.Code.ToString().ToLower();
                
                //((int)buttonWidth - (int)textWidth)
                
                float textWidth = text.GetGlobalBounds().Width;
                line = line.Insert(cursor, charToAdd);
                cursor++;
                if (text.GetGlobalBounds().Width > buttonWidth - 90)
                {
                    text.SetPosition(171 - cursor, 350);
                   
                }
                
                
                
            }
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
                line = line.Insert(cursor, symbol);
                cursor++;
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
                line = line.Insert(cursor, symbol);
                cursor++;
            }
        }

        public string GetLine()
        {
            return line;
        }

        public int GetCursor()
        {
            return cursor;
        }

        public void ClearLine()
        {
            if (Frame2.flagName)
            {
                line = Frame2.nameMiniTextFrame2;
                cursor = Frame2.cursorNamePosition;
            }
            else if (Frame2.flagLName)
            {
                line = Frame2.lMiniTextFrame2;
                cursor = Frame2.cursorLnamePosition;
            }
            else if (Frame2.flagPassword)
            {
                line = Frame2.passwordMiniTextFrame2;
                cursor = Frame2.cursorPasswordPosition;
            }
            else if (Frame2.flagRepeatPassword)
            {
                line = Frame2.repeatPasswordMiniTextFrame2;
                cursor = Frame2.cursorRepeatPasswordPosition;
            }
            else if (Frame2.flagNumberPhone)
            {
                line = Frame2.numberPhoneMiniTextFrame2;
                cursor = Frame2.cursorNumberPhonePosition;
            }
            else if (Frame2.flagEmail)
            {
                line = Frame2.emailMiniTextFrame2;
                cursor = Frame2.cursorEmailPosition;
            }

        }

        public void Update(RenderWindow _window)
        {
            text = Frame2.nameMiniText;
            
            parametr();
            if ((line == Frame2.passwordMiniTextFrame2 
                        || line == Frame2.repeatPasswordMiniTextFrame2) && isVisible)
            {
                displayedText = flag && isVisible ? line.Insert(cursor, "|") : line;
   
                parametr();
                text.SetText(displayedText);
            }
            else if (line == Frame2.nameMiniTextFrame2 
                     || line == Frame2.lMiniTextFrame2 
                     || line == Frame2.numberPhoneMiniTextFrame2 
                     || line == Frame2.emailMiniTextFrame2)
            {
                displayedText = flag ? line.Insert(cursor, "|") : line;
                
                text.SetText(displayedText);
             
            }

            text.Draw(_window);
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
      

        public bool NumberPhoneFormat()
        {
            string lineBox = Frame2.numberPhoneMiniTextFrame2;
    
            if (string.IsNullOrEmpty(lineBox))
            {
                return false;
            }
            string pattern = @"^(\+7|8)\d{10}$";
    
            return Regex.IsMatch(lineBox, pattern);
        }
        public bool EmailFormat()
        {
            string lineBox = Frame2.emailMiniTextFrame2;
    
            if (string.IsNullOrEmpty(lineBox))
            {
                return false;
            }

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
    
            return Regex.IsMatch(lineBox, pattern);
        }
        

    }
}
