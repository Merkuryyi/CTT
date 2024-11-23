using SFML.Graphics;
using SFML.Window;
using SFML.System;
using CTT;

public class Frame3
{
    private static bool flagEmailCodeNext = true;
    private static bool flagNumberPhoneCodeNext = true;
    private static Color  baseColorText;
    private static Color nullColorText;
    private static Color warningTextColor;
    private static Color trueWarningTextColor;
    
    private static Color colorMessage;
    
    private static Button backgroundFrame;
    public static Button buttonEmptyNumberPfoneSprite;
    public static Button buttonEmptyEmailSprite;
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

    public static Texts numberPhoneMiniText;
    public static Texts  emailMiniText;

    private static Texts backFrameText;
    private static Texts messageText2;
    private static Texts messageText3;
    private static Texts titleText;
    private static Texture requestСodeOffTexture;
    private static Texture requestСodeTexture;
    private static Texture buttonTextureOff;

    public static bool flagNumberPhone = false;
    public static bool flagEmail = false;
    
    private static bool flagNumberPhoneRequest = true;
    private static bool flagEmailRequest = true;
    private static  bool canClick = false;
    
    private static Clock clock;
    private static float clickDelay;
    
    public static int cursorNumberPhonePosition;
    public static int cursorEmailPosition;
    public static string numberPhoneMiniTextFrame3;
    public static string emailMiniTextFrame3;
    
    public static int numberCodeEmail =  0;
    public static int numberCodeNumberPhone =  0;
    public static string  warningTextFrame3;
    public static string codeTrue;
    public static string codeFalse;
    private static InputLine line;
    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;    
        line = new InputLine();
        
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");

        Texture background = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgoundFrames.png"));
        Texture emptyButtonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
        requestСodeTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
        Texture buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistration.png"));
        buttonTextureOff =  new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistrationOff.png"));
        requestСodeOffTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonOff.png"));



        baseColorText = new Color(68, 68, 69);
        nullColorText = new Color(255,255, 255);
        Color colorText = new Color(0, 0, 0);
        warningTextColor = new Color(202, 128, 128);
        trueWarningTextColor = new Color(128,202,  128);
        colorMessage = new Color(136, 136, 136);



        int xyPositionBackground = 53;
        int xLeftBorderFrame = 151;
        int xRightBorderFrame = 473;
        int yUpperBorderFrame = 334;
        int yLowerBorderFrame =  533;
        int yAvaregeBorderFrame = 838;

        backgroundFrame = new Button(xyPositionBackground, xyPositionBackground, background);
        buttonEmptyNumberPfoneSprite = new Button(xLeftBorderFrame, yUpperBorderFrame, emptyButtonTexture);
        buttonEmptyEmailSprite = new Button(xLeftBorderFrame, yLowerBorderFrame, emptyButtonTexture);
        buttonRequestСodeNumberPhoneSprite = new Button(xRightBorderFrame, yUpperBorderFrame, requestСodeTexture);
        buttonRequestСodeEmailSprite = new Button(xRightBorderFrame, yLowerBorderFrame, requestСodeTexture);
        buttonRegistrationSprite = new Button(xLeftBorderFrame, yAvaregeBorderFrame, buttonTexture);




        string registrationText = "Регистрация";
        string requestNumberPhoneText = "Запросить код на номер телефона";
        string requestText =  "Запросить код";
        string requestEmailText =  "Запросить код на почту";
        string registrationTitleText = "Зарегистрироваться";
        codeTrue = "*Код верный";
        codeFalse = "*Код неверный";

        string boxText1 = "Проверьте sms-сообщения и почту. Если код не";
        string boxText2 = "пришел, проверьте спам или запросите код еще";
        string boxText3 = "раз.";    
        string backText = "<назад"; 
        warningTextFrame3 = "*обязательно";
        numberPhoneMiniTextFrame3 = "";
        emailMiniTextFrame3 = "";

