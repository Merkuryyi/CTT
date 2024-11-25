using System.Diagnostics.CodeAnalysis;
using SFML.Graphics;
using SFML.Window;
using System.Text.RegularExpressions;
namespace CTT
{
    public class InputLine
    {
        private static Button Button;
        private static Texts Text;
        private static int Cursor;
        public static string Line = "";
        private static bool Flag = true;
        private static bool isVisible = false;
        public static string displayedText;

    public void parametres(Texts text, bool flag)
        {
            Text = text;
            Flag = flag;
        }

        public void LineParametr(string line, int cursor)
        {
            Cursor = cursor;
            Line = line;
        }
        

        public void OnKeyPressedName(object sender, KeyEventArgs e)
        {
            
            HandleNavigationKeys(e);
           
                if ( Line == Frame2.numberPhoneMiniTextFrame2 
                    || Line == Frame3.numberPhoneMiniTextFrame3
                    || Line == Frame3.emailMiniTextFrame3
                    || Line == Frame4.numberPhoneMiniTextFrame4
                    ||  Line == Frame4.numberPhoneMiniTextCodeFrame
                    ||  Line == Frame4.emailMiniTextCodeFrame
               
                   )
                {
                 
                    HandleNumbersInput(e);
                    
                    
                }
                if (Line == Frame2.nameMiniTextFrame2
                     || Line == Frame2.lMiniTextFrame2)
                {
                    HandleCharacterInput(e);
                
                }
                
             if (Line == Frame2.passwordMiniTextFrame2 
                     || Line == Frame2.repeatPasswordMiniTextFrame2 
                     || Line == Frame4.passwordMiniTextFrame
                     || Line == Frame4.passwordTextMiniTextResoreAcessFrame
                     || Line == Frame4.repeatPasswordTextMiniTextResoreAcessFrame)
                {
                    HandleNumberInput(e);
                    HandleCharacterInput(e);
                }
             if ( Line == Frame2.emailMiniTextFrame2
                    ||  Line == Frame4.emailMiniTextFrame)
                {
                    
                    HandleCharacterInputEmail(e);
                    
                }
                
            
        }

        private void HandleNavigationKeys(KeyEventArgs e)
        {
            switch (e.Code)
            {
                case Keyboard.Key.BackSpace:
                    if (Cursor > 0)
                    {
                        Line = Line.Remove(Cursor - 1, 1);
                        Cursor--;
                    }
                    break;

                case Keyboard.Key.Delete:
                    if (Cursor < Line.Length)
                    {
                        Line = Line.Remove(Cursor, 1);
                    }
                    break;

                case Keyboard.Key.Left:
                    if (Cursor > 0)
                    {
                        Cursor--;
                    }
                    break;

                case Keyboard.Key.Right:
                    if (Cursor < Line.Length)
                    {
                        Cursor++;
                    }
                    break;
            }
        }

          private void HandleInput(KeyEventArgs e)
        {
            if (IsNumberInputField())
            {
                HandleNumbersInput(e);
            }
            else if (IsCharacterInputField())
            {
                HandleCharacterInput(e);
            }
            else if (IsPasswordInputField())
            {
                HandleNumberInput(e);
                HandleCharacterInput(e);
            }
            else if (IsEmailInputField())
            {
                HandleCharacterInputEmail(e);
            }
        }

        private bool IsNumberInputField()
        {
            return Line == Frame2.numberPhoneMiniTextFrame2 ||
                   Line == Frame3.numberPhoneMiniTextFrame3 ||
                   Line == Frame3.emailMiniTextFrame3 ||
                   Line == Frame4.numberPhoneMiniTextFrame4 ||
                   Line == Frame4.numberPhoneMiniTextCodeFrame ||
                   Line == Frame4.emailMiniTextCodeFrame;
        }

        private bool IsCharacterInputField()
        {
            return Line == Frame2.nameMiniTextFrame2 ||
                   Line == Frame2.lMiniTextFrame2;
        }

        private bool IsPasswordInputField()
        {
            return Line == Frame2.passwordMiniTextFrame2 ||
                   Line == Frame2.repeatPasswordMiniTextFrame2 ||
                   Line == Frame4.passwordMiniTextFrame ||
                   Line == Frame4.passwordTextMiniTextResoreAcessFrame ||
                   Line == Frame4.repeatPasswordTextMiniTextResoreAcessFrame;
        }

        private bool IsEmailInputField()
        {
            return Line == Frame2.emailMiniTextFrame2 ||
                   Line == Frame4.emailMiniTextFrame;
        }

        private void HandleCharacterInput(KeyEventArgs e)
        {
            char charToAdd = GetCharFromKey(e);

            if (charToAdd != '\0')
            {
                Line = Line.Insert(Cursor, charToAdd.ToString());
                Cursor++;
            }
        }

