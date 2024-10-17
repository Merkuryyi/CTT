using SFML.Graphics;
using SFML.Window;
using SFML.System;


public class Frame2
{
    private static bool nextWindow;
    
    private static string lineName = "";
    private static int cursorPosition = 0;
    private static bool flagName = false;
    private static int cursor = 0;
    
    
    private static Sprite buttonNameSprite;
    private static Text nameMiniText;
    
    private static int cursorLnamePosition = 0;
    private static Text lNameMiniText;
   
    private static bool flagLName = false;
    private static Sprite buttonLNameSprite;
    private static string lineLName = "";
    private static Text cursorLname;
    
    private static string line = "";
    
    private static bool flagPassword = false;
    private static Sprite buttonPasswordSprite;
    private static string linePassword = "";
    private static int cursorPasswordPosition = 0;
    private static Text passwordMiniText;
    
    private static Font font;
    private static Texture fon;
    private static Texture emptyButtonTexture;
    private static Texture buttonTexture;
    private static Sprite fonFrame2;
    private static Sprite buttonNumberPhoneSprite;
    private static Sprite buttonEmailSprite;
    private static Sprite buttonRepeatPasswordSprite;
    private static Sprite buttonFurtherSprite;
    private static Text titleText;
    private static Text nameText;
    private static Text numberPhoneText;
    private static Text passwordText;
    private static Text lnameText;
    private static Text emailText;
    private static Text repeatPasswordText;
    private static Text warningNameText;
    private static Text warningLNameText;
    private static Text warningNumberPfoneText;
    private static Text warningEmailText;
    private static  Text warningPasswordText;
    private static Text warningRepeatPasswordText;
    private static Text furtherText;
    
    public void UpdateName(RenderWindow _window)
    {
        
        cursorPosition = cursor;
        if (flagName)
        {
            
            string displayedText = flagName? lineName.Insert(cursorPosition, "|") : lineName;
            nameMiniText.DisplayedString = displayedText;
            _window.Draw(nameMiniText);
            
            
        }
        else if (!flagName)
        {
            
            string displayedText = flagName? lineName.Insert(cursorPosition, "") : lineName;
            nameMiniText.DisplayedString = displayedText;
            
            
            
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
            lNameMiniText.DisplayedString = displayedText;
            _window.Draw(lNameMiniText);
        }
        

        else 
        {
            displayedText = flagLName && flagName ? lineLName.Insert(cursorLnamePosition, "") : linePassword;
            passwordMiniText.DisplayedString = displayedText;
            _window.Draw(passwordMiniText);
        }
        
    }

    
 
    
    
    
    
