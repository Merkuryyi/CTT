using SFML.Graphics;
using SFML.Window;

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
                button =  Frame2.buttonNameSprite;
                text = Frame2.nameMiniText;       
                flag = Frame2.flagName;
            }
            else if (Frame2.flagPassword)
            {   
                button =  Frame2.buttonPasswordSprite;
                text = Frame2.passwordMiniText;       
                flag = Frame2.flagPassword;
                isVisible = Frame2.isVisiblePassword;
            }
            else if (Frame2.flagRepeatPassword)
            {   
                button =  Frame2.buttonRepeatPasswordSprite;
                text = Frame2.repeatPasswordMiniText;       
                flag = Frame2.flagRepeatPassword;
                isVisible = Frame2.isVisibleRepeatPassword;
            }
        }
        public void OnKeyPressedName(object sender, KeyEventArgs e)
        {      
            button =  Frame2.buttonNameSprite;
            text = Frame2.nameMiniText;       
            flag = Frame2.flagName;
            isVisible = Frame2.isVisiblePassword;
            
            parametr();
            float buttonWidth = button.GetGlobalBounds().Width;      
            if (flag)
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
                        if (cursor < line.Length )
                        {                       
                            line = line.Remove(cursor, 1);
                        }
                        break;                
                    case Keyboard.Key.Left:
                        if (cursor >  0)                   
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

                         
                if (text.GetGlobalBounds().Width < buttonWidth - 90 && line.Length < 11)
                {                
                    if (System.Text.RegularExpressions.Regex.IsMatch(e.Code.ToString(), @"^[a-zA-Z]$"))            
                    {
                       
                        if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))                
                        {
                            line = line.Insert(cursor, e.Code.ToString().ToUpper());                      
                            cursor++;
                        }
                        else                  
                        {
                            line = line.Insert(cursor, e.Code.ToString().ToLower());
                            cursor++;
                        }
                    }
                }       
            }
        }
        public  string GetLine()
        {
           return line;        
        } 
        public int GetCursor()
        {
            return cursor;        
        }
        
        public  void ClearLine()
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

        }
        public void Update(RenderWindow _window)
        {
            text = Frame2.nameMiniText;
  
            if (Frame2.flagLName)
            {
                text = Frame2.lNameMiniText;
            }
            else if (Frame2.flagPassword)
            {
                text = Frame2.passwordMiniText;
            }
            else if (Frame2.flagRepeatPassword)
            {
                text = Frame2.repeatPasswordMiniText;
            }
            
            
                displayedText = flag && isVisible ? line.Insert(cursor, "|") : line;
                if (isVisible)
                {
                    text.SetText(displayedText);
                }
                parametr();
                
                ClearLine();
            
            
           
            
         
            text.Draw(_window);
        }
      
    } 
    
    /*
     case Keyboard.Key.Num1:

                        if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))
                        {
                            lineLName += "@";
                            cursorPasswordPosition++;
                        }
                        else
                        {
                            lineLName += "1";
                            cursorPasswordPosition++;
                        }

                        cursorLnamePosition++;
                        break;
                    case Keyboard.Key.Num2:
                        if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))
                        {
                            lineLName += "!";
                        }
                        else
                        {
                            lineLName += "2";
                        }

                        cursorLnamePosition++;
                        break;
                    case Keyboard.Key.Num3:
                        if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))
                        {
                            lineLName += "#";
                        }
                        else
                        {
                            lineLName += "3";
                        }

                        cursorLnamePosition++;
                        break;
                    case Keyboard.Key.Num4:
                        if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))
                        {
                            lineLName += "$!";
                        }
                        else
                        {
                            lineLName += "4";
                        }

                        cursorLnamePosition++;
                        break;
                    case Keyboard.Key.Num5:
                        if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))
                        {
                            lineLName += "%";
                        }
                        else
                        {
                            lineLName += "5";
                        }

                        cursorLnamePosition++;
                        break;
                    case Keyboard.Key.Num6:
                        if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))
                        {
                            lineLName += "^";
                        }
                        else
                        {
                            lineLName += "6";
                        }

                        cursorLnamePosition++;
                        break;
                    case Keyboard.Key.Num7:
                        if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))
                        {
                            lineLName += "&";
                        }
                        else
                        {
                            lineLName += "7";
                        }

                        cursorLnamePosition++;
                        break;
                    case Keyboard.Key.Num8:
                        if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))
                        {
                            lineLName += "*";
                        }
                        else
                        {
                            lineLName += "8";
                        }

                        cursorLnamePosition++;
                        break;
                    case Keyboard.Key.Num9:
                        if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))
                        {
                            lineLName += "(";
                        }
                        else
                        {
                            lineLName += "9";
                        }

                        cursorLnamePosition++;
                        break;
                    case Keyboard.Key.Num0:
                        if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))
                        {
                            lineLName += ")";
                        }
                        else
                        {
                            lineLName += "0";
                        }

                        cursorLnamePosition++;
                        break;
     */
 
}
