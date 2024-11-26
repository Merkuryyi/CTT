
using CTT;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Frame4
{
    private static bool canClickRestoreAcess;
    private static string warningFalse ;
    private static string warningFalse2;
    private static bool flagNumberCodeNumber  = false;
    private static bool flagNumberCodeEmail  = false;
    private static string warningPasswordRepeat;
    public static bool flagNext = false;

    
    private static bool warningFlagNumberPhone = false;
    private static bool warningFlagEmail = false;
    private static bool warningFlagPassword = false;

    public static string repeatPasswordTextMiniTextResoreAcessFrame;
    public static Texts repeatPasswordMiniTextRestoreAccess;
    public static Texts passwordMiniTextRestoreAccess;
    public static string passwordTextMiniTextResoreAcessFrame;
    
    private static Texts backFrameText;
    public static Texts numberPhoneMiniTextsFrame4;
    private static Texture buttonRestoreAccessTexture;
    private static Texture buttonRestoreAccessTextureOff;
    private static Texture buttonTexture;
    
    public static int cursorEmailPositionRestoreAccess = 0;
    public static int cursorNumberPhonePositionRestoreAccess = 0;
    public static int cursorPasswordPositionRestoreAccess = 0;
    public static int cursorRepeatPasswordPositionRestoreAccess = 0;
    
    public static int cursorNumberPhonePosition = 0;
    public static int cursorEmailPosition = 0;
    public static int cursorPasswordPosition = 0;
  
    
    private static Button buttonPasswordHideSpriteRestoreAcess;
  

    private static Texts warningPasswordTextRestoreAccess;

    private static Button buttonPasswordHideSprite;
    private static Button buttonRepeatPasswordHideSprite;

    public static Button buttonEmptyRepeatPasswordSpriteRestoreAccess;
    public static Button buttonEmptyPasswordSpriteRestoreAccess;
   
    private static Button buttonOffSpriteRestoreAccess;

    private static Button buttonEmptyEmailSpriteRestoreAccess;
    private static Button buttonRequestСodeNumberPhoneSpriteRestoreAccess;
    private static Button buttonRequestСodeEmailSpriteRestoreAccess;
    private static Button buttonRestoreAccessSprite;
    private static Button buttonEmptyNumberPfoneSpriteRestoreAccess;
    private static Button backgroundFrame;
    private static Button buttonSprite;
    
    public static Button buttonEmptyNumberPhoneSprite;
    public static Button buttonEmptyEmailSprite;
    public static Button buttonEmptyPasswordSprite;
    


    private static Button backgroundFrameRestoreAccess;

    public static Texts emailMiniTextRestoreAccess;
    public static Texts numberPhoneMiniTextRestoreAccess;
    public static Texts titleRepeatPasswordTextMiniRestoreAccess;
    public static Texts titlePasswordTextMiniRestoreAccess;
    public static Texts warningEmailTextRestoreAccess;
    public static Texts warningNumberPhoneTextRestoreAccess;

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
   


    
    public static string numberPhoneMiniTextFrame4;
    public static string emailMiniTextFrame;
    public static string passwordMiniTextFrame;

    public static string  numberPhoneMiniTextCodeFrame;
    public static string emailMiniTextCodeFrame;

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
    
    private static float clickDelay = 0.3f;
    
    public static bool flagNumberPhone = false;
    public static bool flagEmail = false;
    public static bool flagPassword = false;  
    

    private static bool canClick = false;
    private static bool flagNumberPhoneRequest = true;
    private static bool flagEmailRequest = true;
    
    public static bool flagNumberPhoneRestoreAccess = false;
    public static bool flagEmailRestoreAccess = false;
    public static bool flagPasswordRestoreAccess = false;
    public static bool flagRepeatPasswordRestoreAccess = false;
    
    public static bool flagRestoreAcess = false;
    public static bool isVisiblePassword = false;
    private static int numberCodeEmail;
    private static int numberCodeNumberPhone;

  
    
    private static bool warningPasswordRestoreAcess = false;
    
    public static bool isVisiblePasswordRetoreAcess = false;
    public static bool isVisibleRepeatPasswordRetoreAcess = false;
    private static InputLine line;

    private static Clock clockRestoreAcess;
    private static float clickDelayRestoreAcess;

    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;
        
        line = new InputLine();
        Texture background =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgoundFrame4.png"));
        Texture emptyButtonTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
         buttonTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
        buttonTextureOff =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonOff.png"));
        
        
        hideOffTexture = new 
            Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "hideOff.png"));
        hideOnTexture = new
            Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "hideOn.png"));
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");

        backgroundFrame = new Button(53, 53, background);
        buttonSprite = new Button(151, 863, buttonTexture);
        buttonEmptyNumberPhoneSprite = new Button(151, 336, emptyButtonTexture);
        buttonEmptyEmailSprite = new Button(151, 502, emptyButtonTexture);
        buttonEmptyPasswordSprite = new Button(151, 668, emptyButtonTexture);
        buttonPasswordHideSprite = new Button(398, 690,  hideOnTexture);
       
        
        
        colorText = new Color(0, 0, 0);

        
        string title = "Вход";
        string numberPhone = "Номер телефона";
        string email = "Почта";
        string password = "Пароль";
        
        warningFalse = "*Не верная почта, номер";
        warningFalse2 = "телефона или пароль";
        string login = "Войти";
        
        
        numberPhoneMiniTextFrame4 = "";
        emailMiniTextFrame = "";
        passwordMiniTextFrame = "";
        string backText = "<назад"; 
        
        colorMessage = new Color(136, 136, 136);
        
     
      
        baseColorText = new Color(68, 68, 69);
        warningTextColor = new Color(202, 128, 128);
        nullColorText = new Color(255, 255, 255);
        
        
        titleText = new Texts(138, 125, font, 48, baseColorText, title);
        
        numberPhoneMiniTextsFrame4 = new Texts(171, 352, font, 32, baseColorText, numberPhoneMiniTextFrame4);
        emailMiniText = new Texts(171, 518, font, 32, baseColorText,  emailMiniTextFrame);
        passwordMiniText = new Texts(171, 684, font,32, baseColorText, passwordMiniTextFrame );
        numberPhoneText = new Texts(151, 277, font, 32, baseColorText, numberPhone);
        emailText = new Texts(151, 445, font, 32, baseColorText, email);
        passwordText = new Texts(151, 611, font, 32, baseColorText, password);
        backFrameText =   new Texts(151, 939, font, 24, colorMessage, backText );
        warningNumberPhoneText = new Texts(171, 416, font, 20, nullColorText, "");
        warningEmailText = new Texts(171, 582, font, 20, nullColorText, "");
        warningFalseText = new Texts(171, 748, font, 20, nullColorText, "");
        warningFalseText2 = new Texts(171, 776, font, 20, nullColorText, warningFalse2);


        loginText = new Texts(255, 870, font, 36, colorText, login);
       

    }

    public static void Warning(RenderWindow _window)
    {
        Vector2i mousePosition = Mouse.GetPosition(_window);
       
        clic();
        Warnings warnings = new Warnings();
        if (Mouse.IsButtonPressed(Mouse.Button.Left) && canClick && buttonSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
        {
             warningEmailText.SetText(warnings.WarningLineEmail(emailMiniTextFrame));
                warningFlagEmail = warnings.getWarningFlag();
                
                
                warningNumberPhoneText.SetText(warnings.WarningLineNumberPhone(numberPhoneMiniTextFrame4));
                warningFlagNumberPhone = warnings.getWarningFlag();
                
                warningFalseText.SetText(warnings.WarningLinePassword(passwordMiniTextFrame));
                warningFlagPassword = warnings.getWarningFlag();
                
              
                
                
                canClick = false;
                clock.Restart(); 
          
            
        }
       
 
       
    }
    public static void ButtonInteraction(RenderWindow _window)
    {
        InputLine line = new InputLine();
        Vector2i mousePosition = Mouse.GetPosition(_window);
        Flags flags = new Flags();
        FlagFrames flagFrames = new FlagFrames();
        clic();
   
        if (Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
            if (backFrameText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
              
                flags.changeFlag();
                line.clearLine();
               flagFrames.ChangeFlagsFrame();
               MainForm.frame1 = true;
            }
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
            
            
            if (buttonEmptyNumberPhoneSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagNumberPhone = true;
                line.parametres(numberPhoneMiniTextsFrame4, flagNumberPhone);
                line.LineParametr(numberPhoneMiniTextFrame4 ,cursorNumberPhonePosition);
       

            }

            if (buttonEmptyEmailSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagEmail = true;
                line.parametres(emailMiniText, flagEmail);
                line.LineParametr(emailMiniTextFrame ,cursorEmailPosition);
       
            }
            if (buttonEmptyPasswordSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagPassword = true;
                line.parametres(passwordMiniText, flagPassword);
                line.LineParametr(passwordMiniTextFrame ,cursorPasswordPosition);
            }
            if (buttonSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (buttonSprite.IfTexture(buttonTexture))
                {
                    buttonSprite.SetTexture(buttonTextureOff);
                }
                else if (buttonSprite.IfTexture(buttonTextureOff))
                {
                    buttonSprite.SetTexture(buttonTexture);
                }
              
                
            }
            
           
            
           
            
            canClick = false;
            clock.Restart();  
                
        }
  

        
        if (flagNumberPhone)
        {
                
            numberPhoneMiniTextFrame4 = line.GetLine();
            cursorNumberPhonePosition = line.GetCursor();
            numberPhoneMiniTextsFrame4.SetText(numberPhoneMiniTextFrame4);
            line.Update(_window);  
            Console.WriteLine(numberPhoneMiniTextFrame4);
  
                
        }

        if (flagEmail)
        {
            emailMiniTextFrame = line.GetLine();
            cursorEmailPosition = line.GetCursor();
            emailMiniText.SetText(emailMiniTextFrame);
            line.Update(_window);  
        }
        if (flagPassword)
        {
            passwordMiniTextFrame = line.GetLine();
            cursorPasswordPosition = line.GetCursor();
            
            passwordMiniText.SetText(passwordMiniTextFrame);
            if (!isVisiblePassword)
            {
                   
                passwordMiniText.HideText(passwordMiniTextFrame); 
                passwordMiniText.SetPosition(171, 690);
            }
            else if (isVisiblePassword)
            {
                    
                passwordMiniText.SetText(passwordMiniTextFrame); 
                passwordMiniText.SetPosition(171, 682);
                    
            }
            line.Update(_window);  
        }
        
        Warning(_window);
        Database database = new Database();
        
        if (warningFlagEmail || warningFlagPassword || warningFlagNumberPhone)
        {
            
            string numberPhone = numberPhoneMiniTextFrame4;
            string email = emailMiniTextFrame;
            string password = passwordMiniTextFrame;
            bool flag = database.loginUser(numberPhone, email, password);
            if (!flag)
            {
                flagEmail = false;
                flagPassword = false;
                flagNumberPhone = false;
                warningFalseText.SetColor(warningTextColor);
                warningFalseText2.SetColor(warningTextColor);
                warningFalseText.SetText(warningFalse);
                warningFalseText2.SetText(warningFalse2);
                flagRestoreAcess = true;    
            }

            if (flag)
            {
                var fullName = database.GetUserFullName(numberPhoneMiniTextFrame4, emailMiniTextFrame, passwordMiniTextFrame);
                SavingLogin.SaveToJson(fullName.FirstName, fullName.LastName, numberPhoneMiniTextFrame4, emailMiniTextFrame, passwordMiniTextFrame);
            }

        }
    }
 
 

 

    public void workProgram(RenderWindow _window)
    {
        Display(_window);
        ButtonInteraction(_window);
        ButtonInteractionRestoreAcess(_window);
    }
    public void Display(RenderWindow _window)
    {
        _window.Clear(new Color(233, 233, 233));
        backgroundFrame.Draw(_window);

        buttonEmptyNumberPhoneSprite.Draw(_window);
        buttonSprite.Draw(_window);
        buttonEmptyEmailSprite.Draw(_window);
        buttonEmptyPasswordSprite.Draw(_window);
       
        loginText.Draw(_window);
        numberPhoneText.Draw(_window);
        emailText.Draw(_window);
        passwordText.Draw(_window);
        warningFalseText.Draw(_window);
        warningFalseText2.Draw(_window);
        warningEmailText.Draw(_window);
        warningNumberPhoneText.Draw(_window);

        titleText.Draw(_window);
        buttonPasswordHideSprite.Draw(_window);
        
        backFrameText.Draw(_window);
        numberPhoneMiniTextsFrame4.Draw(_window);
        emailMiniText.Draw(_window);
        passwordMiniText.Draw(_window);
        
        if (flagRestoreAcess)
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
            repeatPasswordMiniTextRestoreAccess.Draw(_window);
               
            numberPhoneMiniTextRestoreAccess.Draw(_window);
            emailMiniTextRestoreAccess.Draw(_window);
            passwordMiniTextRestoreAccess.Draw(_window);
        }
    }
   
    public static void warningRestoreAccess(RenderWindow _window)
    {
        flagNumberCodeEmail = false;
        flagNumberCodeNumber = false;
        Warnings warnings = new Warnings();
        clicRestoreAcess();
        Vector2i mousePosition = Mouse.GetPosition(_window);
        if (Mouse.IsButtonPressed(Mouse.Button.Left) &&
            buttonRestoreAccessSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) && canClickRestoreAcess)
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
            
            warningEmailTextRestoreAccess.SetText(warnings.WarningLineCode(emailMiniTextCodeFrame, numberCodeEmail.ToString()));
            flagNumberCodeEmail = warnings.getWarningFlag();
            
            warningNumberPhoneTextRestoreAccess.SetText(warnings.WarningLineCode(numberPhoneMiniTextCodeFrame, numberCodeNumberPhone.ToString()));
            flagNumberCodeNumber = warnings.getWarningFlag();


            warningPasswordTextRestoreAccess.SetText(warnings.WarningLineRepeatPassword(repeatPasswordTextMiniTextResoreAcessFrame, passwordTextMiniTextResoreAcessFrame));
            warningPasswordRestoreAcess = warnings.getWarningFlag();

        }

    }
    public static void clic()
    {
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
            canClick = true;
        }
    }
    public static void clicRestoreAcess()
    {
        if (!canClickRestoreAcess && clockRestoreAcess.ElapsedTime.AsSeconds() >= clickDelayRestoreAcess)
        {
            canClickRestoreAcess = true;
        }
    }
    public static void ButtonInteractionRestoreAcess(RenderWindow _window)
    {
        Vector2i mousePosition = Mouse.GetPosition(_window);
        RandomClass random = new RandomClass();
        Flags flags = new Flags();
        Database database = new Database();
        clicRestoreAcess();
        
        if (Mouse.IsButtonPressed(Mouse.Button.Left) && canClickRestoreAcess)
        {
            if ( buttonPasswordHideSpriteRestoreAcess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                 && !isVisiblePassword )
            {
                isVisiblePassword = true;
                buttonPasswordHideSpriteRestoreAcess.SetTexture(hideOffTexture);
            }
            else if (buttonPasswordHideSpriteRestoreAcess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                      && isVisiblePassword)
            {
                isVisiblePassword = false;
                buttonPasswordHideSpriteRestoreAcess.SetTexture(hideOnTexture);
            }
            if (buttonRepeatPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                && !isVisiblePassword)
            {
                isVisiblePassword = true;
                buttonRepeatPasswordHideSprite.SetTexture(hideOffTexture);
                

            }
            if (buttonRepeatPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                     && isVisiblePassword)
            {
                isVisiblePassword = false;
                buttonRepeatPasswordHideSprite.SetTexture(hideOnTexture);
            }
            
            if (buttonRestoreAccessSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (buttonRestoreAccessSprite.IfTexture(buttonRestoreAccessTexture))
                {
                    buttonRestoreAccessSprite.SetTexture(buttonRestoreAccessTextureOff);
                }
                else if (buttonRestoreAccessSprite.IfTexture(buttonRestoreAccessTextureOff))
                {
                    buttonRestoreAccessSprite.SetTexture(buttonRestoreAccessTexture);
                }

                if (!warningPasswordRestoreAcess && !warningFlagPassword && !flagNumberCodeNumber && !flagNumberCodeEmail)
                {
                    database.updateUser(numberPhoneMiniTextFrame4, emailMiniTextFrame, passwordTextMiniTextResoreAcessFrame);
                }
                
            }
            if (buttonRequestСodeNumberPhoneSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                && flagNumberPhoneRequest)
            {
                buttonRequestСodeNumberPhoneSpriteRestoreAccess.SetTexture(requestСodeOffTexture);
                flagNumberPhoneRequest = false;
                numberCodeNumberPhone = random.randomCode();
                Console.WriteLine($"number phone {numberCodeNumberPhone}");
            }

            if (buttonRequestСodeEmailSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) && flagEmailRequest)
            {
                buttonRequestСodeEmailSpriteRestoreAccess.SetTexture(requestСodeOffTexture);

                flagEmailRequest = false;
                numberCodeEmail = random.randomCode();
                Console.WriteLine($"email {numberCodeEmail}");

            }
           
            if (buttonEmptyNumberPfoneSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagNumberPhoneRestoreAccess = true;
                line.parametres(numberPhoneMiniTextRestoreAccess, flagNumberPhoneRestoreAccess);
                line.LineParametr(numberPhoneMiniTextCodeFrame ,cursorNumberPhonePositionRestoreAccess);

            }
          
            if (buttonEmptyEmailSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagEmailRestoreAccess = true;
                line.parametres(emailMiniTextRestoreAccess, flagNumberPhoneRestoreAccess);
                line.LineParametr(emailMiniTextCodeFrame, cursorEmailPositionRestoreAccess);
            }
            if (buttonEmptyPasswordSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagPasswordRestoreAccess = true;
                line.parametres(passwordMiniTextRestoreAccess, flagPasswordRestoreAccess);
                line.LineParametr(passwordTextMiniTextResoreAcessFrame, cursorPasswordPositionRestoreAccess);
            }
            if (buttonEmptyRepeatPasswordSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagRepeatPasswordRestoreAccess = true;
                line.parametres(repeatPasswordMiniTextRestoreAccess, flagRepeatPasswordRestoreAccess);
                line.LineParametr(repeatPasswordTextMiniTextResoreAcessFrame, cursorRepeatPasswordPositionRestoreAccess);
            }
            if (buttonPasswordHideSpriteRestoreAcess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                && isVisiblePasswordRetoreAcess )
            {
                isVisiblePasswordRetoreAcess = false;
                buttonPasswordHideSpriteRestoreAcess.SetTexture(hideOffTexture);
           
            }
            else if (buttonPasswordHideSpriteRestoreAcess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                     && !isVisiblePasswordRetoreAcess)
            {
                isVisiblePasswordRetoreAcess = true;
                buttonPasswordHideSpriteRestoreAcess.SetTexture(hideOnTexture);
              
            }
            
            if (buttonRepeatPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                && isVisibleRepeatPasswordRetoreAcess )
            {
                isVisibleRepeatPasswordRetoreAcess = false;
                buttonRepeatPasswordHideSprite.SetTexture(hideOffTexture);


            }
            else if (buttonRepeatPasswordHideSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                     && !isVisibleRepeatPasswordRetoreAcess)
            {
                isVisibleRepeatPasswordRetoreAcess = true;
                buttonRepeatPasswordHideSprite.SetTexture(hideOnTexture);
        
            }
            canClickRestoreAcess = false;
            clockRestoreAcess.Restart(); 
                
        }
        
        
        if (flagNumberPhoneRestoreAccess)
        {
            numberPhoneMiniTextCodeFrame = line.GetLine();
            numberPhoneMiniTextRestoreAccess.SetText(numberPhoneMiniTextCodeFrame);
            cursorNumberPhonePositionRestoreAccess = line.GetCursor();
            line.Update(_window);   
  
                
        }
        if (flagEmailRestoreAccess)
        {
                
            emailMiniTextCodeFrame = line.GetLine();
            emailMiniTextRestoreAccess.SetText(emailMiniTextCodeFrame);
            cursorEmailPositionRestoreAccess = line.GetCursor();
            line.Update(_window); 
 
                
        }

        if (flagPasswordRestoreAccess)
        {
            passwordTextMiniTextResoreAcessFrame = line.GetLine();
             passwordMiniTextRestoreAccess.SetText(passwordTextMiniTextResoreAcessFrame);
            cursorPasswordPositionRestoreAccess = line.GetCursor();
            
            if (!isVisiblePasswordRetoreAcess)
            {
                   
                passwordMiniTextRestoreAccess.HideText(passwordTextMiniTextResoreAcessFrame); 
                passwordMiniTextRestoreAccess.SetPosition(743, 752);
             
            }
            else if (isVisiblePasswordRetoreAcess)
            {
                    
                passwordMiniTextRestoreAccess.SetText(passwordTextMiniTextResoreAcessFrame); 
                passwordMiniTextRestoreAccess.SetPosition(743,746);
                    
            }
            line.Update(_window); 
        }
        if (flagRepeatPasswordRestoreAccess)
        {
            repeatPasswordTextMiniTextResoreAcessFrame = line.GetLine();
            cursorRepeatPasswordPositionRestoreAccess = line.GetCursor();
            
            if (!isVisibleRepeatPasswordRetoreAcess)
            {
                repeatPasswordMiniTextRestoreAccess.HideText(repeatPasswordTextMiniTextResoreAcessFrame); 
                repeatPasswordMiniTextRestoreAccess.SetPosition(1065, 752);
            }
            else if (isVisibleRepeatPasswordRetoreAcess)
            {
                    
                repeatPasswordMiniTextRestoreAccess.SetText(repeatPasswordTextMiniTextResoreAcessFrame); 
                
                repeatPasswordMiniTextRestoreAccess.SetPosition(1065, 746);
                    
            }
            line.Update(_window); 
        }
       
        warningRestoreAccess(_window);
    }
   

    public void restoreAccessSructure()
    {
        clockRestoreAcess = new Clock();
        clickDelayRestoreAcess = 0.3f;
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        Texture backgroundFrameRestoreAccessTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgoundFrames.png"));
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
        
        string passwordTitle = "Новый пароль";
        string repeatPasswordTitle = "Повторите пароль";
        warningPasswordRepeat = "Пароли не совпадают";
        numberPhoneMiniTextCodeFrame = "";
        emailMiniTextCodeFrame = "";
        passwordTextMiniTextResoreAcessFrame = "";
        repeatPasswordTextMiniTextResoreAcessFrame = "";
        
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
        
        numberPhoneMiniTextRestoreAccess = new Texts(743, 350, font, sizeTextInput, baseColorText, numberPhoneMiniTextCodeFrame);
        emailMiniTextRestoreAccess = new Texts(743, 549, font, sizeTextInput, baseColorText, emailMiniTextCodeFrame);
        
        passwordMiniTextRestoreAccess = new Texts(743, 746, font, sizeTextInput, baseColorText, passwordTextMiniTextResoreAcessFrame);
        repeatPasswordMiniTextRestoreAccess = new Texts(1065, 746, font, sizeTextInput, baseColorText, repeatPasswordTextMiniTextResoreAcessFrame);
     
        warningNumberPhoneTextRestoreAccess = new Texts(743, 414 , font, 20, nullColorText, "");
        warningEmailTextRestoreAccess = new Texts(743, 611 , font, 20, nullColorText, "" );
        warningPasswordTextRestoreAccess = new Texts(743, 810 , font, 20, nullColorText, "" );
    }

    



}
    
