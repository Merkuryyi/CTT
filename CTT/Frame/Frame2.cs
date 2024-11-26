﻿using SFML.Graphics;
using SFML.Window;
using SFML.System;
using CTT;

public class Frame2
{
    private static Texts backFrameText;
    private static Color colorMessage;
    public static int cursorLnamePosition = 0;
    public static int cursorNamePosition = 0;
    public static int cursorPasswordPosition = 0;
    public static int cursorRepeatPasswordPosition = 0;
    public static int cursorNumberPhonePosition = 0;
    public static int cursorEmailPosition = 0;
    
    public static bool flagName;
    public static bool warningFlagName  = false;
    public static bool flagLName;
    public static bool  warningFlagLName  = false;
    public static bool flagPassword;
    public static bool warningFlagPassword = false;
    public static bool flagRepeatPassword;
    public static bool warningFlagRepeatPassword  = false;
    public static bool flagNumberPhone;
    public static bool warningFlagNumberPhone  = false;
    public static bool flagEmail;
    public static bool warningFlagEmail  = false;
    public static bool isVisiblePassword = false;
    public static bool isVisibleRepeatPassword = false;
    private static bool canClick = false;
    
    private static Clock clock;
    private static float clickDelay;
    
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
    public static Texts numberPhoneMiniText;
    public static Texts emailMiniText;
    
    public static string nameMiniTextFrame2;
    public static string lMiniTextFrame2;
    public static string passwordMiniTextFrame2;
    public static string repeatPasswordMiniTextFrame2;
    public static string numberPhoneMiniTextFrame2;
    public static string emailMiniTextFrame2;
    
  
    
    private static Texts warningNameText;
    private static Texts warningLNameText;
    private static Texts warningNumberPfoneText;
    private static Texts warningEmailText;
    private static Texts warningPasswordText;
    private static Texts warningRepeatPasswordText;
    
    private static Color  baseColorText;
    private static Color nullColorText;
    private static Color warningTextColor; 

    
    private static Texture hideOffTexture;
    private static Texture hideOnTexture;
    
    private static int xWarningRightBorderFrame;
    private static int xWarningLeftBorderFrame;
    private static int yLowerMiniText;
    private static int yHideText;
    
    private static Vector2i mousePosition;
    private static InputLine line;