    private static void OnKeyPressedName(object sender, KeyEventArgs e)
    {
        bool flag = false;
        float buttonWidth = buttonNameSprite.GetGlobalBounds().Width;
        Sprite sprite;
        
        Text text = new Text("", font);
        
        if (flagName)
        {
            
                
            
            flag = flagName;
            text = nameMiniText;
            cursor = cursorPosition;
            line = lineName;

        }
        
        if (flagLName)
        {
            flag = flagLName;
            text = lNameMiniText;
            cursor = cursorLnamePosition;

        }
        
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
                case Keyboard.Key.Enter:
                    
                    if (linePassword != "" && lineName != "" && lineLName != "" )
                    {
                        nextWindow = true;
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
    /*
    
    private static void OnKeyPressedLName(object sender, KeyEventArgs e)
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





            if ((lNameMiniText.GetLocalBounds().Width < buttonWidth - 50)) 
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
        }
    } */
    public void UpdatePassword(RenderWindow _window)
    {
        string displayedText = "";
        if (flagPassword)
        {
           displayedText = flagPassword ? linePassword.Insert(cursorPasswordPosition, "|") : linePassword;
            passwordMiniText.DisplayedString = displayedText;
            _window.Draw(passwordMiniText);
        }
        else 
        {
            displayedText = flagPassword ? lineLName.Insert(cursorPasswordPosition, " ") : lineLName;
            lNameMiniText.DisplayedString = displayedText;
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





            if ((passwordMiniText.GetLocalBounds().Width < buttonWidth - 50) && System.Text.RegularExpressions.Regex.IsMatch(e.Code.ToString(), @"^[a-zA-Z]$")) 
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
    } 
    
                
                
                //Hyphen(-) Equal(+) LBracket([) RBracket(]) Semicolon Quote BackSlash Comma Period Slash Tilde 

    public void Structure()
    {
        font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        fon = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fonRegistration.png"));
        emptyButtonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
        buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
        
        fonFrame2 = new Sprite(fon);
        fonFrame2.Position = new Vector2f(53, 53);
        
        buttonNameSprite = new Sprite(emptyButtonTexture);
        buttonNameSprite.Position = new Vector2f(151, 336);

        buttonNumberPhoneSprite = new Sprite(emptyButtonTexture);
        buttonNumberPhoneSprite.Position = new Vector2f(151, 505);

        buttonPasswordSprite= new Sprite(emptyButtonTexture);
        buttonPasswordSprite.Position = new Vector2f(151, 669);

        buttonLNameSprite = new Sprite(emptyButtonTexture);
        buttonLNameSprite.Position = new Vector2f(614, 336);

        buttonEmailSprite = new Sprite(emptyButtonTexture);
        buttonEmailSprite.Position = new Vector2f(614, 505);

        buttonRepeatPasswordSprite = new Sprite(emptyButtonTexture);
        buttonRepeatPasswordSprite.Position = new Vector2f(614, 669);
        
        buttonFurtherSprite = new Sprite(buttonTexture);
        buttonFurtherSprite.Position = new Vector2f(386, 838);
          
        
             
        titleText = new Text("Регистрация", font);
        titleText.CharacterSize = 48;
        titleText.FillColor = new Color(68, 68, 69);
        titleText.Position = new Vector2f(138, 125);

        nameText = new Text("Имя", font);
        nameText.CharacterSize = 32;
        nameText.FillColor = new Color(68, 68, 69);
        nameText.Position = new Vector2f(151, 277);

        numberPhoneText = new Text("Номер телефона", font);
        numberPhoneText.CharacterSize = 32;
        numberPhoneText.FillColor = new Color(68, 68, 69);
        numberPhoneText.Position = new Vector2f(151, 445);

        passwordText = new Text("Пароль", font);
        passwordText.CharacterSize = 32;
        passwordText.FillColor = new Color(68, 68, 69);
        passwordText.Position = new Vector2f(151, 610);

        lnameText = new Text("Фамилия", font);
        lnameText.CharacterSize = 32;
        lnameText.FillColor = new Color(68, 68, 69);
        lnameText.Position = new Vector2f(614, 277);

        emailText = new Text("Почта", font);
        emailText.CharacterSize = 32;
        emailText.FillColor = new Color(68, 68, 69);
        emailText.Position = new Vector2f(614, 445);

        repeatPasswordText = new Text("Повторите пароль", font);
        repeatPasswordText.CharacterSize = 32;
        repeatPasswordText.FillColor = new Color(68, 68, 69);
        repeatPasswordText.Position = new Vector2f(614, 610);
        
        warningNameText = new Text("*обязательно", font);
        warningNameText.CharacterSize = 20;
        warningNameText.FillColor = new Color(255, 255, 255);
        warningNameText.Position = new Vector2f(171, 413); 
        
        warningLNameText = new Text("*обязательно", font);
        warningLNameText.CharacterSize = 20;
        warningLNameText.FillColor = new Color(255, 255, 255);
        warningLNameText.Position = new Vector2f(634, 413);        
        
        warningNumberPfoneText = new Text("*обязательно", font);
        warningNumberPfoneText.CharacterSize = 20;
        warningNumberPfoneText.FillColor = new Color(255, 255, 255);
        warningNumberPfoneText.Position = new Vector2f(171, 582);  
        
        warningEmailText = new Text("*обязательно", font);
        warningEmailText.CharacterSize = 20;
        warningEmailText.FillColor = new Color(255, 255, 255);
        warningEmailText.Position = new Vector2f(634, 582);  
        
        warningPasswordText = new Text("*обязательно", font); //необходимы цифры, спецсимволы
        warningPasswordText.CharacterSize = 20;
        warningPasswordText.FillColor = new Color(255, 255, 255);
        warningPasswordText.Position = new Vector2f(171, 746); 
        
        warningRepeatPasswordText = new Text("*обязательно", font); //пароли не совпадают
        warningRepeatPasswordText.CharacterSize = 20;
        warningRepeatPasswordText.FillColor = new Color(255, 255, 255);
        warningRepeatPasswordText.Position = new Vector2f(634, 746);
        
        
        furtherText = new Text("Далее", font);
        furtherText.CharacterSize = 36;
        furtherText.FillColor = new Color(35, 35, 35);
        furtherText.Position = new Vector2f(478, 847);
        
        nameMiniText = new Text("*", font);
        nameMiniText.CharacterSize = 32;
        nameMiniText.FillColor = new Color(255, 255, 255);
        nameMiniText.Position = new Vector2f(171, 350);

        lNameMiniText = new Text("*", font);
        lNameMiniText.CharacterSize = 32;
        lNameMiniText.FillColor = new Color(255, 255, 255);
        lNameMiniText.Position = new Vector2f(634, 350);
        
        
        passwordMiniText = new Text("*", font);
        passwordMiniText.CharacterSize = 32;
        passwordMiniText.FillColor = new Color(255, 255, 255);
        passwordMiniText.Position = new Vector2f(171, 682);
    }
    public void Ivents2(RenderWindow _window)
    {
        
        _window.KeyPressed += OnKeyPressedName;
        
        //_window.KeyPressed += OnKeyPressedLName;
       
        
            _window.KeyPressed += OnKeyPressedPassword;
            
        
        
        
        
    }

    public void IventsWindow2(RenderWindow _window)
    {
        _window.DispatchEvents();
        _window.Closed += (sender, e) => _window.Close();
    }
    public void Display2(RenderWindow _window)
    {
        _window.Clear(new Color(230, 230, 230)); 
            
            
        _window.Draw(fonFrame2);
        _window.Draw(buttonNameSprite);
        _window.Draw(buttonNumberPhoneSprite);
        _window.Draw(buttonPasswordSprite);
        _window.Draw(buttonLNameSprite);
        _window.Draw(buttonEmailSprite);
        _window.Draw(buttonRepeatPasswordSprite);
        _window.Draw(buttonFurtherSprite);
            
        _window.Draw(titleText);
        _window.Draw(nameText);
        _window.Draw(passwordText);
        _window.Draw(lnameText);
        _window.Draw(emailText);
        _window.Draw(repeatPasswordText);
        _window.Draw(numberPhoneText);
        _window.Draw(furtherText);
        _window.Draw(nameMiniText);
        _window.Draw(lNameMiniText);
        _window.Draw(passwordMiniText);
        _window.Draw(warningNameText);
        _window.Draw(warningLNameText);
        _window.Draw(warningPasswordText);
    }

    public void ButtonInteraction(RenderWindow _window)
    {
            if (Mouse.IsButtonPressed(Mouse.Button.Left) && lineName == "" && linePassword != "" && lineName != "" && lineLName != "")
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningNameText.FillColor = new Color(202, 128, 128);
                }
            }
            else if (Mouse.IsButtonPressed(Mouse.Button.Left)  && linePassword != "" && lineName != "" && lineLName != "")
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningNameText.FillColor = new Color(255, 255, 255);
                }
            }
            
