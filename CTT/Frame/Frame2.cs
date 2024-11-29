using SFML.Graphics;
using SFML.Window;
using SFML.System;
namespace CTT.Frame;
public class Frame2
{
    private static int cursorLnamePosition;
    private static int cursorNamePosition;
    private static int cursorPasswordPosition;
    private static int cursorRepeatPasswordPosition ;
    private static int cursorNumberPhonePosition;
    private static int cursorEmailPosition;

    private static int yLowerMiniText;
    private static int yHideText;
    
    public static bool flagName;
    private static bool warningFlagName;
    public static bool flagLName;
    private static bool  warningFlagLName;
    public static bool flagPassword;
    private static bool warningFlagPassword;
    public static bool flagRepeatPassword;
    private static bool warningFlagRepeatPassword ;
    public static bool flagNumberPhone;
    private static bool warningFlagNumberPhone;
    public static bool flagEmail;
    private static bool warningFlagEmail;
    private static bool isVisiblePassword;
    private static bool isVisibleRepeatPassword;
    private static bool canClick;
    
    private static Button buttonNameSprite;
    private static Button buttonLNameSprite;
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
    private static Texts nameText;
    private static Texts numberPhoneText;
    private static Texts passwordText;
    private static Texts repeatPasswordText;
    private static Texts lNameText;
    private static Texts emailText;
    private static Texts furtherText;
    
    private static Texts nameMiniText;
    private static Texts lNameMiniText;
    private static Texts passwordMiniText;
    private static Texts repeatPasswordMiniText;
    private static Texts numberPhoneMiniText;
    private static Texts emailMiniText;
    private static Texts warningNameText;
    private static Texts warningLNameText;
    private static Texts warningNumberPfoneText;
    private static Texts warningEmailText;
    private static Texts warningPasswordText;
    private static Texts warningRepeatPasswordText;
    
    public static string nameMiniTextFrame2;
    public static string lMiniTextFrame2;
    public static string passwordMiniTextFrame2;
    private static string repeatPasswordMiniTextFrame2;
    public static string numberPhoneMiniTextFrame2;
    public static string emailMiniTextFrame2;
    private static Color  baseColorText;
    private static Color warningTextColor; 
    private static Color colorMessage;
    private static Texture hideOffTexture;
    private static Texture hideOnTexture;
 
    
    private static Vector2i mousePosition;
    private static Clock clock;
    private static float clickDelay;
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
        
        backgroundFrame = new Button(53, 53, background);
        buttonNameSprite = new Button(151, 336, emptyButtonTexture);
        buttonNumberPhoneSprite = new Button(151, 505,  emptyButtonTexture);
        buttonPasswordSprite = new Button(151,669,  emptyButtonTexture);
        buttonLNameSprite = new Button(614, 336,  emptyButtonTexture);
        buttonEmailSprite= new Button(614, 505,  emptyButtonTexture);
        buttonRepeatPasswordSprite = new Button(614, 669,   emptyButtonTexture);
        buttonFurtherSprite = new Button(386, 838,  buttonTexture);
        buttonPasswordHideSprite = new Button(398, yHideText,  hideOnTexture);
        buttonRepeatPasswordHideSprite = new Button(861, yHideText,  hideOnTexture);
        
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
        
        nameMiniTextFrame2 = "";
        lMiniTextFrame2 = "";
        passwordMiniTextFrame2 = "";
        repeatPasswordMiniTextFrame2 = "";
        numberPhoneMiniTextFrame2 = "";
        emailMiniTextFrame2 = "";
        
        titleText = new Texts(138,125, font, sizeTextTitleFrame, baseColorText, titleTextFrame );
        nameText = new Texts(151, yUpperText, 
            font, sizeTextInput, baseColorText, loginTextFrame );
        numberPhoneText = new Texts(151, yAverageText, 
            font, sizeTextMiniTitle, baseColorText, numberPhoneTextFrame );
        passwordText  = new Texts(151, yLowerText, 
            font, sizeTextMiniTitle, baseColorText, passwordTextFrame );
        lNameText  = new Texts(614, yUpperText, 
            font, sizeTextMiniTitle, baseColorText, userNameTextFrame );
        emailText  = new Texts(614, yAverageText, 
            font, sizeTextMiniTitle, baseColorText, emailTextFrame );
        repeatPasswordText  = new Texts(614, yLowerText, 
            font, sizeTextMiniTitle, baseColorText, repeatPasswordTextFrame );
        