        uint sizeTextMax = 64;
        uint sizeTextTitleFrame = 48;
        uint sizeTextMiniTitle = 36;
        uint sizeTextInput = 32;
        uint sizeWarningText = 20;

        titleText = new Texts(138, 125 , font, sizeTextTitleFrame, baseColorText, registrationText );
        titleRequestСodeNumberPhoneTextMini = new Texts(151, 277 , font, 32, baseColorText, requestNumberPhoneText );
        requestСodeNumberPhoneText = new Texts(517, 354 , font, 20, colorText, requestText );
        titleRequestСodeEmailTextMini = new Texts(151, 476 , font, 32, baseColorText, requestEmailText );
        requestСodeEmailText = new Texts(517, 553 , font, 20, colorText, requestText );
        RegistrationText = new Texts(293, 847 , font, 32, colorText, registrationTitleText );

        numberPhoneMiniText = new Texts(171, 350, 
            font, sizeTextInput, baseColorText, numberPhoneMiniTextFrame3);
        emailMiniText = new Texts(171, 549, 
            font, sizeTextInput, baseColorText,  emailMiniTextFrame3);


        warningNumberPhoneText = new Texts(171, 414 , font, 20, nullColorText, codeFalse );
        warningEmailText = new Texts(171, 613 , font, 20, nullColorText, codeFalse );