            if (Mouse.IsButtonPressed(Mouse.Button.Left) &&  linePassword != "" && lineName != "" && lineLName != "")
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningLNameText.FillColor = new Color(202, 128, 128);
                }
            }
            else if (Mouse.IsButtonPressed(Mouse.Button.Left) && linePassword != "" && lineName != "" && lineLName != "")
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningLNameText.FillColor = new Color(255, 255, 255);
                }
            }
            
            
            if (Mouse.IsButtonPressed(Mouse.Button.Left) && linePassword != "" || nextWindow)
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonPasswordSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningPasswordText.FillColor = new Color(202, 128, 128);
                }
            }
            else if (Mouse.IsButtonPressed(Mouse.Button.Left) && lineLName != "" || nextWindow)
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningLNameText.FillColor = new Color(255, 255, 255);
                }
            }
            
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonNameSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    flagName = true;
                    nameMiniText.FillColor = new Color(68, 68, 67);
                    flagLName = false;
                    flagPassword = false;

                }
            }
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonLNameSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    flagLName = true;
                    lNameMiniText.FillColor = new Color(68, 68, 67);
                    flagName = false;
                    flagPassword = false;
                    
                    

                }
            }
            
            
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonPasswordSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    flagPassword = true;
                    passwordMiniText.FillColor = new Color(68, 68, 67);
                    flagName = false;
                    flagLName = false;
                   
                    

                }
            }


            if (flagName)
            {   
                flagLName = false;
                lineName = line;
              
                float buttonWidth = buttonNameSprite.GetGlobalBounds().Width;

                if (nameMiniText.GetLocalBounds().Width < buttonWidth - 20) 
                {
                    
                    nameMiniText.DisplayedString = lineName;
                    UpdateName(_window);
                    
                }
                else
                {
                    if (lineName.Length > 1)
                    {
                        lineName = lineName.Substring(0, lineName.Length - 1);
                    }
                    flagName = false;
                    
                    
                    
                }
                
                
                
            }
            
            else
            {
                UpdateName(_window);
               
                
            }
            
            if (flagLName)
            {   
                flagName = false;
                
                float buttonWidth = buttonLNameSprite.GetGlobalBounds().Width; 

                if (lNameMiniText.GetLocalBounds().Width < buttonWidth - 20) 
                {
                    lNameMiniText.DisplayedString = lineLName;
                    UpdateLName(_window);
                    

                }
                else
                {
                    if (lineLName.Length > 1)
                    {
                        lineLName = lineLName.Substring(0, lineLName.Length - 1);
                    }
                    flagLName = false;
                    
                }
               
            }
            else
            {
                UpdateName(_window);
                
                
            }
            
            
            if (flagPassword)
            {   
                
                float buttonWidth = buttonPasswordSprite.GetGlobalBounds().Width; // Замените на вашу кнопку

                if (passwordMiniText.GetLocalBounds().Width < buttonWidth - 20) // Учитываем отступы
                {
                    passwordMiniText.DisplayedString = linePassword;
                    UpdatePassword(_window);
                    

                }
                else
                {
                    if (linePassword.Length > 1)
                    {
                        linePassword = linePassword.Substring(0, linePassword.Length - 1);
                    }
                    flagPassword = false;
                    
                }
            }
            else
            {
                UpdatePassword(_window);
            }
            
    }

    public void Run2(RenderWindow _window)
    {
        Structure();
        
        Ivents2(_window);
        
        while (_window.IsOpen)
        {
            IventsWindow2(_window);
            Display2(_window);
            ButtonInteraction(_window);
            
            

            if (Mouse.IsButtonPressed(Mouse.Button.Left)  && linePassword != "" && lineName != "" && lineLName != "")
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    _window.Clear(Color.White);
                    Frame3 frame3 = new Frame3();
                    frame3.Run3(_window);
                    
                }
            }
            
            

            
           
            _window.Display();
            
        }

    }    
       
}