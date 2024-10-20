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
    private static Button buttonEmptyNumberPfoneSprite;
    private static Button buttonEmptyEmailSprite;
    private static Button buttonRequestСodeNumberPhoneSprite;
    private static Button buttonRequestСodeEmailSprite;
    private static Button buttonRegistrationSprite;
    private static Button buttonRegistrationOffSprite;


    private static Texts titleRequestСodeNumberPhoneTextMini;
    private static Texts requestСodeNumberPhoneText;
    private static Texts titleRequestСodeEmailTextMini;
    private static Texts requestСodeEmailText;
    private static Texts RegistrationText;
    private static Texts messageNumberPhoneText;
    private static Texts messageEmailText;
    private static Texts warningNumberPhoneText;
    private static Texts warningEmailText;

    private static Texts messageText;
    //messageText.FillColor = new Color(136, 136, 136);

    private static Texts messageText2;
    private static Texts messageText3;
    

    private static Texts titleText;
       public void Run3(RenderWindow _window)
       {
           
            Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
            
            Texture background = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fonFrames.png"));
            Texture emptyButtonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
            Texture requestСodeTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
            Texture buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistration.png"));
            Texture buttonTextureOff =  new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistrationOff.png"));
            Texture requestСodeOffTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonOff.png"));
            
            
            
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
            RegistrationText = new Texts(288, 847 , font, 32, colorText, registrationText );
            messageNumberPhoneText = new Texts(151, 416 , font, 20, warningTextColor, codeTrue );
            messageEmailText = new Texts(151, 615 , font, 20, warningTextColor, codeTrue );
            warningNumberPhoneText = new Texts(151, 416 , font, 20, nullColorText, codeFalse );
            warningEmailText = new Texts(151, 615 , font, 20, nullColorText, codeFalse );
            
            messageText = new Texts(151, 615 , font, 24, nullColorText, boxText1 );
            //messageText.FillColor = new Color(136, 136, 136);
            
            messageText2 = new Texts(151, 710 , font, 24, nullColorText, boxText2 );
            messageText3 = new Texts(151, 745 , font, 24, nullColorText, boxText3 );
            
            
            bool canClick = false;
            Clock clock = new Clock();
            float clickDelay = 1.0f;
            
            
            
            
            while (_window.IsOpen)
            {
            
                _window.DispatchEvents();
                _window.Closed += (sender, e) => _window.Close();
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
              
                
                       
                if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    Vector2i mousePos = Mouse.GetPosition(_window);
                    if (buttonRequestСodeNumberPhoneSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
                    {
                    
                       buttonRequestСodeNumberPhoneSprite.SetTexture(requestСodeOffTexture) ;
                       messageText.SetColor( colorMessage);
                       messageText2.SetColor( colorMessage);
                       messageText3.SetColor( colorMessage);
                       canClick = false;
                       
                    
                    }
                }
                
                if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    Vector2i mousePos = Mouse.GetPosition(_window);
                    if (buttonRequestСodeEmailSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
                    {
                       buttonRequestСodeEmailSprite.SetTexture(requestСodeOffTexture);
                       messageText.SetColor(colorMessage);
                       messageText2.SetColor( colorMessage);
                       messageText3.SetColor( colorMessage);
                       canClick = false;
                    
                    }
                }
                
                
                if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) && !canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
                {
                    Vector2i mousePos = Mouse.GetPosition(_window);
                    if (buttonRegistrationSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
                    {
                       buttonRequestСodeEmailSprite.SetTexture(requestСodeTexture);
                       buttonRequestСodeNumberPhoneSprite.SetTexture(requestСodeTexture);
                       buttonRegistrationSprite.SetTexture(buttonTextureOff)  ;
                       
                       warningNumberPhoneText.SetColor(warningTextColor);
                       warningEmailText.SetColor(warningTextColor);
                       canClick = true;
                       clock.Restart();
                    }
                }
                      
               _window.Display();
               

            }


       }

}