using SFML.Graphics;
using SFML.Window;
using SFML.System;
namespace CTT.Frame;
public class Frame2
{
    private static int cursorLnamePosition;
    private static int cursorNamePosition;
    private static int cursorPasswordPosition;
    private static int cursorRepeatPasswordPosition;
    private static int cursorNumberPhonePosition;
    private static int cursorEmailPosition;
    
    public static bool flagLogin;
    public static bool flagUserName;
    public static bool flagPassword;
    public static bool flagRepeatPassword;
    public static bool flagNumberPhone;
    public static bool flagEmail;
    private static bool warningFlagLogin;
    private static bool warningFlagUserName;
    private static bool warningFlagPassword;
    private static bool warningFlagRepeatPassword;
    private static bool warningFlagNumberPhone;
    private static bool warningFlagEmail;
    private static bool isVisiblePassword;
    private static bool isVisibleRepeatPassword;
    private static bool canClick;
    
    private static Button buttonLoginSprite;
    private static Button buttonUserNameSprite;
    private static Button buttonNumberPhoneSprite;
    private static Button buttonEmailSprite;
    private static Button buttonPasswordSprite;
    private static Button buttonRepeatPasswordSprite;
    private static Button backgroundFrame;
    private static Button buttonPasswordHideSprite;
    private static Button buttonRepeatPasswordHideSprite;
    
    private static Button buttonFurtherSprite;
    private static Texts backFrameText;
    private static Texts titleText;
    private static Texts loginText;
    private static Texts numberPhoneText;
    private static Texts passwordText;
    private static Texts repeatPasswordText;
    private static Texts userNameText;
    private static Texts emailText;
    private static Texts furtherText;
    
    private static Texts loginMiniText;
    private static Texts userNameMiniText;
    private static Texts passwordMiniText;
    private static Texts repeatPasswordMiniText;
    private static Texts numberPhoneMiniText;
    private static Texts emailMiniText;
    private static Texts warningLoginText;
    private static Texts warningUserNameText;
    private static Texts warningNumberPfoneText;
    private static Texts warningEmailText;
    private static Texts warningPasswordText;
    private static Texts warningRepeatPasswordText;
    
    public static string loginMiniTextFrame;
    public static string userNameMiniTextFrame;
    public static string passwordMiniTextFrame;
    private static string repeatPasswordMiniTextFrame;
    public static string numberPhoneMiniTextFrame;
    public static string emailMiniTextFrame;
    private static Color baseColorText;
    private static Color warningTextColor; 
    private static Color colorMessage;
    private static Texture hideOffTexture;
    private static Texture hideOnTexture;
    