        private char GetCharFromKey(KeyEventArgs e)
        {
            string keyString = e.Code.ToString();

            if (Regex.IsMatch(keyString, @"^[a-zA-Z]$"))
            {
                bool isShiftPressed = Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift);
                return isShiftPressed ? keyString[0].ToString().ToUpper()[0] : keyString[0].ToString().ToLower()[0];
            }

            return '\0';
        }

        private void HandleCharacterInputEmail(KeyEventArgs e)
        {
            string charToAdd = string.Empty;

            if (Regex.IsMatch(e.Code.ToString(), @"^[a-zA-Z]$"))
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
                Line = Line.Insert(Cursor, charToAdd);
                Cursor++;
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
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift) ||
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "@" : "2";
                    break;
                case Keyboard.Key.Num3:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift) ||
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "#" : "3";
                    break;
                case Keyboard.Key.Num4:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift) ||
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "$" : "4";
                    break;
                case Keyboard.Key.Num5:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift) ||
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "%" : "5";
                    break;
                case Keyboard.Key.Num6:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift) ||
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "^" : "6";
                    break;
                case Keyboard.Key.Num7:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift) ||
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "&" : "7";
                    break;
                case Keyboard.Key.Num8:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift) ||
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "*" : "8";
                    break;
                case Keyboard.Key.Num9:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift) ||
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "(" : "9";
                    break;
                case Keyboard.Key.Num0:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift) ||
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? ")" : "0";
                    break;
                case Keyboard.Key.Equal:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift) ||
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "+" : "=";
                    break;
            }

            if (!string.IsNullOrEmpty(symbol))
            {
                Line = Line.Insert(Cursor, symbol);
                Cursor++;
            }
        }

        private void HandleNumbersInput(KeyEventArgs e)
        {
            string symbol = string.Empty;

            switch (e.Code)
            {
                case Keyboard.Key.Num1:
                    symbol = "1";
                    break;
                case Keyboard.Key.Num2:
                    symbol = "2";
                    break;
                case Keyboard.Key.Num3:
                    symbol = "3";
                    break;
                case Keyboard.Key.Num4:
                    symbol = "4";
                    break;
                case Keyboard.Key.Num5:
                    symbol = "5";
                    break;
                case Keyboard.Key.Num6:
                    symbol = "6";
                    break;
                case Keyboard.Key.Num7:
                    symbol = "7";
                    break;
                case Keyboard.Key.Num8:
                    symbol = "8";
                    break;
                case Keyboard.Key.Num9:
                    symbol = "9";
                    break;
                case Keyboard.Key.Num0:
                    symbol = "0";
                    break;
                case Keyboard.Key.Equal:
                    symbol = Keyboard.IsKeyPressed(Keyboard.Key.LShift) ||
                             Keyboard.IsKeyPressed(Keyboard.Key.RShift) ? "+" : "";
                    break;
            }

            if (!string.IsNullOrEmpty(symbol))
            {
                Line = Line.Insert(Cursor, symbol);
                Cursor++;
            }
        }

        public string GetLine()
        {
            return Line;
        }

        public int GetCursor()
        {
            return Cursor;
        }


        public void clearLine()
        {
            Line = "";
            Cursor = 0;
        }

        public void Update(RenderWindow _window)
        {
            Text = Frame2.nameMiniText;
          
            if ((Line == Frame2.passwordMiniTextFrame2 
                 || Line == Frame2.repeatPasswordMiniTextFrame2
                 || Line == Frame4.passwordMiniTextFrame
                 || Line == Frame4.passwordTextMiniTextResoreAcessFrame
                 || Line == Frame4.repeatPasswordTextMiniTextResoreAcessFrame) && isVisible)
            {
                displayedText = Flag && isVisible ? Line.Insert(Cursor, "|") : Line;
                
                
            }
            else  if (Line == Frame2.nameMiniTextFrame2 
                    || Line == Frame2.lMiniTextFrame2 
                    || Line == Frame2.numberPhoneMiniTextFrame2 
                    || Line == Frame2.emailMiniTextFrame2
                    || Line == Frame3.numberPhoneMiniTextFrame3
                    || Line == Frame4.numberPhoneMiniTextFrame4
                    ||  Line == Frame4.numberPhoneMiniTextCodeFrame
                    ||  Line == Frame4.emailMiniTextCodeFrame
                    || Line == Frame4.emailMiniTextFrame)
            
            {
                displayedText = Flag ? Line.Insert(Cursor, "|") : Line;
                
              
             
            }

            Text.Draw(_window);
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