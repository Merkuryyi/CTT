using SFML.Graphics;
using SFML.Window;
using SFML.System;
using CTT;

public class Frame2
{
    public static int cursorLnamePosition;
    public static int cursorNamePosition;
    public static int cursorPasswordPosition;
    public static int cursorRepeatPasswordPosition;
    
    public static bool flagName;
    public static bool flagLName;
    public static bool flagPassword;
    public static bool flagRepeatPassword;
    public static bool isVisiblePassword = false;
    public static bool isVisibleRepeatPassword = false;
    public static Button buttonNameSprite;
    public static Button buttonLNameSprite;
    public static Button buttonNumberPhoneSprite;
    
    public static Button buttonEmailSprite;
    public static Button buttonPasswordSprite;
    
    public static Button buttonRepeatPasswordSprite;
    
    private static Button backgroundFrame;
    private static Button buttonPasswordHideSprite;
    private static Button buttonRepeatPasswordHideSprite;
    
    private static Button buttonFurtherSprite;
    
    private static Texts titleText;
    private static Texts nameText;
    private static Texts numberPhoneText;
    private static Texts passwordText;
    private static Texts repeatPasswordText;
    private static Texts lNameText;
    private static Texts emailText;
    private static Texts furtherText;
    
    public static Texts nameMiniText;
    public static Texts lNameMiniText;
    public static Texts passwordMiniText;
    public static Texts repeatPasswordMiniText;
   
    public static string nameMiniTextFrame2;
    public static string lMiniTextFrame2;
    public static string passwordMiniTextFrame2;
    public static string repeatPasswordMiniTextFrame2;
    public static string warningRepeatPasswordTextFrame2;
    
    
    
    private static Texts warningNameText;
    private static Texts warningLNameText;
    private static Texts warningNumberPfoneText;
    private static Texts warningEmailText;
    private static Texts warningPasswordText;
    private static Texts warningRepeatPasswordText;
    
    private static Color  baseColorText;
    private static Color nullColorText;
    private static Color warningTextColor; 
    private static Color baseColorTextOff;  
    private static Color colorText;

    private static string repeatPasswordTextFrame2;

    private static Texture hideOffTexture;
    private static Texture hideOnTexture;

    private static Clock clock;
    private static bool canClick = false;

    private static float clickDelay;

  private static int xWarningLeftBorderFrame;
  private static int yLowerMiniText;
  private static int yHideText;
   

    private static int xWarningRightBorderFrame;
    
                //Hyphen(-) Equal(+) LBracket([) RBracket(]) Semicolon Quote BackSlash Comma Period Slash Tilde 

