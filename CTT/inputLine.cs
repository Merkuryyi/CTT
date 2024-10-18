
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using CTT;
public class inputLine
{
    private static Sprite button;
    private static Text text;
    private static int cursor = 0;
    private static string line = "";
     private static void OnKeyPressedName(object sender, KeyEventArgs e)
    {
        bool flag = false;
        float buttonWidth = button.GetGlobalBounds().Width;
        Sprite sprite;
        
        
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
            
            
            
           

            if ((text.GetLocalBounds().Width < buttonWidth - 50)) 
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
        else if (!flag)
        {
            line = "";
            cursor = 0;
        }
    } 
    
    /*private static void OnKeyPressedLName(object sender, KeyEventArgs e)
    {
        float buttonWidth = buttonLNameSprite.GetGlobalBounds().Width;
        
        if (flagLName)
        {
            switch (e.Code)
            {
                case Keyboard.Key.BackSpace:
                    if (cursorLnamePosition > 0)
                    {
                        lineLName = lineLName.Remove(cursorLnamePosition - 1, 1);
                        cursorLnamePosition--;
                    }

                    break;

                case Keyboard.Key.Delete:
                    if (cursorLnamePosition < lineLName.Length)
                    {
                        lineLName = lineLName.Remove(cursorLnamePosition, 1);
                    }

                    break;
                case Keyboard.Key.Left:
                    if (cursorLnamePosition > 0)
                    {
                        cursorLnamePosition--;
                    }

                    break;
                case Keyboard.Key.Right:
                    if (cursorLnamePosition < lineLName.Length)
                    {
                        cursorLnamePosition++;
                    }

                    break;
            }





            if ((lNameMiniText.GetGlobalBounds().Width < buttonWidth - 50)) 
            {

                if (System.Text.RegularExpressions.Regex.IsMatch(e.Code.ToString(), @"^[a-zA-Z]$"))
                {

                    if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))
                    {
                        lineLName = lineLName.Insert(cursorLnamePosition, e.Code.ToString().ToUpper());

                        cursorLnamePosition++;
                    }
                    else
                    {
                        lineLName = lineLName.Insert(cursorLnamePosition, e.Code.ToString().ToLower());
                        cursorLnamePosition++;
                    }
                }

                switch (e.Code)
                {
                    case Keyboard.Key.Enter:
                        if (linePassword != "" && lineName != "" && lineLName != "" )
                        {
                            nextWindow = true;
                        }


                        break;



               
            }
        }
    }  */
    
    /* public void UpdateName(RenderWindow _window)
    {
        
        cursorPosition = cursor;
        if (flagName)
        {
            
            string displayedText = flagName? lineName.Insert(cursorPosition, "|") : lineName;
            nameMiniText.SetText(displayedText);
            _window.Draw(nameMiniText);
            
            
        }
        else if (!flagName)
        {
            
            string displayedText = flagName? lineName.Insert(cursorPosition, "") : lineName;
            nameMiniText.SetText(displayedText);
            
            
            
        }
        
       
        
               
    }
    
    public void UpdateLName(RenderWindow _window)
    {
        string displayedText = "";
        lineLName = line;
        cursorLnamePosition = cursor;
        if (flagLName)
        {
            displayedText = flagLName ? lineLName.Insert(cursorLnamePosition, "|") : lineLName;
            lNameMiniText.SetText = displayedText;
            _window.Draw(lNameMiniText);
        }
        

        else 
        {
            displayedText = flagLName && flagName ? lineLName.Insert(cursorLnamePosition, "") : linePassword;
            passwordMiniText.SetText(displayedText);
            _window.Draw(passwordMiniText);
        }
        
    }

    
 
    
    
    
    
   
    public void UpdatePassword(RenderWindow _window)
    {
        string displayedText = "";
        if (flagPassword)
        {
           displayedText = flagPassword ? linePassword.Insert(cursorPasswordPosition, "|") : linePassword;
            passwordMiniText.SetText(displayedText);
            _window.Draw(passwordMiniText);
        }
        else 
        {
            displayedText = flagPassword ? lineLName.Insert(cursorPasswordPosition, " ") : lineLName;
            lNameMiniText.SetText(displayedText);
            _window.Draw(lNameMiniText);
        }
        
        
        
    }
    
     private static void OnKeyPressedPassword(object sender, KeyEventArgs e)
    {
        float buttonWidth = buttonPasswordSprite.GetGlobalBounds().Width;
        
        if (flagPassword)
        {
            switch (e.Code)
            {
                case Keyboard.Key.BackSpace:
                    if (cursorPasswordPosition > 0)
                    {
                        linePassword = linePassword.Remove(cursorPasswordPosition - 1, 1);
                        cursorPasswordPosition--;
                    }

                    break;

                case Keyboard.Key.Delete:
                    if (cursorPasswordPosition < linePassword.Length)
                    {
                        linePassword = linePassword.Remove(cursorPasswordPosition, 1);
                    }

                    break;
                case Keyboard.Key.Left:
                    if (cursorPasswordPosition > 0)
                    {
                        cursorPasswordPosition--;
                    }

                    break;
                case Keyboard.Key.Right:
                    if (cursorPasswordPosition < linePassword.Length)
                    {
                        cursorPasswordPosition++;
                    }

                    break;
                
                case Keyboard.Key.Enter:
                        if (linePassword != "" && lineName != "" && lineLName != "")
                        {
                            nextWindow = true;
                        }

                        break;

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
                
                
            }





            if ((passwordMiniText.GetGlobalBounds().Width < buttonWidth - 50) && System.Text.RegularExpressions.Regex.IsMatch(e.Code.ToString(), @"^[a-zA-Z]$")) 
            {

                    if (Keyboard.IsKeyPressed(Keyboard.Key.LShift) || Keyboard.IsKeyPressed(Keyboard.Key.RShift))
                    {
                        linePassword = linePassword.Insert(cursorPasswordPosition, e.Code.ToString().ToUpper());

                        cursorPasswordPosition++;
                    }
                    else
                    {
                        linePassword = linePassword.Insert(cursorPasswordPosition, e.Code.ToString().ToLower());
                        cursorPasswordPosition++;
                    } 
            }

           
        }
    } */
    
}