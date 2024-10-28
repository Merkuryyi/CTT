using SFML.Graphics;
using SFML.Window;
using SFML.System;
using CTT;

public class Frame3 
{
    private static Color  baseColorText;
    private static Color nullColorText;
    private static Color warningTextColor;    
    private static Color colorText;
    private static Color colorMessage;
    private static Button backgroundFrame;
    public static Button buttonEmptyNumberPfoneSprite;
    public static Button buttonEmptyEmailSprite;
    private static Button buttonRequestСodeNumberPhoneSprite;
    private static Button buttonRequestСodeEmailSprite;
    private static Button buttonRegistrationSprite;
    private static Button buttonRegistrationOffSprite;
    
    private static Texts titleRequestСodeNumberPhoneTextMini;
    private static Texts requestСodeNumberPhoneText;
    private static Texts titleRequestСodeEmailTextMini;
    private static Texts requestСodeEmailText;
    private static Texts RegistrationText;
    private static Texts warningNumberPhoneText;
    private static Texts warningEmailText;
    private static Texts messageText;

    public static Texts numberPhoneMiniText;
    public static Texts   emailMiniText;

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
    private static Clock clock;
    private static float clickDelay;
    public static int cursorNumberPhonePosition;
    public static int cursorEmailPosition;
    public static string numberPhoneMiniTextFrame2;
    public static string emailMiniTextFrame2;
    public void Structure()
    {
       clock = new Clock();
       clickDelay = 0.5f;
            Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
            
            Texture background = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fonFrames.png"));
            Texture emptyButtonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
           requestСodeTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
            Texture buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistration.png"));
            buttonTextureOff =  new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistrationOff.png"));
            requestСodeOffTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonOff.png"));
            
            
            
            baseColorText = new Color(68, 68, 69);
            nullColorText = new Color(255,255, 255);
            Color colorText = new Color(0, 0, 0);
            warningTextColor = new Color(202, 128, 128);
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
            buttonRegistrationOffSprite = new Button(xLeftBorderFrame, yAvaregeBorderFrame, buttonTextureOff);

       
            
            string registrationText = "Регистрация";
            string requestNumberPhoneText = "Запросить код на номер телефона";
            string requestText =  "Запросить код";
            string requestEmailText =  "Запросить код на почту";
            string registrationTitleText = "Зарегистрироваться";
            string codeTrue = "Код верный";
            string codeFalse = "Код неверный";

            string boxText1 = "Проверьте sms-сообщения и почту. Если код не";
            string boxText2 = "пришел, проверьте спам или запросите код еще";
            string boxText3 = "раз.";    
            string backText = "<назад"; 
            
            numberPhoneMiniTextFrame2 = "";
            emailMiniTextFrame2 = "";
            
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
                font, sizeTextInput, baseColorText, numberPhoneMiniTextFrame2);
            emailMiniText = new Texts(171, 549, 
                font, sizeTextInput, baseColorText,  emailMiniTextFrame2);
           
            
            warningNumberPhoneText = new Texts(151, 416 , font, 20, nullColorText, codeFalse );
            warningEmailText = new Texts(151, 615 , font, 20, nullColorText, codeFalse );
            
            messageText = new Texts(151, 675 , font, 24, nullColorText, boxText1 );
            messageText2 = new Texts(151, 710 , font, 24, nullColorText, boxText2 );
            messageText3 = new Texts(151, 745 , font, 24, nullColorText, boxText3 );
            backFrameText =   new Texts(151, 914 , font, 24, colorMessage, backText );
    }

    public void Warning(RenderWindow _window)
    {
    }

    public void ButtonInteraction(RenderWindow _window)
    {
        RandomClass random = new RandomClass();
        bool canClick = true;
        int numberCodeEmail =  0;
        int numberCodeNumberPhone =  0;
        Vector2i mousePos = Mouse.GetPosition(_window);

        Frame2.flagName = false;
        Frame2.flagLName = false;
        Frame2.flagNumberPhone = false;
         Frame2.flagEmail  = false;
         Frame2.flagPassword = false;
           Frame2.flagRepeatPassword = false;
           InputLine line = new InputLine();
        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
        {
            bool delayPassed = canClick && clock.ElapsedTime.AsSeconds() >= clickDelay;

            if (buttonRequestСodeNumberPhoneSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y) && delayPassed && flagNumberPhoneRequest)
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

            if (buttonRequestСodeEmailSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y) && delayPassed && flagEmailRequest)
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
                frame2.Run2(_window);
            }
            if (buttonRegistrationSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y) && delayPassed)
            {

                buttonRequestСodeEmailSprite.SetTexture(requestСodeTexture);
                buttonRequestСodeNumberPhoneSprite.SetTexture(requestСodeTexture);
                flagEmailRequest = true;
                flagNumberPhoneRequest = true;
                buttonRegistrationSprite.SetTexture(buttonTextureOff);
                warningNumberPhoneText.SetColor(warningTextColor);
                warningEmailText.SetColor(warningTextColor);

                canClick = false;
                clock.Restart(); 
            }
            
            if (buttonEmptyNumberPfoneSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y) && delayPassed)
            {
                flagEmail = false;
                flagNumberPhone = true;
                line.ClearLine();

            }
            if (buttonEmptyEmailSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y) && delayPassed)
            {
                flagEmail = true;
                flagNumberPhone = false;
                line.ClearLine();
            }

        }
      
     //   InputLine line = new InputLine();
       // Line lineNum = new Line(buttonEmptyEmailSprite, cursorEmailPosition, emailMiniTextFrame2 ,flagEmail, false);
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
            canClick = true;
        }
        if (flagNumberPhone)
        {
                
            numberPhoneMiniTextFrame2 = line.GetLine();
            numberPhoneMiniText.SetText(numberPhoneMiniTextFrame2);
            cursorNumberPhonePosition = line.GetCursor();
            line.Update(_window);   
        //    _window.KeyPressed += lineNum.OnKeyPressedName;
                
        }
      //  Line line = new Line(buttonEmptyEmailSprite, cursorEmailPosition, emailMiniTextFrame2 ,flagEmail, false);
        if (flagEmail)
        {
                
            emailMiniTextFrame2 = line.GetLine();
            emailMiniText.SetText(emailMiniTextFrame2);
            cursorEmailPosition = line.GetCursor();
            line.Update(_window); 
         //   _window.KeyPressed += line.OnKeyPressedName;
                
        }

    }

    public void Display3(RenderWindow _window)
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

    public void Ivents(RenderWindow _window)
    {
        
        _window.DispatchEvents();
        _window.Closed += (sender, e) => _window.Close();
        _window.Clear(new Color(233, 233, 233));
    }

    public void Run3(RenderWindow _window)
    {
        Structure();
        InputLine line = new InputLine();
        _window.KeyPressed += line.OnKeyPressedName;
        while (_window.IsOpen)
        {
            Ivents(_window);
            Display3(_window);
            ButtonInteraction(_window);
            _window.Display();


        }


    }

}