    private static Vector2i mousePosition;
    private static Clock clock;
    private static float clickDelay;
    private static Flags flags;
    private static InputLine line;
    private static Warnings warnings;
    private static FlagFrames flagFrames;
    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;  
        flags = new Flags();
        line = new InputLine();
        warnings = new Warnings();
        flagFrames = new FlagFrames();
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        Texture background = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundRegistration.png"));
        Texture emptyButtonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
        Texture buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
        hideOffTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "hideOff.png"));
        hideOnTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "hideOn.png"));
        
        uint sizeTextMax = 64;
        uint sizeTextTitleFrame = 48;
        uint sizeTextMiniTitle = 36;
        uint sizeTextInput = 32;
        uint sizeWarningText = 20;
        
        backgroundFrame = new Button(53, 53, background);
        buttonLoginSprite = new Button(151, 336, emptyButtonTexture);
        buttonNumberPhoneSprite = new Button(151, 505, emptyButtonTexture);
        buttonPasswordSprite = new Button(151, 669, emptyButtonTexture);
        buttonUserNameSprite = new Button(614, 336, emptyButtonTexture);
        buttonEmailSprite= new Button(614, 505, emptyButtonTexture);
        buttonRepeatPasswordSprite = new Button(614, 669, emptyButtonTexture);
        buttonFurtherSprite = new Button(386, 838,  buttonTexture);
        buttonPasswordHideSprite = new Button(398, 688, hideOnTexture);
        buttonRepeatPasswordHideSprite = new Button(861, 688, hideOnTexture);
        baseColorText = new Color(68, 68, 69);
        warningTextColor = new Color(202, 128, 128);
        colorMessage = new Color(136, 136, 136);
        
        string titleTextFrame = "Регистрация";
        string loginTextFrame = "Логин";
        string numberPhoneTextFrame = "Номер телефона";
        string passwordTextFrame = "Пароль";
        string userNameTextFrame = "Имя пользователя";
        string emailTextFrame = "Почта";
        string repeatPasswordTextFrame = "Повторите пароль";
        string backText = "<назад"; 
        string furtherTextFrame2 = "Далее";
        
        loginMiniTextFrame = "";
        userNameMiniTextFrame = "";
        passwordMiniTextFrame = "";
        repeatPasswordMiniTextFrame = "";
        numberPhoneMiniTextFrame = "";
        emailMiniTextFrame = "";
        
        titleText = new Texts(138,125, font, sizeTextTitleFrame, baseColorText, titleTextFrame );
        loginText = new Texts(151, 277, 
            font, sizeTextInput, baseColorText, loginTextFrame );
        numberPhoneText = new Texts(151, 445, 
            font, sizeTextMiniTitle, baseColorText, numberPhoneTextFrame );
        passwordText  = new Texts(151, 610, 
            font, sizeTextMiniTitle, baseColorText, passwordTextFrame );
        userNameText  = new Texts(614, 277, 
            font, sizeTextMiniTitle, baseColorText, userNameTextFrame );
        emailText  = new Texts(614, 445, 
            font, sizeTextMiniTitle, baseColorText, emailTextFrame );
        repeatPasswordText  = new Texts(614, 610, 
            font, sizeTextMiniTitle, baseColorText, repeatPasswordTextFrame );
        warningLoginText  = new Texts(171, 416, 
            font, sizeWarningText, warningTextColor, "" );
        warningUserNameText = new Texts(634, 416, 
            font, sizeWarningText, warningTextColor, "" );
        warningNumberPfoneText = new Texts(171, 585, 
            font, sizeWarningText, warningTextColor, "" );
        warningEmailText = new Texts(634, 585,
            font, sizeWarningText, warningTextColor, "" );
        warningPasswordText = new Texts(171, 749,
            font, sizeWarningText,warningTextColor, "" ); 
        warningRepeatPasswordText = new Texts(634, 749,
            font, sizeWarningText,warningTextColor, "" );
        furtherText = new Texts(478, 847, 
            font, sizeTextMiniTitle, baseColorText, furtherTextFrame2 );
        loginMiniText = new Texts(171, 350, 
            font, sizeTextInput, baseColorText, loginMiniTextFrame);
        userNameMiniText = new Texts(634, 350, 
            font, sizeTextInput, baseColorText, userNameMiniTextFrame);
        passwordMiniText = new Texts(171, 682,
            font, sizeTextInput, baseColorText, passwordMiniTextFrame);
        repeatPasswordMiniText = new Texts(634,682,
            font, sizeTextInput, baseColorText, repeatPasswordMiniTextFrame);
        numberPhoneMiniText = new Texts(171, 520, 
            font, sizeTextInput, baseColorText, numberPhoneMiniTextFrame);
        emailMiniText = new Texts(634, 520, 
            font, sizeTextInput, baseColorText,  emailMiniTextFrame);
        backFrameText =   new Texts(151, 914 , font, 24, colorMessage, backText );
    }
    public void Display(RenderWindow _window)
    {
        backgroundFrame.Draw(_window);
        buttonLoginSprite.Draw(_window); 
        buttonNumberPhoneSprite.Draw(_window);
        buttonPasswordSprite.Draw(_window);
        buttonUserNameSprite.Draw(_window);
        buttonNumberPhoneSprite.Draw(_window);
        buttonEmailSprite.Draw(_window);
        buttonFurtherSprite.Draw(_window);
        buttonRepeatPasswordSprite.Draw(_window);
        buttonPasswordHideSprite.Draw(_window);
        buttonRepeatPasswordHideSprite.Draw(_window);
        titleText.Draw(_window);
        loginText.Draw(_window);
        passwordText.Draw(_window);
        repeatPasswordText.Draw(_window);
        userNameText.Draw(_window);
        emailText.Draw(_window);
        numberPhoneText.Draw(_window);
        furtherText.Draw(_window);
        loginMiniText.Draw(_window);
        userNameMiniText.Draw(_window);
        passwordMiniText.Draw(_window);
        repeatPasswordMiniText.Draw(_window);
        numberPhoneMiniText.Draw(_window);
        emailMiniText.Draw(_window);
        warningLoginText.Draw(_window);
        warningUserNameText.Draw(_window);
        warningPasswordText.Draw(_window);
        warningRepeatPasswordText.Draw(_window);
        warningNumberPfoneText.Draw(_window);
        warningEmailText.Draw(_window);
        backFrameText.Draw(_window);
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
                && !isVisibleRepeatPassword)
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
            if (buttonLoginSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagLogin = true;
                line.parametres(flagLogin);
                line.LineParametr(loginMiniTextFrame, cursorNamePosition);
            }
            else
            { flagLogin = false; }
            if (buttonUserNameSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagUserName = true;
                line.parametres(flagUserName);
                line.LineParametr(userNameMiniTextFrame,cursorLnamePosition);
            }
            else
            { flagUserName = false; }
            if (buttonPasswordSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagPassword = true;
                line.parametres(flagPassword);
                line.LineParametr(passwordMiniTextFrame, cursorPasswordPosition);
            }
            else
            { flagPassword = false; }
            if (buttonRepeatPasswordSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                line.parametres(flagRepeatPassword);
                line.LineParametr(repeatPasswordMiniTextFrame, cursorRepeatPasswordPosition);
                flagRepeatPassword = true;
            }
            else
            { flagRepeatPassword = false; }
            if (buttonNumberPhoneSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagNumberPhone = true;
                line.parametres(flagNumberPhone);
                line.LineParametr(numberPhoneMiniTextFrame, cursorNumberPhonePosition);
            }
            else
            { flagNumberPhone = false; }
            if (buttonEmailSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) )
            {
                flags.changeFlag();
                flagEmail = true;
                line.parametres(flagEmail);
                line.LineParametr(emailMiniTextFrame,cursorEmailPosition);
            }
            else
            { flagEmail = false; }
            if (backFrameText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagFrames.ChangeFlagsFrame();
                MainForm.frame1 = true;
            }
            if (buttonFurtherSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                Warning();
                if (!warningFlagLogin && 
                    !warningFlagUserName && 
                    !warningFlagEmail && 
                    !warningFlagNumberPhone &&
                    !warningFlagPassword &&
                    !warningFlagRepeatPassword)
                {
                   flagFrames.ChangeFlagsFrame();
                    _window.Clear(Color.White);
                    MainForm.frame3 = true;
                }
                line.clearLine();
            }
            clock.Restart();
            canClick = false;
        }
        if (flagLogin)
        {
           loginMiniTextFrame = line.GetLine();
           loginMiniText.SetText(loginMiniTextFrame);
           cursorNamePosition = line.GetCursor();
           line.Update(_window);  
        }
        if (flagUserName)
        { 
            userNameMiniTextFrame = line.GetLine();
            cursorLnamePosition = line.GetCursor();
            userNameMiniText.SetText(userNameMiniTextFrame);
            line.Update(_window);
        }
        if (flagPassword)
        {
            passwordMiniTextFrame = line.GetLine();
            cursorPasswordPosition = line.GetCursor();
            if (!isVisiblePassword)
            {
               passwordMiniText.HideText(passwordMiniTextFrame); 
               passwordMiniText.SetPosition(171, 688);
            }
            else if (isVisiblePassword)
            {
               passwordMiniText.SetText(passwordMiniTextFrame); 
               passwordMiniText.SetPosition(171, 682);
            }
           
        }
        if (flagRepeatPassword)
        {
            
            repeatPasswordMiniTextFrame = line.GetLine();
            cursorRepeatPasswordPosition = line.GetCursor();
            
            if (!isVisibleRepeatPassword)
            {
                repeatPasswordMiniText.HideText(repeatPasswordMiniTextFrame); 
                repeatPasswordMiniText.SetPosition(634, 688);
            }
            else if (isVisibleRepeatPassword)
            {
                repeatPasswordMiniText.SetText(repeatPasswordMiniTextFrame); 
                repeatPasswordMiniText.SetPosition(634, 682);
            }
            line.Update(_window);
        }
        if (flagNumberPhone)
        {
            numberPhoneMiniTextFrame = line.GetLine();
            numberPhoneMiniText.SetText(numberPhoneMiniTextFrame);
            cursorNumberPhonePosition = line.GetCursor();
            line.Update(_window);   
        }
        if (flagEmail)
        {
            emailMiniTextFrame = line.GetLine();
            emailMiniText.SetText(emailMiniTextFrame);
            cursorEmailPosition = line.GetCursor();
            line.Update(_window);   
        }
    }
    public void Warning()
    {
        warningLoginText.SetText(warnings.WarningLineName(loginMiniTextFrame));
        warningFlagLogin = warnings.GetWarningFlag();
     
        warningUserNameText.SetText(warnings.WarningLineName(userNameMiniTextFrame));
        warningFlagUserName = warnings.GetWarningFlag();
        
        warningNumberPfoneText.SetText(warnings.WarningLineNumberPhone(numberPhoneMiniTextFrame));
        warningFlagNumberPhone = warnings.GetWarningFlag();
        
        warningPasswordText.SetText(warnings.WarningLinePassword(passwordMiniTextFrame));
        warningFlagPassword = warnings.GetWarningFlag();
        
        warningRepeatPasswordText.SetText(warnings.WarningLineRepeatPassword(repeatPasswordMiniTextFrame, passwordMiniTextFrame));
        warningFlagRepeatPassword = warnings.GetWarningFlag();
        
        warningEmailText.SetText(warnings.WarningLineEmail(emailMiniTextFrame));
        warningFlagEmail = warnings.GetWarningFlag();
    }
    public void workProgram(RenderWindow _window)
    {
        Display(_window);
        ButtonInteraction(_window);
    }    
}