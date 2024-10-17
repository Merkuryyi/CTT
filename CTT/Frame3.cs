using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Frame3 
{
   
       public void Run3(RenderWindow _window)
       {
           
            Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
            
            Texture fonFrame2 = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fonFrames.png"));
            
            
            Texture emptyButtonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
            Texture requestСodeTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
            Texture buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistration.png"));
            Texture buttonTextureOff =  new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistrationOff.png"));
            
            Texture requestСodeOffTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonOff.png"));
            
            
            Sprite fonFrame3 = new Sprite(fonFrame2);
            fonFrame3.Position = new Vector2f(53, 53);
            
            Sprite buttonEmptyNumberPfoneSprite = new Sprite(emptyButtonTexture);
            buttonEmptyNumberPfoneSprite.Position = new Vector2f(151, 334);
            
            Sprite buttonEmptyEmailSprite = new Sprite(emptyButtonTexture);
            buttonEmptyEmailSprite.Position = new Vector2f(151, 533);
            
            Sprite buttonRequestСodeNumberPhoneSprite = new Sprite(requestСodeTexture);
            buttonRequestСodeNumberPhoneSprite.Position = new Vector2f(473, 334);
            
            Sprite buttonRequestСodeEmailSprite = new Sprite(requestСodeTexture);
            buttonRequestСodeEmailSprite.Position = new Vector2f(473, 533);
            
            Sprite buttonRegistrationSprite = new Sprite(buttonTexture);
            buttonRegistrationSprite.Position = new Vector2f(151, 838);
            
            Sprite buttonRegistrationOffSprite = new Sprite(buttonTextureOff);
            buttonRegistrationOffSprite.Position = new Vector2f(151, 838);
            
            Text titleText = new Text("Регистрация", font);
            titleText.CharacterSize = 48;
            titleText.FillColor = new Color(68, 68, 69);
            titleText.Position = new Vector2f(138, 125);
            
            
            
            
            Text titlerequestСodeNumberPhoneTextMini = new Text("Запросить код на номер телефона", font);
            titlerequestСodeNumberPhoneTextMini.CharacterSize = 32;
            titlerequestСodeNumberPhoneTextMini.FillColor = new Color(68, 68, 67);
            titlerequestСodeNumberPhoneTextMini.Position = new Vector2f(151, 277);
            
            
            
            
            Text requestСodeNumberPhoneText = new Text("Запросить код", font);
            requestСodeNumberPhoneText.CharacterSize = 20;
            requestСodeNumberPhoneText.FillColor = new Color(35, 35, 35);
            requestСodeNumberPhoneText.Position = new Vector2f(517, 354);
            
            
            
            
            Text titlerequestСodeEmailTextMini = new Text("Запросить код на почту", font);
            titlerequestСodeEmailTextMini.CharacterSize = 32;
            titlerequestСodeEmailTextMini.FillColor = new Color(68, 68, 67);
            titlerequestСodeEmailTextMini.Position = new Vector2f(151, 476);
            
            
            
            Text requestСodeEmailText = new Text("Запросить код", font);
            requestСodeEmailText.CharacterSize = 20;
            requestСodeEmailText.FillColor = new Color(35, 35, 35);
            requestСodeEmailText.Position = new Vector2f(517, 553);
            
            
            Text RegistrationText = new Text("Зарегистрироваться", font);
            RegistrationText.CharacterSize = 32;
            RegistrationText.FillColor = new Color(68, 68, 67);
            RegistrationText.Position = new Vector2f(288, 847);
            
            
            Text messageNumberPhoneText = new Text("Код верный", font);
            messageNumberPhoneText.CharacterSize = 20;
            messageNumberPhoneText.FillColor = new Color(128, 202, 128);
            messageNumberPhoneText.Position = new Vector2f(151, 416);
            
            Text warningNumberPhoneText = new Text("Код неверный", font);
            warningNumberPhoneText.CharacterSize = 20;
            warningNumberPhoneText.FillColor = new Color(255, 255, 255);
            warningNumberPhoneText.Position = new Vector2f(151, 416);
            
            Text messageEmailText = new Text("Код верный", font);
            messageEmailText.CharacterSize = 20;
            messageEmailText.FillColor = new Color(128, 202, 128);
            messageEmailText.Position = new Vector2f(151, 416);
            
            Text warningEmailText = new Text("Код неверный", font);
            warningEmailText.CharacterSize = 20;
            warningEmailText.FillColor = new Color(255, 255, 255);
            warningEmailText.Position = new Vector2f(151, 615);
            
            
            Text messageText = new Text("Проверьте sms-сообщения и почту. Если код не", font);
            messageText.CharacterSize = 24;
            messageText.FillColor = new Color(255, 255, 255);
            //messageText.FillColor = new Color(136, 136, 136);
            messageText.Position = new Vector2f(151, 675);
            
            Text messageText2 = new Text("пришел, проверьте спам или запросите код еще", font);
            messageText2.CharacterSize = 24;
            messageText2.FillColor = new Color(255, 255, 255);
            messageText2.Position = new Vector2f(151, 710);
            
            Text messageText3 = new Text("раз.", font);
            messageText3.CharacterSize = 24;
            messageText3.FillColor = new Color(255, 255, 255);
            messageText3.Position = new Vector2f(151, 745);
            
            bool canClick = false;
            Clock clock = new Clock();
            float clickDelay = 1.0f;
            
            
            
            
            while (_window.IsOpen)
            {
            
                _window.DispatchEvents();
                _window.Closed += (sender, e) => _window.Close();
                _window.Clear(new Color(233, 233, 233)); 
                
                
                _window.Draw(fonFrame3);
                
                _window.Draw(buttonEmptyEmailSprite);
                _window.Draw(buttonEmptyEmailSprite);
                _window.Draw(buttonEmptyNumberPfoneSprite);
                _window.Draw(buttonEmptyEmailSprite);
                
                
                _window.Draw(buttonRegistrationSprite);
                _window.Draw(buttonRequestСodeNumberPhoneSprite);
                _window.Draw(buttonRequestСodeEmailSprite);
                _window.Draw(titleText);
                
                _window.Draw(titlerequestСodeNumberPhoneTextMini);
                _window.Draw(requestСodeNumberPhoneText);
                
                
                _window.Draw(titlerequestСodeEmailTextMini);
                
                _window.Draw(requestСodeEmailText);
                
                _window.Draw(RegistrationText);
                _window.Draw(warningNumberPhoneText);
                _window.Draw(warningEmailText);
                _window.Draw(messageText);
                _window.Draw(messageText2);
                _window.Draw(messageText3);
                       
                if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    Vector2i mousePos = Mouse.GetPosition(_window);
                    if (buttonRequestСodeNumberPhoneSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
                    {
                    
                       buttonRequestСodeNumberPhoneSprite.Texture = requestСodeOffTexture;
                       messageText.FillColor = new Color(136, 136, 136);
                       messageText2.FillColor = new Color(136, 136, 136);
                       messageText3.FillColor = new Color(136, 136, 136);
                       canClick = false;
                       
                    
                    }
                }
                
                if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    Vector2i mousePos = Mouse.GetPosition(_window);
                    if (buttonRequestСodeEmailSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
                    {
                       buttonRequestСodeEmailSprite.Texture = requestСodeOffTexture;
                       messageText.FillColor = new Color(136, 136, 136);
                       messageText2.FillColor = new Color(136, 136, 136);
                       messageText3.FillColor = new Color(136, 136, 136);
                       canClick = false;
                    
                    }
                }
                
                
                if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) && !canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
                {
                    Vector2i mousePos = Mouse.GetPosition(_window);
                    if (buttonRegistrationSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
                    {
                       buttonRequestСodeEmailSprite.Texture = requestСodeTexture;
                       buttonRequestСodeNumberPhoneSprite.Texture = requestСodeTexture;
                       buttonRegistrationSprite.Texture = buttonTextureOff;
                       
                       warningNumberPhoneText.FillColor = new Color(202, 128, 128);
                       warningEmailText.FillColor = new Color(202, 128, 128);
                       canClick = true;
                       clock.Restart();
                    }
                }
                      
               _window.Display();
               

            }


       }

}