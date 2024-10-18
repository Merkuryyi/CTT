using SFML.Graphics;
using SFML.Window;
using SFML.System;
using CTT;

public class Frame2
{
    private static bool nextWindow;
    
    private static string lineName = "";
    private static int cursorPosition = 0;
    private static bool flagName = false;
   
    
    
    private static Button buttonNameSprite;
    private static Button backgroundFrame;
    private static Texts nameMiniText;
    
    private static int cursorLnamePosition = 0;
    private static Texts lNameMiniText;
   
    private static bool flagLName = false;
    private static Button buttonLNameSprite;
    private static string lineLName = "";
    private static Texts cursorLname;
    
 
    
    private static bool flagPassword = false;
    private static Button buttonPasswordSprite;
    private static string linePassword = "";
    private static int cursorPasswordPosition = 0;
    private static Texts passwordMiniText;
    
    private static Font font;
   

    private static Button buttonNumberPhoneSprite;
    private static Button buttonEmailSprite;
    private static Button buttonRepeatPasswordSprite;
    private static Button buttonFurtherSprite;
    private static Texts titleText;
    private static Texts nameText;
    private static Texts numberPhoneText;
    private static Texts passwordText;
    private static Texts lnameText;
    private static Texts emailText;
    private static Texts repeatPasswordText;
    private static Texts warningNameText;
    private static Texts warningLNameText;
    private static Texts warningNumberPfoneText;
    private static Texts warningEmailText;
    private static Texts warningPasswordText;
    private static Texts warningRepeatPasswordText;
    private static Texts furtherText;
    
  
                
                
                //Hyphen(-) Equal(+) LBracket([) RBracket(]) Semicolon Quote BackSlash Comma Period Slash Tilde 

