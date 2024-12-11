using SFML.Graphics;
using SFML.Window;
using SFML.System;
namespace CTT.Frame;

public class ConfirmationRegistration
{
    private static bool flagEmailCodeNext = true;
    private static bool flagNumberPhoneCodeNext = true;
    private static int cursorNumberPhonePosition;
    private static int cursorEmailPosition;
    private static int numberCodeEmail;
    private static int numberCodeNumberPhone;

    private static Button backgroundFrame;
    private static Button buttonEmptyNumberPfoneSprite;
    private static Button buttonEmptyEmailSprite;
    private static Button buttonRequestСodeNumberPhoneSprite;
    private static Button buttonRequestСodeEmailSprite;
    private static Button buttonRegistrationSprite;
    
    private static Texts titleRequestСodeNumberPhoneTextMini;
    private static Texts requestСodeNumberPhoneText;
    private static Texts titleRequestСodeEmailTextMini;
    private static Texts requestСodeEmailText;
    private static Texts RegistrationText;
    private static Texts warningNumberPhoneText;
    private static Texts warningEmailText;
    private static Texts messageText;
    private static Texts numberPhoneMiniText;
    private static Texts emailMiniText;
    private static Texts backFrameText;
    private static Texts messageText2;
    private static Texts messageText3;
    private static Texts titleText;
    
    private static Texture requestСodeOffTexture;
    private static Texture requestСodeTexture;
    private static Texture buttonTextureOff;

    private static Color colorMessage;
    public static bool flagNumberPhone;
    public static bool flagEmail;
    private static bool flagNumberPhoneRequest = true;
    private static bool flagEmailRequest = true;
    private static bool nextWindow;
    private static bool canClick;
    private static string numberPhoneMiniTextFrame;
    private static string emailMiniTextFrame;
    
    private static float clickDelay;
    private static Clock clock;
    private static RandomClass random;
    private static Flags flags;
    private static InputLine line;
    private static Database database;
    private static Warnings warningText;
    private static FlagFrames flagFrames;
    private static Vector2i mousePosition;
    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;  
        random = new RandomClass();
        flags = new Flags();
        line = new InputLine();
        database = new Database();
        warningText = new Warnings();
        flagFrames = new FlagFrames();
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        Texture background = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgoundFrames.png"));
        Texture emptyButtonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
        requestСodeTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
        Texture buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistration.png"));
        buttonTextureOff =  new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistrationOff.png"));
        requestСodeOffTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonOff.png"));
        
        Color baseColorText = new Color(68, 68, 69);
        Color nullColorText = new Color(255,255, 255);
        Color colorText = new Color(0, 0, 0);
        Color warningTextColor = new Color(202, 128, 128);
        
        colorMessage = new Color(136, 136, 136);
        backgroundFrame = new Button(53, 53, background);
        buttonEmptyNumberPfoneSprite = new Button(151, 334, emptyButtonTexture);
        buttonEmptyEmailSprite = new Button(151, 533, emptyButtonTexture);
        buttonRequestСodeNumberPhoneSprite = new Button(473, 334, requestСodeTexture);
        buttonRequestСodeEmailSprite = new Button(473, 533, requestСodeTexture);
        buttonRegistrationSprite = new Button(151, 838, buttonTexture);
        
        string registrationText = "Регистрация";
        string requestNumberPhoneText = "Запросить код на номер телефона";
        string requestText =  "Запросить код";
        string requestEmailText =  "Запросить код на почту";
        string registrationTitleText = "Зарегистрироваться";
        
        string boxText1 = "Проверьте sms-сообщения и почту. Если код не";
        string boxText2 = "пришел, проверьте спам или запросите код еще";
        string boxText3 = "раз.";    
        string backText = "<назад"; 
      
        numberPhoneMiniTextFrame = "";
        emailMiniTextFrame = "";

        uint sizeTextMax = 64;
        uint sizeTextTitleFrame = 48;
        uint sizeTextMiniTitle = 36;
        uint sizeTextInput = 32;
        uint sizeWarningText = 20;