    public void Structure()
    {
        
        clock = new Clock();
        clickDelay = 0.3f;
        line = new InputLine();
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
        int xLeftHideText = 398;
        int xRightHideText = 861;
        
        int yUpperBorderFrame = 336;
        int yLowerBorderFrame = 669;
        int yAvaregeBorderFrame = 505;
        int yPositionButton = 838;
        xWarningLeftBorderFrame = 171;
        xWarningRightBorderFrame = 634;
        int yPositionTitleText = 125;
        int yLowerWarningTextFrame = 749;
        
        
        
        int yUpperWarningText = 416;
        int yAvarageWarningText = 585;
        int yUpperText = 277;
        int yAverageText = 445;
        int yLowerText = 610;
        int yPositionFurtherText = 847;
    
        
        int yUpperMiniText = 350;
        int yAvaregeMiniText = 520;
        yLowerMiniText = 682;
        
        
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
        warningTextColor = new Color(202, 128, 128);
        colorMessage = new Color(136, 136, 136);
        
        string titleTextFrame2 = "Регистрация";
        string nameTextFrame2 = "Имя";
        string numberPhoneTextFrame2 = "Номер телефона";
        string passwordTextFrame2 = "Пароль";
        string lnameTextFrame2 = "Фамилия";
        string emailTextFrame2 = "Почта";
        string repeatPasswordTextFrame2 = "Повторите пароль";
        
      
        
        string furtherTextFrame2 = "Далее";
        nameMiniTextFrame2 = "";
        lMiniTextFrame2 = "";
        passwordMiniTextFrame2 = "";
        repeatPasswordMiniTextFrame2 = "";
        numberPhoneMiniTextFrame2 = "";
        emailMiniTextFrame2 = "";

        string backText = "<назад"; 
        
        titleText = new Texts(xPositionTitleText,yPositionTitleText , 
            font, sizeTextTitleFrame, baseColorText, titleTextFrame2 );
        nameText = new Texts(xLeftBorderFrame, yUpperText, 
            font, sizeTextInput, baseColorText, nameTextFrame2 );
        numberPhoneText = new Texts(xLeftBorderFrame, yAverageText, 
            font, sizeTextMiniTitle, baseColorText, numberPhoneTextFrame2 );
        passwordText  = new Texts(xLeftBorderFrame, yLowerText, 
            font, sizeTextMiniTitle, baseColorText, passwordTextFrame2 );
        lNameText  = new Texts(xRightBorderFrame, yUpperText, 
            font, sizeTextMiniTitle, baseColorText, lnameTextFrame2 );
        emailText  = new Texts(xRightBorderFrame, yAverageText, 
            font, sizeTextMiniTitle, baseColorText, emailTextFrame2 );
        repeatPasswordText  = new Texts(xRightBorderFrame, yLowerText, 
            font, sizeTextMiniTitle, baseColorText, repeatPasswordTextFrame2 );
        
        
            
        warningNameText  = new Texts(xWarningLeftBorderFrame, yUpperWarningText, 
            font, sizeWarningText, warningTextColor, "" );
        warningLNameText = new Texts(xWarningRightBorderFrame, yUpperWarningText, 
            font, sizeWarningText, warningTextColor, "" );
        warningNumberPfoneText = new Texts(xWarningLeftBorderFrame, yAvarageWarningText, 
            font, sizeWarningText, warningTextColor, "" );
        warningEmailText = new Texts(xWarningRightBorderFrame, yAvarageWarningText,
            font, sizeWarningText, warningTextColor, "" );
        warningPasswordText = new Texts(xWarningLeftBorderFrame, yLowerWarningTextFrame,
            font, sizeWarningText,warningTextColor, "" ); 
        warningRepeatPasswordText = new Texts(xWarningRightBorderFrame, yLowerWarningTextFrame,
            font, sizeWarningText,warningTextColor, "" );
        
        furtherText = new Texts(xPositionFurtherText, yPositionFurtherText, 
            font, sizeTextMiniTitle, baseColorText, furtherTextFrame2 );
        nameMiniText = new Texts(xWarningLeftBorderFrame, yUpperMiniText, 
            font, sizeTextInput, baseColorText, nameMiniTextFrame2 );
        lNameMiniText = new Texts(xWarningRightBorderFrame, yUpperMiniText, 
            font, sizeTextInput, baseColorText, lMiniTextFrame2 );
        passwordMiniText = new Texts(xWarningLeftBorderFrame, yLowerMiniText,
            font, sizeTextInput, baseColorText, passwordMiniTextFrame2 );
        repeatPasswordMiniText = new Texts(xWarningRightBorderFrame,yLowerMiniText, font, sizeTextInput, baseColorText, repeatPasswordMiniTextFrame2 );
        numberPhoneMiniText = new Texts(xWarningLeftBorderFrame, yAvaregeMiniText, 
            font, sizeTextInput, baseColorText, numberPhoneMiniTextFrame2);
        emailMiniText = new Texts(xWarningRightBorderFrame, yAvaregeMiniText, 
            font, sizeTextInput, baseColorText,  emailMiniTextFrame2);
        
        backFrameText =   new Texts(151, 914 , font, 24, colorMessage, backText );
      
       

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
        numberPhoneMiniText.Draw(_window);
        emailMiniText.Draw(_window);
        
        warningNameText.Draw(_window);
        warningLNameText.Draw(_window);
        warningPasswordText.Draw(_window);
        warningRepeatPasswordText.Draw(_window);
        warningNumberPfoneText.Draw(_window);
        warningEmailText.Draw(_window);
        backFrameText.Draw(_window);
    }

    public void ButtonInteraction(RenderWindow _window)
    {
        FlagFrames flagFrames = new FlagFrames();
        Vector2i mousePosition = Mouse.GetPosition(_window);
        InputLine line = new InputLine();
        Flags flags = new Flags();
        clic();
       if (Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
           
            if (buttonPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                && !isVisiblePassword )
            {
                isVisiblePassword = true;
                buttonPasswordHideSprite.SetTexture(hideOffTexture);
               
     

            }
            else if (buttonPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                     && isVisiblePassword)
            {
                isVisiblePassword = false;
                buttonPasswordHideSprite.SetTexture(hideOnTexture);
              
               
            }
            if (buttonRepeatPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                && !isVisibleRepeatPassword )
            {
                isVisibleRepeatPassword = true;
                buttonRepeatPasswordHideSprite.SetTexture(hideOffTexture);
               


            }
            else if (buttonRepeatPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                     && isVisibleRepeatPassword)
            {
                isVisibleRepeatPassword = false;
                buttonRepeatPasswordHideSprite.SetTexture(hideOnTexture);
              
                
   
            }

          
           
            if (buttonNameSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagName = true;
                line.parametres(nameMiniText, flagName);
                line.LineParametr(nameMiniTextFrame2, cursorNamePosition);
            }
            else
            {
                flagName = false;
            }
            
            if (buttonLNameSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagLName = true;
                line.parametres(lNameMiniText, flagLName);
                line.LineParametr(lMiniTextFrame2 ,cursorLnamePosition);

      
            }
            else
            { flagLName = false; }
            if (buttonPasswordSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagPassword = true;
                line.parametres(passwordMiniText, flagPassword);
                line.LineParametr(passwordMiniTextFrame2 ,cursorPasswordPosition);
 
            }
            else
            { flagPassword = false; }
            if (buttonRepeatPasswordSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                line.parametres(repeatPasswordMiniText, flagRepeatPassword);
                line.LineParametr(repeatPasswordMiniTextFrame2, cursorRepeatPasswordPosition);
                flagRepeatPassword = true;
              
                
                
            }
            else
            {
                flagRepeatPassword = false;
            }
            if (buttonNumberPhoneSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagNumberPhone = true;
                line.parametres(numberPhoneMiniText, flagNumberPhone);
                line.LineParametr(numberPhoneMiniTextFrame2 ,cursorNumberPhonePosition);

            }
            else
            {
                flagNumberPhone = false;
                
            }
            if (buttonEmailSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) )
            {
                flags.changeFlag();
                flagEmail = true;
                line.parametres(emailMiniText, flagEmail);
                line.LineParametr(emailMiniTextFrame2 ,cursorEmailPosition);


            }
            else
            {
                flagEmail = false;
            }
            
            if (backFrameText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagFrames.ChangeFlagsFrame();
                MainForm.frame1 = true;
            }
            canClick = false;
            clock.Restart(); 
            
            
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
                lMiniTextFrame2 = line.GetLine();
                cursorLnamePosition = line.GetCursor();
                lNameMiniText.SetText(lMiniTextFrame2);
                line.Update(_window);
            }
            
