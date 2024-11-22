using SFML.Graphics;
using SFML.Window;
using System.Text.RegularExpressions;
namespace CTT
{
    public class InputLine
    {
        private static Button button;
        private static Texts text;
        private static int cursor = 0;
        public static string line = "";
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
            if (Frame2.flagName)
            {
                button = Frame2.buttonNameSprite;
                text = Frame2.nameMiniText;
                flag = Frame2.flagName;
            }
            if (Frame2.flagPassword)
            {
                button = Frame2.buttonPasswordSprite;
                text = Frame2.passwordMiniText;
                flag = Frame2.flagPassword;
                isVisible = Frame2.isVisiblePassword;
            }
            if (Frame2.flagRepeatPassword)
            {
                button = Frame2.buttonRepeatPasswordSprite;
                text = Frame2.repeatPasswordMiniText;
                flag = Frame2.flagRepeatPassword;
                isVisible = Frame2.isVisibleRepeatPassword;
            }
            if (Frame2.flagNumberPhone)
            {
                button = Frame2.buttonNumberPhoneSprite;
                text = Frame2.numberPhoneMiniText;
                flag = Frame2.flagNumberPhone;
                
            }
             if (Frame2.flagEmail)
            {
                button = Frame2.buttonEmailSprite;
                text = Frame2.emailMiniText;
                flag = Frame2.flagEmail;
                
            }
             if (Frame3.flagNumberPhone)
            {
                button = Frame3.buttonEmptyNumberPfoneSprite;
                text = Frame3.numberPhoneMiniText;
                flag = Frame3.flagNumberPhone;
                
            }
            if (Frame3.flagEmail)
            {
                button = Frame3.buttonEmptyEmailSprite;
                text = Frame3.emailMiniText;
                flag = Frame3.flagEmail;
                
            }
            if(Frame4.flagNumberPhone)
            {
                button = Frame4.buttonEmptyNumberPhoneSprite;
                text = Frame4.numberPhoneMiniTextsFrame4;
                flag = Frame4.flagNumberPhone;
               
               
              
            }
            if(Frame4.flagEmail)
            {
                button = Frame4.buttonEmptyEmailSprite;
                text = Frame4.emailMiniText;
                flag = Frame4.flagEmail;
            }
            else if(Frame4.flagPassword)
            {
                button = Frame4.buttonEmptyPasswordSprite;
                text = Frame4.passwordMiniText;
                flag = Frame4.flagPassword;
                isVisible = Frame4.isVisiblePassword;
                
            }
            if(Frame4.flagNumberPhoneRestoreAccess)
            {
                button = Frame4.buttonEmptyNumberPhoneSprite;
                text = Frame4.numberPhoneMiniTextRestoreAccess;
                flag = Frame4.flagNumberPhoneRestoreAccess;
            
            }
            if(Frame4.flagEmailRestoreAccess)
            {
                button = Frame4.buttonEmptyEmailSprite;
                text = Frame4.emailMiniTextRestoreAccess;
                flag = Frame4.flagEmailRestoreAccess;
            
            }
            if(Frame4.flagPasswordRestoreAccess)
            {
                button = Frame4.buttonEmptyPasswordSprite;
                text = Frame4.passwordMiniTextRestoreAccess;
                flag = Frame4.flagPasswordRestoreAccess;
                isVisible = Frame4.isVisiblePasswordRetoreAcess;
            
            }
            if(Frame4.flagRepeatPasswordRestoreAccess)
            {
                button = Frame4.buttonEmptyRepeatPasswordSpriteRestoreAccess;
                text = Frame4.repeatPasswordMiniTextRestoreAccess;
                flag = Frame4.flagRepeatPasswordRestoreAccess;
                isVisible = Frame4.isVisibleRepeatPasswordRetoreAcess;
            }
        }
        public void OnKeyPressedName(object sender, KeyEventArgs e)
        {
            button = Frame2.buttonNameSprite;
            text = Frame2.nameMiniText;
            flag = Frame2.flagName;
            isVisible = Frame2.isVisiblePassword;
        
            parametr();
      
            if (flag)
            {
               
                HandleNavigationKeys(e);
                if ( line == Frame2.numberPhoneMiniTextFrame2 
                    || line == Frame3.numberPhoneMiniTextFrame3
                    || line == Frame3.emailMiniTextFrame3
                    || line == Frame4.numberPhoneMiniTextFrame4
                    ||  line == Frame4.numberPhoneMiniTextCodeFrame
                    ||  line == Frame4.emailMiniTextCodeFrame
               
                   )
                {
                 
                    HandleNumbersInput(e);
                    
                }
                if (line == Frame2.nameMiniTextFrame2
                     || line == Frame2.lMiniTextFrame2)
                {
                    HandleCharacterInput(e);
                }
                
             if (line == Frame2.passwordMiniTextFrame2 
                     || line == Frame2.repeatPasswordMiniTextFrame2 
                     || line == Frame4.passwordMiniTextFrame
                     || line == Frame4.passwordTextMiniTextResoreAcessFrame
                     || line == Frame4.repeatPasswordTextMiniTextResoreAcessFrame)
                {
                    HandleNumberInput(e);
                    HandleCharacterInput(e);
                }
             if ( line == Frame2.emailMiniTextFrame2
                    ||  line == Frame4.emailMiniTextFrame)
                {
                    
                    HandleCharacterInputEmail(e);
                    
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
                
                line = line.Insert(cursor, charToAdd);
                cursor++;
               
                
                
                
            }
        }
        private void HandleCharacterInputEmail(KeyEventArgs e)
        {
            string symbol = string.Empty;
            string charToAdd = string.Empty;
            
            if (System.Text.RegularExpressions.Regex.IsMatch(e.Code.ToString(), @"^[a-zA-Z]$"))
            {

                charToAdd = (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || 
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift)) ? 
                    e.Code.ToString().ToUpper() : 
                    e.Code.ToString().ToLower();
            }
  
            else if (e.Code == Keyboard.Key.Period)
            {
                charToAdd = ".";
            }
            else if ((Keyboard.IsKeyPressed(Keyboard.Key.LShift) || 
                      Keyboard.IsKeyPressed(Keyboard.Key.RShift)) && e.Code == Keyboard.Key.Num2)
            {
                charToAdd = "@";
            }
            
            if (!string.IsNullOrEmpty(charToAdd))
            {
                line = line.Insert(cursor, charToAdd);
                cursor++;  
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

        public void LineParametr()
        {
            if (Frame2.flagName)
            {
                line = Frame2.nameMiniTextFrame2;
                cursor = Frame2.cursorNamePosition;
            }
            if (Frame2.flagLName)
            {
                line = Frame2.lMiniTextFrame2;
                cursor = Frame2.cursorLnamePosition;
            }
            if (Frame2.flagPassword)
            {
                line = Frame2.passwordMiniTextFrame2;
                cursor = Frame2.cursorPasswordPosition;
            }
            if (Frame2.flagRepeatPassword)
            {
                line = Frame2.repeatPasswordMiniTextFrame2;
                cursor = Frame2.cursorRepeatPasswordPosition;
            }
            if (Frame2.flagNumberPhone)
            {
                line = Frame2.numberPhoneMiniTextFrame2;
                cursor = Frame2.cursorNumberPhonePosition;
            }
            if (Frame2.flagEmail)
            {
                line = Frame2.emailMiniTextFrame2;
                cursor = Frame2.cursorEmailPosition;
            }
            
            if (Frame3.flagNumberPhone)
            {
                line = Frame3.numberPhoneMiniTextFrame3;
                cursor = Frame3.cursorNumberPhonePosition;
            }
            if (Frame3.flagEmail)
            {
                line = Frame3.emailMiniTextFrame3;
                cursor = Frame3.cursorEmailPosition;
            }
            if(Frame4.flagNumberPhone)
            {
                line = Frame4.numberPhoneMiniTextFrame4;
                cursor = Frame4.cursorNumberPhonePosition;
            }
            if (Frame4.flagEmail)
            {
                line = Frame4.emailMiniTextFrame;
                cursor = Frame4.cursorEmailPosition;
            }
            if (Frame4.flagPassword)
            {
                line = Frame4.passwordMiniTextFrame;
                cursor = Frame4.cursorPasswordPosition;
            }
            if (Frame4.flagNumberPhoneRestoreAccess)
            {
                line = Frame4.numberPhoneMiniTextCodeFrame;
                cursor = Frame4.cursorNumberPhonePositionRestoreAccess;
              
            }
            if (Frame4.flagEmailRestoreAccess)
            {
                line = Frame4.emailMiniTextCodeFrame;
                cursor = Frame4.cursorEmailPositionRestoreAccess;
              
            }
            if(Frame4.flagPasswordRestoreAccess)
            {
                line = Frame4.passwordTextMiniTextResoreAcessFrame;
                cursor = Frame4.cursorPasswordPositionRestoreAccess;
            
            }
            if(Frame4.flagRepeatPasswordRestoreAccess)
            {
               
                line = Frame4.repeatPasswordTextMiniTextResoreAcessFrame;
                cursor = Frame4.cursorRepeatPasswordPositionRestoreAccess;
            }
           

        }

        public void clearLine()
        {
            line = "";
            cursor = 0;
        }

        public void Update(RenderWindow _window)
        {
            text = Frame2.nameMiniText;
            
            parametr();
            if ((line == Frame2.passwordMiniTextFrame2 
                 || line == Frame2.repeatPasswordMiniTextFrame2
                 || line == Frame4.passwordMiniTextFrame
                 || line == Frame4.passwordTextMiniTextResoreAcessFrame
                 || line == Frame4.repeatPasswordTextMiniTextResoreAcessFrame) && isVisible)
            {
                displayedText = flag && isVisible ? line.Insert(cursor, "|") : line;
                
                text.SetText(displayedText);
            }
            else  if (line == Frame2.nameMiniTextFrame2 
                    || line == Frame2.lMiniTextFrame2 
                    || line == Frame2.numberPhoneMiniTextFrame2 
                    || line == Frame2.emailMiniTextFrame2
                    || line == Frame3.numberPhoneMiniTextFrame3
                    || line == Frame4.numberPhoneMiniTextFrame4
                    ||  line == Frame4.numberPhoneMiniTextCodeFrame
                    ||  line == Frame4.emailMiniTextCodeFrame)
            
            {
                displayedText = flag ? line.Insert(cursor, "|") : line;
                
                text.SetText(displayedText);
             
            }

            text.Draw(_window);
        }
      


        public bool ContainsSpecialCharsOrDigits()
        {
            
            string lineBox = Frame2.passwordMiniTextFrame2;
            if (Frame4.passwordMiniTextFrame != "")
            {
                lineBox = Frame4.passwordMiniTextFrame;
            }
            
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
            if (Frame4.numberPhoneMiniTextFrame4 != "")
            {
                lineBox = Frame4.numberPhoneMiniTextFrame4;
            }
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
            if (Frame4.emailMiniTextFrame != "")
            {
                lineBox = Frame4.emailMiniTextFrame;
            }
            if (string.IsNullOrEmpty(lineBox))
            {
                return false;
            }

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
    
            return Regex.IsMatch(lineBox, pattern);
        }
        

    }
}