    public void Structure()
    {
        font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        Texture background = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fonRegistration.png"));
        Texture emptyButtonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
        Texture buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));

        int xLeftBorderFrame = 151;
        int xRightBorderFrame = 614;
        
        int yUpperBorderFrame = 336;
        int yLowerBorderFrame = 669;
        
        int yAvaregeBorderFrame = 505;
        
        int xPositionButton = 386;
        int yPositionButton = 838;
        int yWarningLeftBorderFrame = 171;
        int yWarningRightBorderFrame = 634;
        
        uint sizeTextMax = 64;
        uint sizeTextTitleFrame = 48;
        uint sizeTextMiniTitle = 36;
        uint sizeTextInput = 32;
        backgroundFrame = new Button(53, 53, background);
        buttonNameSprite = new Button(xLeftBorderFrame, yUpperBorderFrame, emptyButtonTexture);
        buttonNumberPhoneSprite = new Button(xLeftBorderFrame, yAvaregeBorderFrame,  emptyButtonTexture);
        buttonPasswordSprite = new Button(xLeftBorderFrame, yLowerBorderFrame,  emptyButtonTexture);
        buttonLNameSprite = new Button(xRightBorderFrame, yUpperBorderFrame,  emptyButtonTexture);
        buttonEmailSprite= new Button(xRightBorderFrame, yAvaregeBorderFrame,  emptyButtonTexture);
        buttonRepeatPasswordSprite = new Button(xRightBorderFrame, yLowerBorderFrame,   emptyButtonTexture);
        
        buttonFurtherSprite = new Button(xPositionButton, yPositionButton,  buttonTexture);
        
        
        

        Color baseColorText = new Color(68, 68, 69);
        Color nullColorText = new Color(255,255, 255);
        Color colorText = new Color(0, 0, 0);

        string titleTextFrame2 = "Регистрация";
        string nameTextFrame2 = "Имя";
        string numberPhoneTextFrame2 = "Номер телефона";
        string passwordTextFrame2 = "Пароль";
        string lnameTextFrame2 = "Фамилия";
        string emailTextFrame2 = "Почта";
        string repeatPasswordTextFrame2 = "Повторите пароль";
        string warningTextFrame2 = "*обязательно";
        string warningRepeatPasswordTextFrame2 = "пароли не совпадают";
        string warningPasswordTextFrame2 = "необходимы цифры, спецсимволы";
        string furtherTextFrame2 = "Далее";
        string miniTextFrame2 = "*";
        
        titleText = new Texts(138, 125, font, sizeTextTitleFrame, baseColorText, titleTextFrame2 );
        
        nameText = new Texts(xLeftBorderFrame, 277, font, 32, baseColorText, nameTextFrame2 );

        numberPhoneText = new Texts(xLeftBorderFrame, 445, font, sizeTextMiniTitle, baseColorText, numberPhoneTextFrame2 );
        passwordText  = new Texts(xLeftBorderFrame, 610, font, sizeTextMiniTitle, baseColorText, passwordTextFrame2 );
        lnameText  = new Texts(xRightBorderFrame, 277, font, sizeTextMiniTitle, baseColorText, lnameTextFrame2 );
        emailText  = new Texts(xRightBorderFrame, 445, font, sizeTextMiniTitle, baseColorText, emailTextFrame2 );
        repeatPasswordText  = new Texts(xRightBorderFrame, 610, font, sizeTextMiniTitle, baseColorText, repeatPasswordTextFrame2 );
       
        warningNameText  = new Texts(yWarningLeftBorderFrame, 413, font, 20, nullColorText, warningTextFrame2 );
        warningLNameText = new Texts(yWarningRightBorderFrame, 413, font, 20, nullColorText, warningTextFrame2 );
          
        warningNumberPfoneText = new Texts(yWarningLeftBorderFrame, 582, font, 20, nullColorText, warningTextFrame2 );
            
        warningEmailText = new Texts(yWarningRightBorderFrame, 582, font, 20, nullColorText, warningTextFrame2 );
        warningPasswordText = new Texts(yWarningLeftBorderFrame, 746, font, 20, nullColorText, warningTextFrame2 ); 
        warningPasswordText = new Texts(yWarningLeftBorderFrame, 746, font, 20, nullColorText, warningPasswordTextFrame2 );
        warningRepeatPasswordText = new Texts(yWarningRightBorderFrame, 746, font, 20, nullColorText, warningTextFrame2 );
        warningRepeatPasswordText = new Texts(yWarningRightBorderFrame, 746, font, 20, nullColorText, warningRepeatPasswordTextFrame2 );    
        
        furtherText = new Texts(478, 847, font, sizeTextMiniTitle, baseColorText, furtherTextFrame2 );
        
        nameMiniText = new Texts(yWarningLeftBorderFrame, 350, font, sizeTextInput, nullColorText, miniTextFrame2 );
        
        lNameMiniText = new Texts(yWarningRightBorderFrame, 350, font, sizeTextInput, nullColorText, miniTextFrame2 );
       
        passwordMiniText = new Texts(yWarningLeftBorderFrame, 682, font, sizeTextInput, nullColorText, miniTextFrame2 );
        
        
    }
    public void Ivents2(RenderWindow _window)
    {
        
       // 
        
        //_window.KeyPressed += OnKeyPressedLName;
       
        
           // _window.KeyPressed += OnKeyPressedPassword;
            
        
        
        
        
    }

    public void IventsWindow2(RenderWindow _window)
    {
        _window.DispatchEvents();
        _window.Closed += (sender, e) => _window.Close();
    }
    public void Display2(RenderWindow _window)
    {
        _window.Clear(new Color(230, 230, 230)); 
            
            
        backgroundFrame.Draw(_window);
        buttonNameSprite.Draw(_window); 
        buttonNumberPhoneSprite.Draw(_window);
        
        buttonPasswordSprite.Draw(_window);
        buttonLNameSprite.Draw(_window);
        buttonNumberPhoneSprite.Draw(_window);
        buttonEmailSprite.Draw(_window);
        buttonFurtherSprite.Draw(_window);
        buttonRepeatPasswordSprite.Draw(_window);
      
        
        titleText.Draw(_window);
        nameText.Draw(_window);
        passwordText.Draw(_window);
        lnameText.Draw(_window);
        emailText.Draw(_window);
        numberPhoneText.Draw(_window);
        furtherText.Draw(_window);
        nameMiniText.Draw(_window);
        lNameMiniText.Draw(_window);
        passwordMiniText.Draw(_window);
        warningNameText.Draw(_window);
        warningLNameText.Draw(_window);
        warningPasswordText.Draw(_window);
        
    
    }

    public void ButtonInteraction(RenderWindow _window)
    {
            if (Mouse.IsButtonPressed(Mouse.Button.Left) && lineName == "" && linePassword != "" && lineName != "" && lineLName != "")
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningNameText.TextColor = new Color(202, 128, 128);
                }
            }
            else if (Mouse.IsButtonPressed(Mouse.Button.Left)  && linePassword != "" && lineName != "" && lineLName != "")
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningNameText.TextColor = new Color(255, 255, 255);
                }
            }
            
            if (Mouse.IsButtonPressed(Mouse.Button.Left) &&  linePassword != "" && lineName != "" && lineLName != "")
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningLNameText.TextColor = new Color(202, 128, 128);
                }
            }
            else if (Mouse.IsButtonPressed(Mouse.Button.Left) && linePassword != "" && lineName != "" && lineLName != "")
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningLNameText.TextColor = new Color(255, 255, 255);
                }
            }
            
            
            if (Mouse.IsButtonPressed(Mouse.Button.Left) && linePassword != "" || nextWindow)
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonPasswordSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningPasswordText.TextColor = new Color(202, 128, 128);
                }
            }
            else if (Mouse.IsButtonPressed(Mouse.Button.Left) && lineLName != "" || nextWindow)
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningLNameText.TextColor = new Color(255, 255, 255);
                }
            }
            
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonNameSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    flagName = true;
                    nameMiniText.TextColor = new Color(68, 68, 67);
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
                    lNameMiniText.TextColor = new Color(68, 68, 67);
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
                    passwordMiniText.TextColor = new Color(68, 68, 67);
                    flagName = false;
                    flagLName = false;
                   
                    

                }
            }


          /*  if (flagName)
            {   
                flagLName = false;
                lineName = line;
              
                float buttonWidth = buttonNameSprite.GetGlobalBounds().Width;

                if (nameMiniText.GetGlobalBounds().Width < buttonWidth - 20) 
                {
                    
                    nameMiniText.SetText(lineName) ;
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
                
                
                
            }*/
            
           /* else
            {
                UpdateName(_window);
               
                
            }*/
            /*
            if (flagLName)
            {   
                flagName = false;
                
                float buttonWidth = buttonLNameSprite.GetGlobalBounds().Width; 

                if (lNameMiniText.GetGlobalBounds().Width < buttonWidth - 20) 
                {
                    lNameMiniText.SetText = lineLName;
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

                if (passwordMiniText.GetGlobalBounds().Width < buttonWidth - 20) // Учитываем отступы
                {
                    passwordMiniText.SetText = linePassword;
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
            */
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