    public void Structure()
    {
        
        clock = new Clock();
        clickDelay = 0.3f;
        
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        Texture background = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundRegistration.png"));
        Texture emptyButtonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
        Texture buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
        hideOffTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "hideOff.png"));
        hideOnTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "hideOn.png"));
        
        int xyPositionBackground = 53; 
        int xLeftBorderFrame = 151;
        int xRightBorderFrame = 614;
        int xPositionTitleText = 138;
        int xPositionButton = 386;
        int xPositionFurtherText = 478; 
        
        
        int yUpperBorderFrame = 336;
        int yLowerBorderFrame = 669;
        int yAvaregeBorderFrame = 505;
        int yPositionButton = 838;
        xWarningLeftBorderFrame = 171;
        xWarningRightBorderFrame = 634;
        int yPositionTitleText = 125;
        int yLowerWarningTextFrame = 746;
        int yUpperMiniText = 350;
        yLowerMiniText = 682;
        int yUpperWarningText = 413;
        int yAvarageWarningText = 582;
        int yUpperText = 277;
        int yAverageText = 445;
        int yLowerText = 610;
        int yPositionFurtherText = 847;
        int xLeftHideText = 398;
        int xRightHideText = 861;
        yHideText = 688;
        uint sizeTextMax = 64;
        uint sizeTextTitleFrame = 48;
        uint sizeTextMiniTitle = 36;
        uint sizeTextInput = 32;
        uint sizeWarningText = 20;
        
        
        backgroundFrame = new Button(xyPositionBackground, xyPositionBackground, background);
        buttonNameSprite = new Button(xLeftBorderFrame, yUpperBorderFrame, emptyButtonTexture);
        buttonNumberPhoneSprite = new Button(xLeftBorderFrame, yAvaregeBorderFrame,  emptyButtonTexture);
        buttonPasswordSprite = new Button(xLeftBorderFrame, yLowerBorderFrame,  emptyButtonTexture);
        buttonLNameSprite = new Button(xRightBorderFrame, yUpperBorderFrame,  emptyButtonTexture);
        buttonEmailSprite= new Button(xRightBorderFrame, yAvaregeBorderFrame,  emptyButtonTexture);
        buttonRepeatPasswordSprite = new Button(xRightBorderFrame, yLowerBorderFrame,   emptyButtonTexture);
        buttonFurtherSprite = new Button(xPositionButton, yPositionButton,  buttonTexture);
        buttonPasswordHideSprite = new Button(xLeftHideText, yHideText,  hideOnTexture);
        buttonRepeatPasswordHideSprite = new Button(xRightHideText, yHideText,  hideOnTexture);
        

        baseColorText = new Color(68, 68, 69);
        nullColorText = new Color(255,255, 255);
        colorText = new Color(0, 0, 0);
        baseColorTextOff = new Color(130,130,130);
        warningTextColor = new Color(202, 128, 128);

        string titleTextFrame2 = "Регистрация";
        string nameTextFrame2 = "Имя";
        string numberPhoneTextFrame2 = "Номер телефона";
        string passwordTextFrame2 = "Пароль";
        string lnameTextFrame2 = "Фамилия";
        string emailTextFrame2 = "Почта";
        string repeatPasswordTextFrame2 = "Повторите пароль";
        
        string warningTextFrame2 = "*обязательно";
        string warningLenghNameTextFrame2 = "*более 2х символов";
        string warningLenghLNameTextFrame2 = "*более 3х символов";
        warningRepeatPasswordTextFrame2 = "*пароли не совпадают";
        string warningPasswordTextFrame2 = "необходимы цифры, спецсимволы";
        string furtherTextFrame2 = "Далее";
        nameMiniTextFrame2 = "";
        lMiniTextFrame2 = "";
        passwordMiniTextFrame2 = "";
        repeatPasswordMiniTextFrame2 = "";
        
        titleText = new Texts(xPositionTitleText,yPositionTitleText , font, sizeTextTitleFrame, baseColorText, titleTextFrame2 );
        nameText = new Texts(xLeftBorderFrame, yUpperText, font, sizeTextInput, baseColorText, nameTextFrame2 );
        numberPhoneText = new Texts(xLeftBorderFrame, yAverageText, font, sizeTextMiniTitle, baseColorText, numberPhoneTextFrame2 );
        passwordText  = new Texts(xLeftBorderFrame, yLowerText, font, sizeTextMiniTitle, baseColorText, passwordTextFrame2 );
        lNameText  = new Texts(xRightBorderFrame, yUpperText, font, sizeTextMiniTitle, baseColorText, lnameTextFrame2 );
        emailText  = new Texts(xRightBorderFrame, yAverageText, font, sizeTextMiniTitle, baseColorText, emailTextFrame2 );
        repeatPasswordText  = new Texts(xRightBorderFrame, yLowerText, font, sizeTextMiniTitle, baseColorText, repeatPasswordTextFrame2 );
        
        warningNameText  = new Texts(xWarningLeftBorderFrame, yUpperWarningText, font, sizeWarningText, nullColorText, warningTextFrame2 );
        warningLNameText = new Texts(xWarningRightBorderFrame, yUpperWarningText, font, sizeWarningText, nullColorText, warningTextFrame2 );
        warningNumberPfoneText = new Texts(xWarningLeftBorderFrame, yAvarageWarningText, font, sizeWarningText, nullColorText, warningTextFrame2 );
        warningEmailText = new Texts(xWarningRightBorderFrame, yAvarageWarningText, font, sizeWarningText, nullColorText, warningTextFrame2 );
        warningPasswordText = new Texts(xWarningLeftBorderFrame, yLowerWarningTextFrame, font, sizeWarningText, nullColorText, warningTextFrame2 ); 
        warningRepeatPasswordText = new Texts(xWarningRightBorderFrame, yLowerWarningTextFrame, font, sizeWarningText, nullColorText, warningTextFrame2 );
        
        furtherText = new Texts(xPositionFurtherText, yPositionFurtherText, font, sizeTextMiniTitle, baseColorText, furtherTextFrame2 );
        nameMiniText = new Texts(xWarningLeftBorderFrame, yUpperMiniText, font, sizeTextInput, baseColorText, nameMiniTextFrame2 );
        lNameMiniText = new Texts(xWarningRightBorderFrame, yUpperMiniText, font, sizeTextInput, baseColorText, lMiniTextFrame2 );
        passwordMiniText = new Texts(xWarningLeftBorderFrame, yLowerMiniText, font, sizeTextInput, baseColorText, passwordMiniTextFrame2 );
        repeatPasswordMiniText = new Texts(xWarningRightBorderFrame,yLowerMiniText, font, sizeTextInput, baseColorText, repeatPasswordMiniTextFrame2 );
        

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
        buttonPasswordHideSprite.Draw(_window);
        buttonRepeatPasswordHideSprite.Draw(_window);
        titleText.Draw(_window);
        nameText.Draw(_window);
        passwordText.Draw(_window);
        repeatPasswordText.Draw(_window);
        lNameText.Draw(_window);
        emailText.Draw(_window);
        numberPhoneText.Draw(_window);
        furtherText.Draw(_window);
        nameMiniText.Draw(_window);
        lNameMiniText.Draw(_window);
        passwordMiniText.Draw(_window);
        repeatPasswordMiniText.Draw(_window);
       
        
        warningNameText.Draw(_window);
        warningLNameText.Draw(_window);
        warningPasswordText.Draw(_window);
        warningRepeatPasswordText.Draw(_window);
    
    }

    public void ButtonInteraction(RenderWindow _window)
    {
        Vector2i mousePosition = Mouse.GetPosition(_window);
       
            InputLine line = new InputLine();
       
           if (Mouse.IsButtonPressed(Mouse.Button.Left) && !canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
            {
               
                if (buttonPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) && !isVisiblePassword )
                {
                    isVisiblePassword = true;
                    buttonPasswordHideSprite.SetTexture(hideOffTexture);
                    clock.Restart();
                    canClick = false;
                    line.ClearLine();

                }
                else if (buttonPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) && isVisiblePassword)
                {
                    isVisiblePassword = false;
                    buttonPasswordHideSprite.SetTexture(hideOnTexture);
                    clock.Restart();
                    canClick = false;
                    line.ClearLine();
                }
               
                
            }
            if (Mouse.IsButtonPressed(Mouse.Button.Left) && !canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
            {
               
                if (buttonRepeatPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) && !isVisibleRepeatPassword )
                {
                    isVisibleRepeatPassword = true;
                    buttonRepeatPasswordHideSprite.SetTexture(hideOffTexture);
                    clock.Restart();
                    canClick = false;
                    line.ClearLine();

                }
                else if (buttonRepeatPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) && isVisibleRepeatPassword)
                {
                    isVisibleRepeatPassword = false;
                    buttonPasswordHideSprite.SetTexture(hideOnTexture);
                    clock.Restart();
                    canClick = false;
                    line.ClearLine();
                }
               
                
            }
           
           
           
         
            
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
               
                if (buttonNameSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    flagName = true;
                    nameMiniText.SetColor(baseColorText); 
                    flagLName = false;
                    flagPassword = false;
                    line.ClearLine();
                    

                }
                else
                {
                    flagName = false;
                    
                }
            }
          
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                if (buttonLNameSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    flagLName = true;
                    lNameMiniText.SetColor(baseColorText); 
                    flagName = false;
                    flagPassword = false;
                    line.ClearLine();
                }
                else
                {
                    flagLName = false;
                }
            }
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
               
                if (buttonPasswordSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    flagPassword = true;
                    passwordMiniText.SetColor(baseColorText); 
                    flagName = false;
                    flagLName = false;
                    line.ClearLine();
                }
                else
                {
                    flagPassword = false;
                }
            }
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                
                if (buttonLNameSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    flagLName = true;
                    lNameMiniText.SetColor(baseColorText); 
                    flagName = false;
                    flagPassword = false;
                    line.ClearLine();
                }
                else
                {
                    flagLName = false;
                }
            }
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
               
                if (buttonRepeatPasswordSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    flagRepeatPassword = true;
                    repeatPasswordMiniText.SetColor(baseColorText); 
                    flagName = false;
                    flagLName = false;
                    flagPassword = false;
                    line.ClearLine();
                    
                    
                }
                else
                {
                    flagRepeatPassword = false;
                }
            }
            
           
            if (flagName)
            {
                   nameMiniTextFrame2 = line.GetLine();
                   nameMiniText.SetText(nameMiniTextFrame2);
                   cursorNamePosition = line.GetCursor();
                   line.Update(_window);   
                
            }
            
          
            if (flagLName)
            {   
                flagName = false;
                flagPassword = false;
                flagRepeatPassword = false;
                    
                    lMiniTextFrame2 = line.GetLine();
                    cursorLnamePosition = line.GetCursor();
                    lNameMiniText.SetText(lMiniTextFrame2);
                    line.Update(_window);
                
            }
            
            if (flagPassword)
            {
                flagName = false;
                flagLName = false;
                flagRepeatPassword = false;
                
                passwordMiniTextFrame2 = line.GetLine();
                cursorPasswordPosition = line.GetCursor();
                line.Update(_window);
                if (!isVisiblePassword)
                {
                    line.Update(_window);
                   passwordMiniText.HideText(passwordMiniTextFrame2); 
                   passwordMiniText.SetPosition(xWarningLeftBorderFrame, yHideText);
                }
                else if (isVisiblePassword)
                {
                    line.Update(_window);
                   passwordMiniText.SetText(passwordMiniTextFrame2); 
                   passwordMiniText.SetPosition(xWarningLeftBorderFrame, yLowerMiniText);
                    
                }

                   
                
            }
            if (flagRepeatPassword)
            {
                flagName = false;
                flagLName = false;
                flagPassword = false;
                
                repeatPasswordMiniTextFrame2 = line.GetLine();
                cursorRepeatPasswordPosition = line.GetCursor();
                line.Update(_window);
                
                if (!isVisibleRepeatPassword)
                {
                    line.Update(_window);
                    repeatPasswordMiniText.HideText(repeatPasswordMiniTextFrame2); 
                    repeatPasswordMiniText.SetPosition( xWarningRightBorderFrame, yHideText);
                }
                else if (isVisibleRepeatPassword)
                {
                    line.Update(_window);
                    repeatPasswordMiniText.SetText(repeatPasswordMiniTextFrame2); 
                    repeatPasswordMiniText.SetPosition( xWarningRightBorderFrame, yLowerMiniText);
                    
                }

                   
                
            }
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) && passwordMiniTextFrame2 != repeatPasswordTextFrame2)
                {
                    warningRepeatPasswordText.SetText(warningRepeatPasswordTextFrame2);
                    warningRepeatPasswordText.SetColor(warningTextColor);
                    
                    warningPasswordText.SetText(warningRepeatPasswordTextFrame2);
                    warningPasswordText.SetColor(warningTextColor);
                    
                }
                else
                {
                   
                    warningRepeatPasswordText.SetColor(nullColorText);
                  
                    warningPasswordText.SetColor(nullColorText);
                }
                
            }
            
           
            
        
            if (Mouse.IsButtonPressed(Mouse.Button.Left) && nameMiniTextFrame2 == "" )
            {
              
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningNameText.SetColor(warningTextColor);
                }
            }
            else if (Mouse.IsButtonPressed(Mouse.Button.Left) && nameMiniTextFrame2 != "")
            {
               
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningNameText.SetColor(nullColorText);
                }
            }
            
            if (Mouse.IsButtonPressed(Mouse.Button.Left) && lMiniTextFrame2 == "" )
            {
              
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningLNameText.SetColor(warningTextColor);
                }
            }
            else if (Mouse.IsButtonPressed(Mouse.Button.Left) && lMiniTextFrame2 != "")
            {
               
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningLNameText.SetColor(nullColorText);
                }
            }
            
            
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) && passwordMiniTextFrame2 == "")
                {
                    warningPasswordText.SetColor(warningTextColor);
                }
            }
            else if (Mouse.IsButtonPressed(Mouse.Button.Left) && passwordMiniTextFrame2 != "" )
            { 
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    warningLNameText.SetColor(nullColorText);
                }
            }
            
            
    }

  

    public void Run2(RenderWindow _window)
    {
        InputLine line = new InputLine();
        
        _window.KeyPressed += line.OnKeyPressedName;
        

        Structure();
        
        
        while (_window.IsOpen)
        {
            IventsWindow2(_window);
            Display2(_window);
            ButtonInteraction(_window);


         /*  if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    _window.Clear(Color.White);
                    Frame3 frame3 = new Frame3();
                    frame3.Run3(_window);
                    
                }
       } */
            
            

            
           
            _window.Display();
            
        }

    }    
       
}