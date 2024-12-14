namespace CTT.Frame;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Login
{
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
        numberPhoneMiniTextFrame = "";
        emailMiniTextFrame = "";
        passwordMiniTextFrame = "";
        Color colorText = new Color(0, 0, 0);
        Color colorMessage = new Color(136, 136, 136);
        baseColorText = new Color(68, 68, 69);
        warningTextColor = new Color(202, 128, 128);
        titleText = new Texts(138, 125, font, 48, baseColorText, title);
        numberPhoneMiniTextsFrame = new Texts(171, 352, font, 32, baseColorText, numberPhoneMiniTextFrame);
        emailMiniText = new Texts(171, 518, font, 32, baseColorText, emailMiniTextFrame);
        passwordMiniText = new Texts(171, 684, font,32, baseColorText, passwordMiniTextFrame);
        numberPhoneText = new Texts(151, 277, font, 32, baseColorText, numberPhone);
        emailText = new Texts(151, 445, font, 32, baseColorText, email);
        passwordText = new Texts(151, 611, font, 32, baseColorText, password);
        backFrameText =   new Texts(151, 939, font, 24, colorMessage, backText);
        warningNumberPhoneText = new Texts(171, 416, font, 20, warningTextColor, "");
        warningEmailText = new Texts(171, 582, font, 20, warningTextColor, "");
        warningFalseText = new Texts(171, 748, font, 20, warningTextColor, "");
        warningFalseText2 = new Texts(171, 776, font, 20, warningTextColor, "");
        loginText = new Texts(255, 870, font, 36, colorText, login);
    }
    private void Warning()
    {
        warningEmailText.SetText(warnings.WarningLineEmail(emailMiniTextFrame));
        warningFlagEmail = warnings.GetWarningFlag();
        warningNumberPhoneText.SetText(warnings.WarningLineNumberPhoneLogin(numberPhoneMiniTextFrame));
        warningFlagNumberPhone = warnings.GetWarningFlag();
        warningFalseText.SetText(warnings.WarningLinePassword(passwordMiniTextFrame));
        warningFlagPassword = warnings.GetWarningFlag();
        string numberPhone = numberPhoneMiniTextFrame;
        string email = emailMiniTextFrame;
        string password = passwordMiniTextFrame;
        bool flag = database.LoginUser(numberPhone, email, password);
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
        else if (flag && !warningFlagEmail && !warningFlagNumberPhone && !warningFlagPassword)
        {
            warningFalseText.SetText("");
            warningFalseText2.SetText("");
            flagEmail = true;
            flagPassword = true;
            flagNumberPhone = true;
            var fullName = database.GetUserFullName(numberPhoneMiniTextFrame, emailMiniTextFrame,
                passwordMiniTextFrame);
            int id = database.GetUserId(numberPhoneMiniTextFrame, emailMiniTextFrame);
            WorkWithJson.SaveToJson(fullName.FirstName, fullName.LastName, numberPhoneMiniTextFrame,
                emailMiniTextFrame, passwordMiniTextFrame);
            database.NotificationsAdd(id, "Выполнен вход", 0);
            flags.ChangeFlag();
            line.clearLine();
            flagFrames.ChangeFlagsFrame();
            string login = database.GetInformation(numberPhone, email, "login");
            string userName = database.GetInformation(numberPhone, email, "userName");
            WorkWithJson.SaveToJson(login, userName, numberPhone, email, passwordMiniTextFrame);
            MainForm.topPanel = true;
            MainForm.frame5 = true;
        }
    }
    private void clic()
    {
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        { canClick = true; }
    }
    private void ButtonInteraction(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
        clic();
        if (Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
            if (backFrameText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            { 
                flags.ChangeFlag();
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
                flags.ChangeFlag();
                flagNumberPhone = true;
                line.LineParametr(numberPhoneMiniTextFrame ,cursorNumberPhonePosition);
            }
            else
            { flagNumberPhone = false; }
            if (buttonEmptyEmailSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.ChangeFlag();
                flagEmail = true;
                line.LineParametr(emailMiniTextFrame ,cursorEmailPosition);
            }
            else
            { flagEmail = false; }
            if (buttonEmptyPasswordSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.ChangeFlag();
                flagPassword = true;
                line.LineParametr(passwordMiniTextFrame ,cursorPasswordPosition);
            }
            else
            { flagPassword = false; }
            if (buttonSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (buttonSprite.IfTexture(buttonTexture))
                { buttonSprite.SetTexture(buttonTextureOff); }
                else if (buttonSprite.IfTexture(buttonTextureOff))
                { buttonSprite.SetTexture(buttonTexture); }
                Warning();
            }
            clock.Restart();
            canClick = false;
        }
        if (flagNumberPhone)
        {
            numberPhoneMiniTextFrame = line.GetLine();
            cursorNumberPhonePosition = line.GetCursor();
            numberPhoneMiniTextsFrame.SetText(numberPhoneMiniTextFrame);
        }
        if (flagEmail)
        {
            emailMiniTextFrame = line.GetLine();
            cursorEmailPosition = line.GetCursor();
            emailMiniText.SetText(emailMiniTextFrame);
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
        }
    }
    public void workProgram(RenderWindow window)
    {
        Display(window);
        ButtonInteraction(window);
        ButtonInteractionRestoreAcess();
    }
    private void Display(RenderWindow _window)
    {
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
        numberPhoneMiniTextsFrame.Draw(_window);
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
    private void WarningRestoreAccess()
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
        warningNumberPhoneTextRestoreAccess.SetText(warnings.WarningLineCode(numberPhoneMiniTextCodeFrame, 
            numberCodeNumberPhone.ToString()));
        flagNumberCodeNumber = warnings.GetWarningFlag();
        warningPasswordTextRestoreAccess.SetText(warnings.WarningLineRepeatPassword(repeatPasswordTextMiniTextResoreAcessFrame, 
            passwordTextMiniTextResoreAcessFrame));
        warningPasswordRestoreAcess = warnings.GetWarningFlag();
        if (!warningPasswordRestoreAcess  && !flagNumberCodeNumber && !flagNumberCodeEmail)
        {
            database.UpdateUser(numberPhoneMiniTextFrame, emailMiniTextFrame, passwordTextMiniTextResoreAcessFrame);
            WorkWithJson.UpdatePasswordInJson(passwordTextMiniTextResoreAcessFrame);
        }
    }
    private void clicRestoreAcess()
    {
        if (!canClickRestoreAcess && clockRestoreAcess.ElapsedTime.AsSeconds() >= clickDelayRestoreAcess)
        { canClickRestoreAcess = true; }
    }
    private void ButtonInteractionRestoreAcess()
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
                { buttonRestoreAccessSprite.SetTexture(buttonRestoreAccessTextureOff); }
                else if (buttonRestoreAccessSprite.IfTexture(buttonRestoreAccessTextureOff))
                { buttonRestoreAccessSprite.SetTexture(buttonRestoreAccessTexture); }
                WarningRestoreAccess();
            }
            if (buttonRequestСodeNumberPhoneSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                && flagNumberPhoneRequest)
            {
                buttonRequestСodeNumberPhoneSpriteRestoreAccess.SetTexture(requestСodeOffTexture);
                flagNumberPhoneRequest = false;
                numberCodeNumberPhone = random.RandomCode();
                Console.WriteLine($"number phone {numberCodeNumberPhone}");
            }
            if (buttonRequestСodeEmailSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) && flagEmailRequest)
            {
                buttonRequestСodeEmailSpriteRestoreAccess.SetTexture(requestСodeOffTexture);
                flagEmailRequest = false;
                numberCodeEmail = random.RandomCode();
                Console.WriteLine($"email {numberCodeEmail}");
            }
            if (buttonEmptyNumberPfoneSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.ChangeFlag();
                flagNumberPhoneRestoreAccess = true;
                line.LineParametr(numberPhoneMiniTextCodeFrame ,cursorNumberPhonePositionRestoreAccess);
            }
          
            if (buttonEmptyEmailSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.ChangeFlag();
                flagEmailRestoreAccess = true;
                line.LineParametr(emailMiniTextCodeFrame, cursorEmailPositionRestoreAccess);
            }
            if (buttonEmptyPasswordSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.ChangeFlag();
                flagPasswordRestoreAccess = true;
                line.LineParametr(passwordTextMiniTextResoreAcessFrame, cursorPasswordPositionRestoreAccess);
            }
            if (buttonEmptyRepeatPasswordSpriteRestoreAccess.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.ChangeFlag();
                flagRepeatPasswordRestoreAccess = true;
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
        }
        if (flagEmailRestoreAccess)
        {
            emailMiniTextCodeFrame = line.GetLine();
            emailMiniTextRestoreAccess.SetText(emailMiniTextCodeFrame);
            cursorEmailPositionRestoreAccess = line.GetCursor();
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
        
        buttonRepeatPasswordHideSprite = new Button(1292, 750,  hideOnTexture);
        backgroundFrameRestoreAccess = new Button(604, 53,backgroundFrameRestoreAccessTexture);
        buttonEmptyNumberPfoneSpriteRestoreAccess = new Button(725, 334, emptyButtonTexture);
        buttonEmptyEmailSpriteRestoreAccess = new Button(725, 531, emptyButtonTexture);
        buttonRequestСodeNumberPhoneSpriteRestoreAccess = new Button(1045, 334, requestСodeTexture);
        buttonRequestСodeEmailSpriteRestoreAccess = new Button(1045, 531, requestСodeTexture);
        buttonRestoreAccessSprite = new Button(725, 863, buttonRestoreAccessTexture);
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
        
        titleTextRestoreAccess = new Texts(706, 125, font, sizeTextTitleFrame, baseColorText, restoreAccessText);
        titleRequestСodeNumberPhoneTextMiniRestoreAccess = new Texts(723, 277, font, 32, baseColorText, requestNumberPhoneText);
        requestСodeNumberPhoneTextRestoreAccess = new Texts(1089, 354, font, 20, colorText, requestText);
        titleRequestСodeEmailTextMiniRestoreAccess = new Texts(723, 476, font, 32, baseColorText, requestEmailText);
        requestСodeEmailTextRestoreAccess = new Texts(1089, 553, font, 20, colorText, requestText);
        restoreAccessTextRestoreAccess = new Texts(916, 870, font, 36, colorText, restoreAccessTitleText);
        titlePasswordTextMiniRestoreAccess = new Texts(723, 673, font, 32, baseColorText, passwordTitle);
        titleRepeatPasswordTextMiniRestoreAccess = new Texts(1045, 673, font, 32, baseColorText, repeatPasswordTitle);
        numberPhoneMiniTextRestoreAccess = new Texts(743, 350, font, sizeTextInput, baseColorText, numberPhoneMiniTextCodeFrame);
        emailMiniTextRestoreAccess = new Texts(743, 549, font, sizeTextInput, baseColorText, emailMiniTextCodeFrame);
        passwordMiniTextRestoreAccess = new Texts(743, 746, font, sizeTextInput, baseColorText, passwordTextMiniTextResoreAcessFrame);
        repeatPasswordMiniTextRestoreAccess = new Texts(1065, 746, font, sizeTextInput, baseColorText, repeatPasswordTextMiniTextResoreAcessFrame);
        warningNumberPhoneTextRestoreAccess = new Texts(743, 414, font, 20, warningTextColor, "");
        warningEmailTextRestoreAccess = new Texts(743, 611, font, 20, warningTextColor, "" );
        warningPasswordTextRestoreAccess = new Texts(743, 810, font, 20, warningTextColor, "" );
    }
     private int cursorEmailPositionRestoreAccess;
    private int cursorNumberPhonePositionRestoreAccess;
    private int cursorPasswordPositionRestoreAccess;
    private int cursorRepeatPasswordPositionRestoreAccess;
    private int cursorNumberPhonePosition;
    private int cursorEmailPosition;
    private int cursorPasswordPosition;
    private Button buttonPasswordHideSpriteRestoreAcess;
    private Button buttonPasswordHideSprite;
    private Button buttonRepeatPasswordHideSprite;
    private Button buttonEmptyRepeatPasswordSpriteRestoreAccess;
    private Button buttonEmptyPasswordSpriteRestoreAccess;
    private Button buttonOffSpriteRestoreAccess;
    private Button buttonEmptyEmailSpriteRestoreAccess;
    private Button buttonRequestСodeNumberPhoneSpriteRestoreAccess;
    private Button buttonRequestСodeEmailSpriteRestoreAccess;
    private Button buttonRestoreAccessSprite;
    private Button buttonEmptyNumberPfoneSpriteRestoreAccess;
    private Button backgroundFrame;
    private Button buttonSprite;
    private Button buttonEmptyNumberPhoneSprite;
    private Button buttonEmptyEmailSprite;
    private Button buttonEmptyPasswordSprite;
    private Button backgroundFrameRestoreAccess;
    private Texts warningPasswordTextRestoreAccess;
    private Texts emailMiniTextRestoreAccess;
    private Texts numberPhoneMiniTextRestoreAccess;
    private Texts titleRepeatPasswordTextMiniRestoreAccess;
    private Texts titlePasswordTextMiniRestoreAccess;
    private Texts warningEmailTextRestoreAccess;
    private Texts warningNumberPhoneTextRestoreAccess;

    private Texts restoreAccessTextRestoreAccess;
    private Texts textRestoreAccess;
    private Texts requestСodeEmailTextRestoreAccess;
    private Texts titleRequestСodeEmailTextMiniRestoreAccess;
    private Texts requestСodeNumberPhoneTextRestoreAccess;
    private Texts titleRequestСodeNumberPhoneTextMiniRestoreAccess;
    private Texts titleTextRestoreAccess;
    
    private Texts backFrameText;
    private Texts warningNumberPhoneText;
    private Texts warningEmailText;
    private Texts titleText;
    private Texts numberPhoneText;
    private Texts emailText;
    private Texts passwordText;
    private Texts warningFalseText;
    private  Texts warningFalseText2;
    private Texts loginText;
    private Texts numberPhoneMiniTextsFrame;
    private Texts passwordMiniText;
    private Texts emailMiniText;
    private Texts repeatPasswordMiniTextRestoreAccess;
    private Texts passwordMiniTextRestoreAccess;
    private string numberPhoneMiniTextFrame;
    private string emailMiniTextFrame;
    public static string passwordMiniTextFrame;
    private string numberPhoneMiniTextCodeFrame;
    private string emailMiniTextCodeFrame;
    private string repeatPasswordTextMiniTextResoreAcessFrame;
    private string passwordTextMiniTextResoreAcessFrame;
    private string warningFalse ;
    private string warningFalse2;
    private string warningPasswordRepeat;
    private Color baseColorText;
    private Color warningTextColor;
    private Texture requestСodeOffTexture;
    private Texture requestСodeTexture;
    private Texture buttonTextureOff;
    private Texture hideOffTexture;
    private Texture hideOnTexture;
    private Texture buttonRestoreAccessTexture;
    private Texture buttonRestoreAccessTextureOff;
    private Texture buttonTexture;
    private Clock clock;
    private float clickDelay;
    private bool canClick;
    private bool flagNumberPhoneRequest = true;
    private bool flagEmailRequest = true;
    private bool canClickRestoreAcess;
    private bool flagNumberCodeNumber;
    private bool flagNumberCodeEmail;
    public static bool flagNumberPhoneRestoreAccess;
    public static bool flagEmailRestoreAccess;
    public static bool flagPasswordRestoreAccess;
    public static bool flagRepeatPasswordRestoreAccess;
    public static bool flagNumberPhone;
    public static bool flagEmail;
    public  static bool flagPassword;  
    private bool flagRestoreAcess;
    private bool isVisiblePassword;
    private bool warningFlagNumberPhone;
    private bool warningFlagEmail ;
    private bool warningFlagPassword;
    private int numberCodeEmail;
    private int numberCodeNumberPhone;
    private bool warningPasswordRestoreAcess;
    private bool isVisiblePasswordRetoreAcess;
    private bool isVisibleRepeatPasswordRetoreAcess;
    private InputLine line;
    private Clock clockRestoreAcess;
    private float clickDelayRestoreAcess;
    private Flags flags;
    private FlagFrames flagFrames;
    private Vector2i mousePosition;
    private Database database;
    private Warnings warnings;
    private RandomClass random;
}
    