        messageText = new Texts(151, 675 , font, 24, nullColorText, boxText1 );
        messageText2 = new Texts(151, 710 , font, 24, nullColorText, boxText2 );
        messageText3 = new Texts(151, 745 , font, 24, nullColorText, boxText3 );
        backFrameText =   new Texts(151, 914 , font, 24, colorMessage, backText );
       
    }

    public void Warning(RenderWindow _window)
    {
        
        Vector2i mousePosition = Mouse.GetPosition(_window);
     
        if (Mouse.IsButtonPressed(Mouse.Button.Left)  &&
             buttonRegistrationSprite.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) )
        {
            buttonRegistrationSprite.SetTexture(buttonTextureOff);
            
            if (!flagEmailRequest)
            {
                flagEmailRequest = true;
                buttonRequestСodeEmailSprite.SetTexture(requestСodeTexture);
            }

            if (!flagNumberPhoneRequest)
            {
                buttonRequestСodeNumberPhoneSprite.SetTexture(requestСodeTexture);
           
                flagNumberPhoneRequest = true;
                
            }
          
            


            canClick = false;
            clock.Restart(); 
            if (numberCodeEmail.ToString() == emailMiniTextFrame3)
            {
                warningEmailText.SetText(codeTrue);
                warningEmailText.SetColor(trueWarningTextColor);
            }
            else  if (numberCodeEmail.ToString() != emailMiniTextFrame3)
            {
                warningEmailText.SetText(codeFalse);
                warningEmailText.SetColor(warningTextColor);
                flagEmailCodeNext = true;

            }
            else
            {
                flagEmailCodeNext = false;
            }
            if (emailMiniTextFrame3 == "")
            {
                warningEmailText.SetColor(warningTextColor);
                warningEmailText.SetText(warningTextFrame3);
                flagNumberPhone = true;
            }
            else
            {
                flagEmailCodeNext = false;
            }
           

            if (numberCodeNumberPhone.ToString() == numberPhoneMiniTextFrame3)
            {
                warningNumberPhoneText.SetText(codeTrue);
                warningNumberPhoneText.SetColor(trueWarningTextColor);
            }
            else  if (numberCodeNumberPhone.ToString() != numberPhoneMiniTextFrame3)
            {
                warningNumberPhoneText.SetText(codeFalse);
                warningNumberPhoneText.SetColor(warningTextColor);
                flagNumberPhoneCodeNext = true;
            }
            else
            {
                flagNumberPhoneCodeNext = false;
            }
            if (numberPhoneMiniTextFrame3 == "")
            {
                warningNumberPhoneText.SetText(warningTextFrame3);
                warningNumberPhoneText.SetColor(warningTextColor);
                flagNumberPhoneCodeNext = true;
            }
            else
            {
                flagNumberPhoneCodeNext = false;
            }
            Database database = new Database();
          
            if (!flagEmailCodeNext && !flagNumberPhoneCodeNext )
            {
                string name = Frame2.nameMiniTextFrame2;
                string lname = Frame2.lMiniTextFrame2;
                string numberPhone = Frame2.numberPhoneMiniTextFrame2;
                string email = Frame2.emailMiniTextFrame2;
                string password = Frame2.passwordMiniTextFrame2;
                database.registrationUser(name, lname, numberPhone , email ,password);
            }
            canClick = false;
            clock.Restart(); 
        }
    }

    public void ButtonInteraction(RenderWindow _window)
    {
        RandomClass random = new RandomClass();
        Flags flags = new Flags();
        Vector2i mousePos = Mouse.GetPosition(_window);
  
         
        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
            if (buttonRequestСodeNumberPhoneSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y)  && flagNumberPhoneRequest)
            {
                buttonRequestСodeNumberPhoneSprite.SetTexture(requestСodeOffTexture);
                messageText.SetColor(colorMessage);
                messageText2.SetColor(colorMessage);
                messageText3.SetColor(colorMessage);
                canClick = false;
                clock.Restart();
                flagNumberPhoneRequest = false;
                numberCodeNumberPhone = random.randomCode();
                Console.WriteLine($"number phone {numberCodeNumberPhone}");
            }

            if (buttonRequestСodeEmailSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y)  && flagEmailRequest)
            {
                buttonRequestСodeEmailSprite.SetTexture(requestСodeOffTexture);
                messageText.SetColor(colorMessage);
                messageText2.SetColor(colorMessage);
                messageText3.SetColor(colorMessage);

                flagEmailRequest = false;
                numberCodeEmail = random.randomCode();
                Console.WriteLine($"email {numberCodeEmail}");

                canClick = false;
                clock.Restart();
            }
            if (backFrameText.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
            {
                Frame2 frame2 = new Frame2();
                frame2.workProgram(_window);
            }
            
            
            if (buttonEmptyNumberPfoneSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y) )
            {
                flags.changeFlag();
                flagNumberPhone = true;
            
                line.LineParametr();

            }
            else
            { flagNumberPhone = false; }
            if (buttonEmptyEmailSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
            {
                flags.changeFlag();
                flagEmail = true;
                line.LineParametr();
            }
            else
            { flagEmail = false; }
            Warning(_window);
            canClick = false;
            clock.Restart(); 
            
        }
        
        if (flagNumberPhone)
        {
                
            numberPhoneMiniTextFrame3 = line.GetLine();
            numberPhoneMiniText.SetText(numberPhoneMiniTextFrame3);
            cursorNumberPhonePosition = line.GetCursor();
            
            line.Update(_window);   
  
                
        }
    
        if (flagEmail)
        {
                
            emailMiniTextFrame3 = line.GetLine();
            emailMiniText.SetText(emailMiniTextFrame3);
            cursorEmailPosition = line.GetCursor();
            line.Update(_window); 
                
        }
        Warning(_window);
    }

    public void Display3(RenderWindow _window)
    {
         
        _window.Clear(new Color(233, 233, 233));      
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

    public void Ivents(RenderWindow _window)
    {
        
        _window.DispatchEvents();
        _window.Closed += (sender, e) => _window.Close();
        _window.KeyPressed += line.OnKeyPressedName;
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
            canClick = true;
        }
    }

    public void Run3(RenderWindow _window)
    {
        while (_window.IsOpen)
        {
          
            Ivents(_window);
            Display3(_window);
            ButtonInteraction(_window);
            _window.Display();
           
        }
    }
}