
namespace CTT.Frame;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Frame4
{
    public static int cursorEmailPositionRestoreAccess;
    public static int cursorNumberPhonePositionRestoreAccess;
    public static int cursorPasswordPositionRestoreAccess;
    public static int cursorRepeatPasswordPositionRestoreAccess;
    public static int cursorNumberPhonePosition;
    public static int cursorEmailPosition;
    public static int cursorPasswordPosition;
  
    
    private static Button buttonPasswordHideSpriteRestoreAcess;
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

    private static Texts warningPasswordTextRestoreAccess;
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
    
    private static Texts backFrameText;
    public static Texts numberPhoneMiniTextsFrame4;
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
    public static Texts repeatPasswordMiniTextRestoreAccess;
    public static Texts passwordMiniTextRestoreAccess;

   
    
    public static string numberPhoneMiniTextFrame4;
    public static string emailMiniTextFrame;
    public static string passwordMiniTextFrame;
    public static string numberPhoneMiniTextCodeFrame;
    public static string emailMiniTextCodeFrame;
    public static string repeatPasswordTextMiniTextResoreAcessFrame;
    public static string passwordTextMiniTextResoreAcessFrame;
      
    private static string warningFalse ;
    private static string warningFalse2;
    private static string warningPasswordRepeat;
    private static Color baseColorText;
    private static Color warningTextColor;
    private static Texture requestСodeOffTexture;
    private static Texture requestСodeTexture;
    private static Texture buttonTextureOff;
    private static Texture hideOffTexture;
    private static Texture hideOnTexture;
    private static Texture buttonRestoreAccessTexture;
    private static Texture buttonRestoreAccessTextureOff;
    private static Texture buttonTexture;
    private static Clock clock;
    private static float clickDelay;
    
    private static bool canClick ;
    private static bool flagNumberPhoneRequest = true;
    private static bool flagEmailRequest = true;
    private static bool canClickRestoreAcess;
    private static bool flagNumberCodeNumber ;
    private static bool flagNumberCodeEmail;
    public static bool flagNumberPhoneRestoreAccess;
    public static bool flagEmailRestoreAccess;
    public static bool flagPasswordRestoreAccess;
    public static bool flagRepeatPasswordRestoreAccess ;
    public static bool flagNumberPhone;
    public static bool flagEmail;
    public static bool flagPassword;  
    public static bool flagRestoreAcess;
    public static bool isVisiblePassword;
    public static bool flagNext = false;
    
    private static bool warningFlagNumberPhone;
    private static bool warningFlagEmail ;
    private static bool warningFlagPassword;
    private static int numberCodeEmail;
    private static int numberCodeNumberPhone;
    private static bool warningPasswordRestoreAcess;
    public static bool isVisiblePasswordRetoreAcess;
    public static bool isVisibleRepeatPasswordRetoreAcess;
    private static InputLine line;
    private static Clock clockRestoreAcess;
    private static float clickDelayRestoreAcess;
    private static Flags flags;
    private static FlagFrames flagFrames;
    private static Vector2i mousePosition;
    private static Database database;
    private Warnings warnings;
    private RandomClass random;

    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;  
        line = new InputLine();
        flags = new Flags();
        flagFrames = new FlagFrames();
        database = new Database();
        warnings = new Warnings();
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
   
        string title = "Вход";
        string numberPhone = "Номер телефона";
        string email = "Почта";
        string password = "Пароль";
        warningFalse = "*Не верная почта, номер";
        warningFalse2 = "телефона или пароль";
        string login = "Войти";
        string backText = "<назад"; 
        numberPhoneMiniTextFrame4 = "";
        emailMiniTextFrame = "";
        passwordMiniTextFrame = "";
        
        Color colorText = new Color(0, 0, 0);
        Color colorMessage = new Color(136, 136, 136);
        baseColorText = new Color(68, 68, 69);
        warningTextColor = new Color(202, 128, 128);
        
        titleText = new Texts(138, 125, font, 48, baseColorText, title);
        numberPhoneMiniTextsFrame4 = new Texts(171, 352, font, 32, baseColorText, numberPhoneMiniTextFrame4);
        emailMiniText = new Texts(171, 518, font, 32, baseColorText,  emailMiniTextFrame);
        passwordMiniText = new Texts(171, 684, font,32, baseColorText, passwordMiniTextFrame );
        numberPhoneText = new Texts(151, 277, font, 32, baseColorText, numberPhone);
        emailText = new Texts(151, 445, font, 32, baseColorText, email);
        passwordText = new Texts(151, 611, font, 32, baseColorText, password);
        backFrameText =   new Texts(151, 939, font, 24, colorMessage, backText );
        