        warningNameText  = new Texts(171, yUpperWarningText, 
            font, sizeWarningText, warningTextColor, "" );
        warningLNameText = new Texts(634, yUpperWarningText, 
            font, sizeWarningText, warningTextColor, "" );
        warningNumberPfoneText = new Texts(171, yAvarageWarningText, 
            font, sizeWarningText, warningTextColor, "" );
        warningEmailText = new Texts(634, yAvarageWarningText,
            font, sizeWarningText, warningTextColor, "" );
        warningPasswordText = new Texts(171, 749,
            font, sizeWarningText,warningTextColor, "" ); 
        warningRepeatPasswordText = new Texts(634, 749,
            font, sizeWarningText,warningTextColor, "" );
        
        furtherText = new Texts(478, yPositionFurtherText, 
            font, sizeTextMiniTitle, baseColorText, furtherTextFrame2 );
        nameMiniText = new Texts(171, yUpperMiniText, 
            font, sizeTextInput, baseColorText, nameMiniTextFrame2 );
        lNameMiniText = new Texts(634, yUpperMiniText, 
            font, sizeTextInput, baseColorText, lMiniTextFrame2 );
        passwordMiniText = new Texts(171, yLowerMiniText,
            font, sizeTextInput, baseColorText, passwordMiniTextFrame2 );
        repeatPasswordMiniText = new Texts(634,yLowerMiniText,
            font, sizeTextInput, baseColorText, repeatPasswordMiniTextFrame2 );
        numberPhoneMiniText = new Texts(171, yAvaregeMiniText, 
            font, sizeTextInput, baseColorText, numberPhoneMiniTextFrame2);
        emailMiniText = new Texts(634, yAvaregeMiniText, 
            font, sizeTextInput, baseColorText,  emailMiniTextFrame2);
        backFrameText =   new Texts(151, 914 , font, 24, colorMessage, backText );
    }
    
    public void Display(RenderWindow _window)
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
    public void clic()
    {
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
            canClick = true;
        }
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
            { flagName = false; }
            
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
            { flagRepeatPassword = false; }
            if (buttonNumberPhoneSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagNumberPhone = true;
                line.parametres(numberPhoneMiniText, flagNumberPhone);
                line.LineParametr(numberPhoneMiniTextFrame2 ,cursorNumberPhonePosition);
            }
            else
            { flagNumberPhone = false; }
            if (buttonEmailSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) )
            {
                flags.changeFlag();
                flagEmail = true;
                line.parametres(emailMiniText, flagEmail);
                line.LineParametr(emailMiniTextFrame2 ,cursorEmailPosition);
            }
            else
            { flagEmail = false; }
            
            if (backFrameText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagFrames.ChangeFlagsFrame();
                MainForm.frame1 = true;
            }
            clock.Restart();
            canClick = false;
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
               passwordMiniText.SetPosition(171, yHideText);
            }
            else if (isVisiblePassword)
            {
               passwordMiniText.SetText(passwordMiniTextFrame2); 
               passwordMiniText.SetPosition(171, yLowerMiniText);
            }
           
        }
        if (flagRepeatPassword)
        {
            
            repeatPasswordMiniTextFrame2 = line.GetLine();
            cursorRepeatPasswordPosition = line.GetCursor();
            
            if (!isVisibleRepeatPassword)
            {
                repeatPasswordMiniText.HideText(repeatPasswordMiniTextFrame2); 
                repeatPasswordMiniText.SetPosition( 634, yHideText);
            }
            else if (isVisibleRepeatPassword)
            {
                repeatPasswordMiniText.SetText(repeatPasswordMiniTextFrame2); 
                repeatPasswordMiniText.SetPosition( 634, yLowerMiniText);
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
   
    public void Warning(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
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
            clock.Restart();
            canClick = false;
        }
    }
    public void workProgram(RenderWindow _window)
    {
        Display(_window);
        ButtonInteraction(_window);
    }    
}