            if (flagPassword)
            {
                passwordMiniTextFrame2 = line.GetLine();
                cursorPasswordPosition = line.GetCursor();
                
                if (!isVisiblePassword)
                {
                   passwordMiniText.HideText(passwordMiniTextFrame2); 
                   passwordMiniText.SetPosition(xWarningLeftBorderFrame, yHideText);
                }
                else if (isVisiblePassword)
                {
                    
                   passwordMiniText.SetText(passwordMiniTextFrame2); 
                   passwordMiniText.SetPosition(xWarningLeftBorderFrame, yLowerMiniText);
                    
                }
               
            }
            if (flagRepeatPassword)
            {
                
                repeatPasswordMiniTextFrame2 = line.GetLine();
                cursorRepeatPasswordPosition = line.GetCursor();
                
                if (!isVisibleRepeatPassword)
                {
                    repeatPasswordMiniText.HideText(repeatPasswordMiniTextFrame2); 
                    repeatPasswordMiniText.SetPosition( xWarningRightBorderFrame, yHideText);
                }
                else if (isVisibleRepeatPassword)
                {
                  
                    repeatPasswordMiniText.SetText(repeatPasswordMiniTextFrame2); 
                    repeatPasswordMiniText.SetPosition( xWarningRightBorderFrame, yLowerMiniText);
                    
                }
               

                line.Update(_window);
                
                
            }
            
            if (flagNumberPhone)
            {
                
                numberPhoneMiniTextFrame2 = line.GetLine();
                numberPhoneMiniText.SetText(numberPhoneMiniTextFrame2);
                cursorNumberPhonePosition = line.GetCursor();
                line.Update(_window);   
            }
            if (flagEmail)
            {
                
                emailMiniTextFrame2 = line.GetLine();
                emailMiniText.SetText(emailMiniTextFrame2);
                cursorEmailPosition = line.GetCursor();
                line.Update(_window);   
                
            }
            
            Warning(_window);
           
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                mousePosition = Mouse.GetPosition(_window);
                if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) && 
                    !warningFlagName && 
                    !warningFlagLName && 
                    !warningFlagEmail && 
                    !warningFlagNumberPhone &&
                    !warningFlagPassword &&
                    !warningFlagRepeatPassword)
                {
                    flagFrames.ChangeFlagsFrame();
                    _window.Clear(Color.White);
                    MainForm.frame3 = true;
                    line.clearLine();

                }
            } 
         
    }
    public void clic()
    {
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
            canClick = true;
        }
    }
    public void Warning(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
        line = new InputLine();
        Warnings warnings = new Warnings();
        clic();
        if (Mouse.IsButtonPressed(Mouse.Button.Left) &&
            buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
        {

            warningNameText.SetText(warnings.WarningLineName(nameMiniTextFrame2));
            warningFlagName = warnings.getWarningFlag();
         
            warningLNameText.SetText(warnings.WarningLineName(lMiniTextFrame2));
            warningFlagLName = warnings.getWarningFlag();
            
            warningNumberPfoneText.SetText(warnings.WarningLineNumberPhone(numberPhoneMiniTextFrame2));
            warningFlagNumberPhone = warnings.getWarningFlag();

            
            warningPasswordText.SetText(warnings.WarningLinePassword(passwordMiniTextFrame2));
            warningFlagPassword = warnings.getWarningFlag();
            
            warningRepeatPasswordText.SetText(warnings.WarningLineRepeatPassword(repeatPasswordMiniTextFrame2, passwordMiniTextFrame2));
            warningFlagRepeatPassword = warnings.getWarningFlag();

            warningEmailText.SetText(warnings.WarningLineEmail(emailMiniTextFrame2));
            warningFlagEmail = warnings.getWarningFlag();
        }
    }
  

    public void workProgram(RenderWindow _window)
    {
       // _window.KeyPressed += line.OnKeyPressedName;
       
      
            Display2(_window);
            ButtonInteraction(_window);

            
     

    }    
    
       
}