        warningNumberPhoneText = new Texts(171, 416, font, 20, warningTextColor, "");
        warningEmailText = new Texts(171, 582, font, 20, warningTextColor, "");
        warningFalseText = new Texts(171, 748, font, 20, warningTextColor, "");
        warningFalseText2 = new Texts(171, 776, font, 20, warningTextColor, "");
        loginText = new Texts(255, 870, font, 36, colorText, login);
    }
    public void Warning()
    {
        warningEmailText.SetText(warnings.WarningLineEmail(emailMiniTextFrame));
        warningFlagEmail = warnings.GetWarningFlag();
        warningNumberPhoneText.SetText(warnings.WarningLineNumberPhoneLogin(numberPhoneMiniTextFrame4));
        warningFlagNumberPhone = warnings.GetWarningFlag();
        warningFalseText.SetText(warnings.WarningLinePassword(passwordMiniTextFrame));
        warningFlagPassword = warnings.GetWarningFlag();
        
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
        else if (flag && warningFlagEmail && warningFlagNumberPhone && warningFlagPassword)
        {
            warningFalseText.SetText("");
            warningFalseText2.SetText("");
            var fullName = database.GetUserFullName(numberPhoneMiniTextFrame4, emailMiniTextFrame,
                passwordMiniTextFrame);
            int id = database.GetUserId(numberPhoneMiniTextFrame4, emailMiniTextFrame);
            
            SavingLogin.SaveToJson(fullName.FirstName, fullName.LastName, numberPhoneMiniTextFrame4,
                emailMiniTextFrame, passwordMiniTextFrame);
            database.notificationsAdd(id, "Выполнен вход", "0");
            flags.changeFlag();
            line.clearLine();
            flagFrames.ChangeFlagsFrame();
            MainForm.profile = true;
            
        }
    }
    public void clic()
    {
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
            canClick = true;
        }
    }
    public void ButtonInteraction(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
        clic();
        if (Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
            if (backFrameText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            { 
                flags.changeFlag();
                line.clearLine();
                flagFrames.ChangeFlagsFrame(); MainForm.frame1 = true;
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
            else
            { flagNumberPhone = false; }
            if (buttonEmptyEmailSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagEmail = true;
                line.parametres(emailMiniText, flagEmail);
                line.LineParametr(emailMiniTextFrame ,cursorEmailPosition);
       
            }
            else
            { flagEmail = false; }
            if (buttonEmptyPasswordSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagPassword = true;
                line.parametres(passwordMiniText, flagPassword);
                line.LineParametr(passwordMiniTextFrame ,cursorPasswordPosition);
            }
            else
            { flagPassword = false; }
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
                Warning();
            }
            clock.Restart();
            canClick = false;
        }
        if (flagNumberPhone)
        {
            numberPhoneMiniTextFrame4 = line.GetLine();
            cursorNumberPhonePosition = line.GetCursor();
            numberPhoneMiniTextsFrame4.SetText(numberPhoneMiniTextFrame4);
            line.Update(_window);  
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
   
    public void warningRestoreAccess()
    {
        flagNumberCodeEmail = false;
        flagNumberCodeNumber = false;
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
        flagNumberCodeEmail = warnings.GetWarningFlag();
        warningNumberPhoneTextRestoreAccess.SetText(warnings.WarningLineCode(numberPhoneMiniTextCodeFrame, numberCodeNumberPhone.ToString()));
        flagNumberCodeNumber = warnings.GetWarningFlag();
        warningPasswordTextRestoreAccess.SetText(warnings.WarningLineRepeatPassword(repeatPasswordTextMiniTextResoreAcessFrame, passwordTextMiniTextResoreAcessFrame));
        warningPasswordRestoreAcess = warnings.GetWarningFlag();
        if (!warningPasswordRestoreAcess  && !flagNumberCodeNumber && !flagNumberCodeEmail)
        {
            database.updateUser(numberPhoneMiniTextFrame4, emailMiniTextFrame, passwordTextMiniTextResoreAcessFrame);
            SavingLogin.UpdatePasswordInJson(passwordTextMiniTextResoreAcessFrame);
        }
    }
    public static void clicRestoreAcess()
    {
        if (!canClickRestoreAcess && clockRestoreAcess.ElapsedTime.AsSeconds() >= clickDelayRestoreAcess)
        {
            canClickRestoreAcess = true;
        }
    }
    public void ButtonInteractionRestoreAcess(RenderWindow _window)
    {
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
                warningRestoreAccess();
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
    }
    
    public void restoreAccessSructure()
    {
        clockRestoreAcess = new Clock();
        clickDelayRestoreAcess = 0.3f;
        random = new RandomClass();
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        Texture backgroundFrameRestoreAccessTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgoundFrames.png"));
        Texture emptyButtonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
        requestСodeTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
        buttonRestoreAccessTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistration.png"));
        buttonRestoreAccessTextureOff = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistrationOff.png"));
        requestСodeOffTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonOff.png"));
     
        baseColorText = new Color(68, 68, 69);
        Color colorText = new Color(0, 0, 0);
        warningTextColor = new Color(202, 128, 128);

        int xyPositionBackground = 53;
        int xLeftBorderFrame = 725;
        int xRightBorderFrame = 1045;
        int yUpperBorderFrame = 334;
        int yLowerBorderFrame =  531;
      
        buttonRepeatPasswordHideSprite = new Button(1292, 750,  hideOnTexture);
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
        warningNumberPhoneTextRestoreAccess = new Texts(743, 414 , font, 20, warningTextColor, "");
        warningEmailTextRestoreAccess = new Texts(743, 611 , font, 20, warningTextColor, "" );
        warningPasswordTextRestoreAccess = new Texts(743, 810 , font, 20, warningTextColor, "" );
    }
}
    