        titleText = new Texts(138, 125 , font, sizeTextTitleFrame, baseColorText, registrationText);
        titleRequestСodeNumberPhoneTextMini = new Texts(151, 277 , font, 32, baseColorText, requestNumberPhoneText);
        requestСodeNumberPhoneText = new Texts(517, 354 , font, 20, colorText, requestText);
        titleRequestСodeEmailTextMini = new Texts(151, 476 , font, 32, baseColorText, requestEmailText);
        requestСodeEmailText = new Texts(517, 553 , font, 20, colorText, requestText);
        RegistrationText = new Texts(293, 847 , font, 32, colorText, registrationTitleText);
        numberPhoneMiniText = new Texts(171, 350, font, sizeTextInput, baseColorText, numberPhoneMiniTextFrame);
        emailMiniText = new Texts(171, 549, font, sizeTextInput, baseColorText, emailMiniTextFrame);
        warningNumberPhoneText = new Texts(171, 414 , font, 20, warningTextColor, "" );
        warningEmailText = new Texts(171, 613 , font, 20, warningTextColor, "");
        messageText = new Texts(151, 675, font, 24, nullColorText, boxText1);
        messageText2 = new Texts(151, 710, font, 24, nullColorText, boxText2);
        messageText3 = new Texts(151, 745, font, 24, nullColorText, boxText3);
        backFrameText = new Texts(151, 914, font, 24, colorMessage, backText);
    }
    public void clic()
    {
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
            canClick = true;
        }
    }
    public void Warning()
    {
        warningEmailText.SetText(warningText.WarningLineCode(emailMiniTextFrame, numberCodeEmail.ToString()));
        flagEmailCodeNext = warningText.GetWarningFlag();
        warningNumberPhoneText.SetText(warningText.WarningLineCode(numberPhoneMiniTextFrame, numberCodeNumberPhone.ToString()));
        flagNumberPhoneCodeNext = warningText.GetWarningFlag();
        
        if (!flagEmailCodeNext && !flagNumberPhoneCodeNext )
        {
            string name = Registration.loginMiniTextFrame;
            string lname = Registration.userNameMiniTextFrame;
            string numberPhone = Registration.numberPhoneMiniTextFrame;
            string email = Registration.emailMiniTextFrame;
            string password = Registration.passwordMiniTextFrame;
            database.RegistrationUser(name, lname, numberPhone, email ,password);
            nextWindow = true;
            int id = database.GetUserId(numberPhone, email);
            WorkWithJson.SaveToJson(Registration.loginMiniTextFrame, Registration.userNameMiniTextFrame,
            Registration.numberPhoneMiniTextFrame,
            Registration.emailMiniTextFrame, Registration.passwordMiniTextFrame);
            database.NotificationsAdd(id, "Выполнен вход", 0);
        }
    }
    public void ButtonInteraction(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
       
        clic();
        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
            if (buttonRegistrationSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                buttonRegistrationSprite.SetTexture(buttonTextureOff);
                buttonRequestСodeNumberPhoneSprite.SetTexture(requestСodeTexture);
                buttonRequestСodeEmailSprite.SetTexture(requestСodeTexture);
                flagEmailRequest = true;
                flagNumberPhoneRequest = true;
                Warning();
            }
            if (buttonRequestСodeNumberPhoneSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)  && flagNumberPhoneRequest)
            {
                if (buttonRequestСodeNumberPhoneSprite.IfTexture(requestСodeTexture))
                {
                    buttonRequestСodeNumberPhoneSprite.SetTexture(requestСodeOffTexture);
                    flagNumberPhoneRequest = false;
                }
                messageText.SetColor(colorMessage);
                messageText2.SetColor(colorMessage);
                messageText3.SetColor(colorMessage);
                numberCodeNumberPhone = random.randomCode();
                Console.WriteLine($"number phone {numberCodeNumberPhone}");
            }

            if (buttonRequestСodeEmailSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)  && flagEmailRequest)
            {
                if (buttonRequestСodeEmailSprite.IfTexture(requestСodeTexture))
                {
                    buttonRequestСodeEmailSprite.SetTexture(requestСodeOffTexture);
                    flagEmailRequest = false;
                }
                buttonRequestСodeEmailSprite.SetTexture(requestСodeOffTexture);
                messageText.SetColor(colorMessage);
                messageText2.SetColor(colorMessage);
                messageText3.SetColor(colorMessage);
                numberCodeEmail = random.randomCode();
                Console.WriteLine($"email {numberCodeEmail}");
            }
           
            if (backFrameText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagFrames.ChangeFlagsFrame();
                MainForm.frame2 = true;
            }
            if (buttonEmptyNumberPfoneSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagNumberPhone = true;
                line.parametres(flagNumberPhone);
                line.LineParametr(numberPhoneMiniTextFrame , cursorNumberPhonePosition);
            }
            else
            { flagNumberPhone = false; }
            if (buttonEmptyEmailSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.changeFlag();
                flagEmail = true;
                line.parametres(flagEmail);
                line.LineParametr(emailMiniTextFrame, cursorEmailPosition);
            }
            else
            { flagEmail = false; }
            clock.Restart();
            canClick = false;
        }
        if (flagNumberPhone)
        {
            numberPhoneMiniTextFrame = line.GetLine();
            numberPhoneMiniText.SetText(numberPhoneMiniTextFrame);
            cursorNumberPhonePosition = line.GetCursor();
        }
        if (flagEmail)
        { 
            emailMiniTextFrame = line.GetLine();
            emailMiniText.SetText(emailMiniTextFrame);
            cursorEmailPosition = line.GetCursor();
        }
    }
    public void Display(RenderWindow _window)
    {
        backgroundFrame.Draw(_window);
        buttonEmptyEmailSprite.Draw(_window);
        buttonEmptyNumberPfoneSprite.Draw(_window);
        buttonRegistrationSprite.Draw(_window);
        buttonRequestСodeNumberPhoneSprite.Draw(_window);
        buttonRequestСodeEmailSprite.Draw(_window);
        buttonEmptyEmailSprite.Draw(_window);   
        buttonEmptyEmailSprite.Draw(_window);
        titleText.Draw(_window); 
        titleRequestСodeNumberPhoneTextMini.Draw(_window); 
        requestСodeNumberPhoneText.Draw(_window); 
        titleRequestСodeEmailTextMini.Draw(_window); 
        requestСodeEmailText.Draw(_window); 
        RegistrationText.Draw(_window); 
        warningNumberPhoneText.Draw(_window);
        warningEmailText.Draw(_window); 
        messageText.Draw(_window); 
        messageText2.Draw(_window); 
        messageText3.Draw(_window); 
        backFrameText.Draw(_window);
        emailMiniText.Draw(_window);
        numberPhoneMiniText.Draw(_window);
    }
    public void workProgram (RenderWindow _window)
    {
        Display(_window);
        ButtonInteraction(_window);
    }
}