using System.ComponentModel;
using CTT;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Frame4
{
    private static Texture buttonRestoreAccessTexture;
    private static Texture buttonRestoreAccessTextureOff;
    private static Texture buttonTexture;
    public static int cursorEmailPositionRestoreAccess;
    public static int cursorNumberPhonePositionRestoreAccess;
    public static int cursorNumberPhonePosition;
    private static Button buttonPasswordHideSpriteRestoreAcess;
    private static Texts numberPhoneMiniTextFrameRestoreAccess;
    private static Texts emailMiniTextFrameRestoreAccess;
    private static Texts warningPasswordTextRestoreAccess;

    private static Button buttonPasswordHideSprite;
    private static Button buttonRepeatPasswordHideSprite;

    private static Button buttonEmptyRepeatPasswordSpriteRestoreAccess;
    private static Button buttonEmptyPasswordSpriteRestoreAccess;
   
    private static Button buttonOffSpriteRestoreAccess;

    private static Button buttonEmptyEmailSpriteRestoreAccess;
    private static Button buttonRequestСodeNumberPhoneSpriteRestoreAccess;
    private static Button buttonRequestСodeEmailSpriteRestoreAccess;
    private static Button buttonRestoreAccessSprite;
    private static Button buttonEmptyNumberPfoneSpriteRestoreAccess;
    private static Button backgroundFrame;
    private static Button buttonSprite;
    public static Button buttonEmptyNumberPhoneSprite;
    private static Button buttonEmptyEmailSprite;
    private static Button buttonEmptyPasswordSprite;
    


    private static Button backgroundFrameRestoreAccess;

    private static Texts emailMiniTextRestoreAccess;
    private static Texts numberPhoneMiniTextRestoreAccess;
    private static Texts titleRepeatPasswordTextMiniRestoreAccess;
    private static Texts titlePasswordTextMiniRestoreAccess;
    private static Texts warningEmailTextRestoreAccess;
    private static Texts warningNumberPhoneTextRestoreAccess;

    private static Texts restoreAccessTextRestoreAccess;
    private static Texts textRestoreAccess;
   
    private static Texts requestСodeEmailTextRestoreAccess;
    private static Texts titleRequestСodeEmailTextMiniRestoreAccess;
    private static Texts requestСodeNumberPhoneTextRestoreAccess;
    private static Texts titleRequestСodeNumberPhoneTextMiniRestoreAccess;
    private static Texts titleTextRestoreAccess;

    private static Texts warningNumberPhoneText;
    private static Texts warningEmailText;

    private static Texts titleText;
    private static Texts numberPhoneText;
    private static Texts emailText;
    private static Texts passwordText;
    private static Texts warningFalseText;
    private static Texts warningFalseText2;
    private static Texts loginText;
   
    
    public static Texts passwordMiniText;
    public static Texts emailMiniText;
    public static Texts numberPhoneMiniText;


    private static string warningText;
    public static string warningFormat;
    public static string codeTrue;
    public static string codeFalse;
    private static string emailMiniTextFrame3RestoreAccess;
    private static string numberPhoneMiniTextFrame3RestoreAccess;
    
    public static string numberPhoneMiniTextFrame;
    private static string emailMiniTextFrame;
    private static string passwordMiniTextFrame;
    private static string warningTextFrame;
    private static string  numberPhoneMiniTextCodeFrame;
    private static string emailMiniTextCodeFrame;

    private static Color baseColorText;
    private static Color warningTextColor;
    private static Color colorText;
    private static Color nullColorText;
    private static Color trueWarningTextColor;
    private static Color colorMessage;
    
    private static Texture requestСodeOffTexture;
    private static Texture requestСodeTexture;
    private static Texture buttonTextureOff;
  
    private static Texture hideOffTexture;
    private static Texture hideOnTexture;
    
    private static Clock clock;
    private static float clickDelay;
    
    public static bool flagNumberPhone = false;
    public static bool flagEmail = false;
    public static bool flagPassword = false;  
    private static bool delayPassed;
    private static  bool canClick = true;
    private static bool flagNumberPhoneRequest = true;
    private static bool flagEmailRequest = true;
    
    public static bool flagNumberPhoneRestoreAccess = false;
    public static bool flagEmailRestoreAccess = false;
    private static bool flagRestoreAcess;
    private static bool isVisiblePassword;
    private static int numberCodeEmail;
    private static int numberCodeNumberPhone;

    public void Display4(RenderWindow _window)
    {
        backgroundFrame.Draw(_window);

        buttonEmptyNumberPhoneSprite.Draw(_window);
        buttonSprite.Draw(_window);
        buttonEmptyEmailSprite.Draw(_window);
        buttonEmptyPasswordSprite.Draw(_window);
       
          

        titleText.Draw(_window);
        loginText.Draw(_window);
        numberPhoneText.Draw(_window);
        emailText.Draw(_window);
        passwordText.Draw(_window);
        warningFalseText.Draw(_window);
        warningFalseText2.Draw(_window);
        warningEmailText.Draw(_window);
        warningNumberPhoneText.Draw(_window);
       
        passwordMiniText.Draw(_window);
        emailMiniText.Draw(_window);
        numberPhoneMiniText.Draw(_window);
        buttonPasswordHideSprite.Draw(_window);
        
        
    }

    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.5f;
        Texture background =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fonFrame4.png"));
        Texture emptyButtonTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
         buttonTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
        buttonTextureOff =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonOff.png"));
        
        
        hideOffTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "hideOff.png"));
        hideOnTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "hideOn.png"));
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");

        backgroundFrame = new Button(53, 53, background);
        buttonSprite = new Button(151, 863, buttonTexture);
        buttonEmptyNumberPhoneSprite = new Button(151, 336, emptyButtonTexture);
        buttonEmptyEmailSprite = new Button(151, 502, emptyButtonTexture);
        buttonEmptyPasswordSprite = new Button(151, 668, emptyButtonTexture);
        buttonPasswordHideSprite = new Button(398, 690,  hideOnTexture);
       
        
        
        colorText = new Color(0, 0, 0);
        warningTextFrame = "*обязательно";
        string title = "Вход";
        string numberPhone = "Номер телефона";
        string email = "Почта";
        string password = "Пароль";
        string warningFalse = "*Не верная почта, номер";
        string warningFalse2 = "телефона или пароль";
        string login = "Войти";
        warningText = "*обязательно";
        warningFormat = "*Не тот формат";
        
        
        numberPhoneMiniTextFrame = "";
        emailMiniTextFrame = "";
        passwordMiniTextFrame = "";
        
        
       
        
        
        numberPhoneMiniText = new Texts(171, 352, font, 32, baseColorText, numberPhoneMiniTextFrame);
        emailMiniText = new Texts(171, 518, font, 32, baseColorText,  emailMiniTextFrame);
        passwordMiniText = new Texts(171, 684, font,32, baseColorText, passwordMiniTextFrame );
        
        baseColorText = new Color(68, 68, 69);
        warningTextColor = new Color(202, 128, 128);
        nullColorText = new Color(255, 255, 255);
        
        titleText = new Texts(138, 125, font, 48, baseColorText, title);
        
        numberPhoneText = new Texts(151, 277, font, 32, baseColorText, numberPhone);
        emailText = new Texts(151, 445, font, 32, baseColorText, email);
        passwordText = new Texts(151, 611, font, 32, baseColorText, password);

        warningNumberPhoneText = new Texts(171, 416, font, 20, nullColorText, warningText);
        warningEmailText = new Texts(171, 582, font, 20, nullColorText, warningText);
        warningFalseText = new Texts(171, 748, font, 20, nullColorText, warningText);
        warningFalseText2 = new Texts(171, 776, font, 20, nullColorText, warningFalse2);


        loginText = new Texts(255, 870, font, 36, colorText, login);
        

    }

    public static void Warning(RenderWindow _window)
    {
          Vector2i mousePos = Mouse.GetPosition(_window);
     

        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
        {
            if (buttonSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y)
                || buttonRestoreAccessSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y) && delayPassed )
            {
                
                if (!flagEmailRequest)
                {
                    flagEmailRequest = true;
                    buttonRequestСodeEmailSpriteRestoreAccess.SetTexture(requestСodeTexture);
                }

                if (!flagNumberPhoneRequest)
                {
                    buttonRequestСodeNumberPhoneSpriteRestoreAccess.SetTexture(requestСodeTexture);
           
                    flagNumberPhoneRequest = true;
                
                }
            
               
                buttonSprite.SetTexture(buttonTextureOff);
                canClick = false;
                clock.Restart(); 

            }
         
          
        }
       
        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) 
                           && (buttonRestoreAccessSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y) 
                               && delayPassed ))
        {
            buttonSprite.SetTexture(buttonTexture);
            buttonRestoreAccessSprite.SetTexture(buttonRestoreAccessTextureOff);
          
            canClick = false;
            clock.Restart(); 
         
          
        }
        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) 
                           && (buttonSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y) 
                               && delayPassed ))
        {
           
          
            buttonRestoreAccessSprite.SetTexture(buttonRestoreAccessTexture);
            canClick = false;
            clock.Restart(); 
         
          
        }
       
       
    }


    public static void ButtonInteraction(RenderWindow _window)
    {
        InputLine line = new InputLine();
      
        Vector2i mousePosition = Mouse.GetPosition(_window);
       

        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
        {
            if (buttonSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                buttonSprite.SetTexture(buttonTextureOff);
                flagRestoreAcess = true;

            }
        }
        
        if (Mouse.IsButtonPressed(Mouse.Button.Left) &&
            canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
               
            if (buttonPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                && !isVisiblePassword )
            {
                isVisiblePassword = true;
                buttonPasswordHideSprite.SetTexture(hideOffTexture);
                clock.Restart();
                canClick = false;
                line.ClearLine();

            }
            else if (buttonPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                     && isVisiblePassword)
            {
                isVisiblePassword = false;
                buttonPasswordHideSprite.SetTexture(hideOnTexture);
                clock.Restart();
                canClick = false;
                line.ClearLine();
            }
               
                
        }
        /*
        if (Mouse.IsButtonPressed(Mouse.Button.Left) &&
            canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {

            if (buttonEmptyNumberPhoneSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagNumberPhone = true;
                flagEmail = false;
                flagPassword = false;

            }
        }
        
        if (flagNumberPhone)
        {
                
            numberPhoneMiniTextFrame = line.GetLine();
            numberPhoneMiniText.SetText(numberPhoneMiniTextFrame);
            cursorNumberPhonePosition = line.GetCursor();
            line.Update(_window);   
  
                
        }*/


        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
          {
              canClick = true;
          }
          Warning(_window);

    }

    public void Run4(RenderWindow _window)
    {
        Structure();
        restoreAccessSructure(_window);
        while (_window.IsOpen)
        {
            _window.Clear(new Color(233, 233, 233));


            _window.DispatchEvents();
            Display4(_window);
            ButtonInteraction(_window);
            if (flagRestoreAcess)
            {
                restoreAccessDisplay(_window);
                ButtonInteractionRestoreAcess(_window);
            }
            
            _window.Display();
           
               
            



        }


    }

    public static void warningRestoreAccess()
    {
        if (numberCodeEmail.ToString() == emailMiniTextCodeFrame)
        {
            warningEmailText.SetText(codeTrue);
            warningEmailText.SetColor(trueWarningTextColor);
        }
        else  if (numberCodeEmail.ToString() != emailMiniTextCodeFrame)
        {
            warningEmailText.SetText(codeFalse);
            warningEmailText.SetColor(warningTextColor);
        }
        if (emailMiniTextCodeFrame == "")
        {
            warningEmailText.SetColor(warningTextColor);
            warningEmailText.SetText(warningTextFrame);
        }
           

        if (numberCodeNumberPhone.ToString() == numberPhoneMiniTextCodeFrame)
        {
            warningNumberPhoneText.SetText(codeTrue);
            warningNumberPhoneText.SetColor(trueWarningTextColor);
        }
        else  if (numberCodeNumberPhone.ToString() != numberPhoneMiniTextCodeFrame)
        {
            warningNumberPhoneText.SetText(codeFalse);
            warningNumberPhoneText.SetColor(warningTextColor);
        }
        if (numberPhoneMiniTextCodeFrame == "")
        {
            warningNumberPhoneText.SetText(warningTextFrame);
            warningNumberPhoneText.SetColor(warningTextColor);
        }
    }

    public static void ButtonInteractionRestoreAcess(RenderWindow _window)
    {
        Vector2i mousePosition = Mouse.GetPosition(_window);
        RandomClass random = new RandomClass();
        InputLine line = new InputLine();
        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
        {
            delayPassed = canClick && clock.ElapsedTime.AsSeconds() >= clickDelay;

            if (buttonRequestСodeNumberPhoneSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) &&
                delayPassed && flagNumberPhoneRequest)
            {
                buttonRequestСodeNumberPhoneSpriteRestoreAccess.SetTexture(requestСodeOffTexture);

                canClick = false;
                clock.Restart();
                flagNumberPhoneRequest = false;
                numberCodeNumberPhone = random.randomCode();
                Console.WriteLine($"number phone {numberCodeNumberPhone}");
            }

            if (buttonRequestСodeEmailSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) &&
                delayPassed && flagEmailRequest)
            {
                buttonRequestСodeEmailSpriteRestoreAccess.SetTexture(requestСodeOffTexture);

                flagEmailRequest = false;
                numberCodeEmail = random.randomCode();
                Console.WriteLine($"email {numberCodeEmail}");

                canClick = false;
                clock.Restart();
            }
            if (flagNumberPhone)
            {
                
                emailMiniTextFrame3RestoreAccess = line.GetLine();
                numberPhoneMiniText.SetText(emailMiniTextFrame3RestoreAccess);
                cursorNumberPhonePositionRestoreAccess = line.GetCursor();
                line.Update(_window);   
  
                
            }
          
            if (flagEmail)
            {
                
                emailMiniTextFrame3RestoreAccess = line.GetLine();
                emailMiniText.SetText(emailMiniTextFrame3RestoreAccess);
                cursorEmailPositionRestoreAccess = line.GetCursor();
                line.Update(_window); 
 
                
            }

        }
    }
    public static void restoreAccessDisplay(RenderWindow _window)
    {
        backgroundFrameRestoreAccess.Draw(_window);
        buttonEmptyNumberPfoneSpriteRestoreAccess.Draw(_window);
        buttonEmptyEmailSpriteRestoreAccess.Draw(_window);
        buttonRequestСodeNumberPhoneSpriteRestoreAccess.Draw(_window); 
        buttonRequestСodeEmailSpriteRestoreAccess.Draw(_window);
        buttonRestoreAccessSprite.Draw(_window); 
      
        
        titleTextRestoreAccess.Draw(_window);
        titleRequestСodeNumberPhoneTextMiniRestoreAccess.Draw(_window);
        requestСodeNumberPhoneTextRestoreAccess.Draw(_window);
        titleRequestСodeEmailTextMiniRestoreAccess.Draw(_window);
        requestСodeEmailTextRestoreAccess.Draw(_window);
     
            
        numberPhoneMiniTextRestoreAccess.Draw(_window);
        emailMiniTextRestoreAccess.Draw(_window);
           
            
     
        restoreAccessTextRestoreAccess.Draw(_window);
        warningNumberPhoneTextRestoreAccess.Draw(_window);
        warningEmailTextRestoreAccess.Draw(_window);
        titlePasswordTextMiniRestoreAccess.Draw(_window);
        titleRepeatPasswordTextMiniRestoreAccess.Draw(_window);
        buttonEmptyPasswordSpriteRestoreAccess.Draw(_window);
        buttonEmptyRepeatPasswordSpriteRestoreAccess.Draw(_window);
        warningPasswordTextRestoreAccess.Draw(_window);
        
        buttonRepeatPasswordHideSprite.Draw(_window);
        buttonPasswordHideSpriteRestoreAcess.Draw(_window);
    }

    public static void restoreAccessSructure(RenderWindow _window)
    {
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        Texture backgroundFrameRestoreAccessTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fonFrames.png"));
        Texture emptyButtonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
        requestСodeTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
       buttonRestoreAccessTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistration.png"));
        buttonRestoreAccessTextureOff = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistrationOff.png"));
        requestСodeOffTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonOff.png"));
  
         
            baseColorText = new Color(68, 68, 69);
            nullColorText = new Color(255,255, 255);
            colorText = new Color(0, 0, 0);
            warningTextColor = new Color(202, 128, 128);
            trueWarningTextColor = new Color(128,202,  128);
            
            
            buttonRepeatPasswordHideSprite = new Button(1292, 750,  hideOnTexture);
      
            numberPhoneMiniTextCodeFrame = "";
            emailMiniTextCodeFrame = "";
            emailMiniTextFrameRestoreAccess = new Texts(745, 350, font, 32, colorText, numberPhoneMiniTextCodeFrame);
            numberPhoneMiniTextFrameRestoreAccess = new Texts(745, 547, font, 32, colorText,  emailMiniTextCodeFrame);
            
            int xyPositionBackground = 53;
            int xLeftBorderFrame = 725;
            int xRightBorderFrame = 1045;
            int yUpperBorderFrame = 334;
            int yLowerBorderFrame =  531;
          
            
            backgroundFrameRestoreAccess = new Button(604, xyPositionBackground,backgroundFrameRestoreAccessTexture);
            buttonEmptyNumberPfoneSpriteRestoreAccess = new Button(xLeftBorderFrame, yUpperBorderFrame, emptyButtonTexture);
            buttonEmptyEmailSpriteRestoreAccess = new Button(xLeftBorderFrame, yLowerBorderFrame, emptyButtonTexture);
            buttonRequestСodeNumberPhoneSpriteRestoreAccess = new Button(xRightBorderFrame, yUpperBorderFrame, requestСodeTexture);
            buttonRequestСodeEmailSpriteRestoreAccess = new Button(xRightBorderFrame, yLowerBorderFrame, requestСodeTexture);
            buttonRestoreAccessSprite = new Button(xLeftBorderFrame,863, buttonRestoreAccessTexture);
            
            buttonEmptyPasswordSpriteRestoreAccess = new Button(725, 730, emptyButtonTexture);
            buttonEmptyRepeatPasswordSpriteRestoreAccess = new Button(1045, 730, emptyButtonTexture);
            
            buttonPasswordHideSpriteRestoreAcess = new Button(970, 750,  hideOnTexture);
            
            string restoreAccessText = "Восстановить доступ";
            string requestNumberPhoneText = "Запросить код на номер телефона";
            string requestText =  "Запросить код";
            string requestEmailText =  "Запросить код на почту";
            string restoreAccessTitleText = "Сброс пароля";
            codeTrue = "*Код верный";
            codeFalse = "*Код неверный";
            string passwordTitle = "Новый пароль";
            string repeatPasswordTitle = "Повторите пароль";
            numberPhoneMiniTextFrame3RestoreAccess = "";
            emailMiniTextFrame3RestoreAccess = "";
            
            uint sizeTextMax = 64;
            uint sizeTextTitleFrame = 48;
            uint sizeTextMiniTitle = 36;
            uint sizeTextInput = 32;
            uint sizeWarningText = 20;
            
            titleTextRestoreAccess = new Texts(706, 125 , font, sizeTextTitleFrame, baseColorText, restoreAccessText );
            titleRequestСodeNumberPhoneTextMiniRestoreAccess = new Texts(723, 277 , font, 32, baseColorText, requestNumberPhoneText );
            requestСodeNumberPhoneTextRestoreAccess = new Texts(1089, 354 , font, 20, colorText, requestText );
            titleRequestСodeEmailTextMiniRestoreAccess = new Texts(723, 476 , font, 32, baseColorText, requestEmailText );
            requestСodeEmailTextRestoreAccess = new Texts(1089, 553 , font, 20, colorText, requestText );
            restoreAccessTextRestoreAccess = new Texts(916, 870 , font, 36, colorText, restoreAccessTitleText );
            
            titlePasswordTextMiniRestoreAccess = new Texts(723, 673 , font, 32, baseColorText, passwordTitle );
            titleRepeatPasswordTextMiniRestoreAccess = new Texts(1045, 673 , font, 32, baseColorText, repeatPasswordTitle );
            numberPhoneMiniTextRestoreAccess = new Texts(743, 350, 
                font, sizeTextInput, baseColorText, numberPhoneMiniTextFrame3RestoreAccess);
            emailMiniTextRestoreAccess = new Texts(743, 549, 
                font, sizeTextInput, baseColorText, emailMiniTextFrame3RestoreAccess);
           
            
            warningNumberPhoneTextRestoreAccess = new Texts(743, 414 , font, 20, nullColorText, codeFalse);
            warningEmailTextRestoreAccess = new Texts(743, 611 , font, 20, nullColorText, codeFalse );
            warningPasswordTextRestoreAccess = new Texts(743, 810 , font, 20, nullColorText, codeFalse );
    }

    



}
    
