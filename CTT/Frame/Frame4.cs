using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Frame4
{

    private static RenderWindow _window;
    public void Run4(RenderWindow _window)
    {
        Texture fon = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fonFrame4.png"));
        Texture emptyButtonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
        Texture buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
        Texture buttonTextureOff = new Texture( Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonOff.png"));
        
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");

        Sprite fonFrame4 = new Sprite(fon);
        fonFrame4.Position = new Vector2f(53, 53);
        
    
        
        
        
        
        Sprite buttonSprite = new Sprite(buttonTexture);
        buttonSprite.Position = new Vector2f(151, 861);

        Sprite buttonEmptyNumberPhoneSprite = new Sprite(emptyButtonTexture);
        buttonEmptyNumberPhoneSprite.Position = new Vector2f(151, 334);

        Sprite buttonEmptyEmailSprite = new Sprite(emptyButtonTexture);
        buttonEmptyEmailSprite.Position = new Vector2f(151, 500);

        Sprite buttonEmptyPasswordSprite = new Sprite(emptyButtonTexture);
        buttonEmptyPasswordSprite.Position = new Vector2f(151, 666);

        Text titleText = new Text("Вход", font);
        titleText.CharacterSize = 48;
        titleText.FillColor = new Color(68, 68, 69);
        titleText.Position = new Vector2f(138, 125);

        Text numberPhoneText = new Text("Номер телефона", font);
        numberPhoneText.CharacterSize = 32;
        numberPhoneText.FillColor = new Color(68, 68, 69);
        numberPhoneText.Position = new Vector2f(151, 275);

        Text emailText = new Text("Почта", font);
        emailText.CharacterSize = 32;
        emailText.FillColor = new Color(68, 68, 69);
        emailText.Position = new Vector2f(151, 443);

        Text passwordText = new Text("Пароль", font);
        passwordText.CharacterSize = 32;
        passwordText.FillColor = new Color(68, 68, 69);
        passwordText.Position = new Vector2f(151, 609);

        Text warningFalseText = new Text("Не верная почта, номер ", font);
        warningFalseText.CharacterSize = 20;
        warningFalseText.FillColor = new Color(202, 128, 128);
        warningFalseText.Position = new Vector2f(151, 748);


        Text warningFalseText2 = new Text("телефона или пароль", font);
        warningFalseText2.CharacterSize = 20;
        warningFalseText2.FillColor = new Color(202, 128, 128);
        warningFalseText2.Position = new Vector2f(151, 776);


        Text loginText = new Text("Вход", font);
        loginText.CharacterSize = 36;
        loginText.FillColor = new Color(68, 68, 69);
        loginText.Position = new Vector2f(262, 870);

       
      
        
        
        
        while (_window.IsOpen)
        {
            _window.Clear(new Color(233, 233, 233));
           
            
            
            
            _window.DispatchEvents();
         
            
            _window.Draw(fonFrame4);
           
            _window.Draw(buttonEmptyNumberPhoneSprite);
            _window.Draw(buttonSprite);
            _window.Draw(buttonEmptyEmailSprite);
            _window.Draw(buttonEmptyPasswordSprite);
            _window.Draw(titleText);
            _window.Draw(loginText);
            _window.Draw(numberPhoneText);
            _window.Draw(emailText);
            _window.Draw(passwordText);
            _window.Draw(warningFalseText);
            _window.Draw(warningFalseText2);
            _window.Display();
            if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                Vector2i mousePos = Mouse.GetPosition(_window);
                if (buttonSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
                {
                    buttonSprite.Texture = buttonTextureOff;
                    restoreAccess(_window);
                    


                }
            }
            
           

        }


    }
    
    
   


        public void restoreAccess (RenderWindow _window)
        {
            
            Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
            
          
            Texture fonFrameRestoreAccess= new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fonFrames.png"));
            Texture emptyButtonTexture41 = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
            Texture requestСodeTexture41 = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
            Texture buttonTexture41 = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistration.png"));
            Texture buttonTextureOff41 =  new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonRegistrationOff.png"));
            Texture requestСodeOffTexture41 = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonOff.png"));
            
            Sprite fonFrame41 = new Sprite(fonFrameRestoreAccess);
            fonFrame41.Position = new Vector2f(604, 53);
            
            Sprite buttonEmptyNumberPfoneSprite41 = new Sprite(emptyButtonTexture41);
            buttonEmptyNumberPfoneSprite41.Position = new Vector2f(723, 332);

            Sprite buttonEmptyEmailSprite41 = new Sprite(emptyButtonTexture41);
            buttonEmptyEmailSprite41.Position = new Vector2f(723, 531);
            
            Sprite buttonEmptyPasswordSprite41 = new Sprite(emptyButtonTexture41);
            buttonEmptyPasswordSprite41.Position = new Vector2f(723, 714);
            
            Sprite buttonEmptyRepeatPasswordSprite41 = new Sprite(emptyButtonTexture41);
            buttonEmptyRepeatPasswordSprite41.Position = new Vector2f(1045, 714);

            Sprite buttonRequestСodeNumberPhoneSprite41 = new Sprite(requestСodeTexture41);
            buttonRequestСodeNumberPhoneSprite41.Position = new Vector2f(1045, 331);
            
            Sprite buttonRequestСodeEmailSprite = new Sprite(requestСodeTexture41);
            buttonRequestСodeEmailSprite.Position = new Vector2f(1045, 531);

            Sprite buttonResetPasswordSprite41 = new Sprite(buttonTexture41);
            buttonResetPasswordSprite41.Position = new Vector2f(725, 859);

            Sprite buttonResetPasswordOffSprite41 = new Sprite(buttonTextureOff41);
            buttonResetPasswordOffSprite41.Position = new Vector2f(725, 859);
            
            Text titleText41 = new Text("Восстановить доступ", font);
            titleText41.CharacterSize = 48;
            titleText41.FillColor = new Color(68, 68, 69);
            titleText41.Position = new Vector2f(706, 125);
            
            
            Text passwordText41 = new Text("Пароль", font);
            passwordText41.CharacterSize = 32;
            passwordText41.FillColor = new Color(68, 68, 69);
            passwordText41.Position = new Vector2f(723, 657);
            
            Text repeatPasswordText41 = new Text("Повторите пароль", font);
            repeatPasswordText41.CharacterSize = 32;
            repeatPasswordText41.FillColor = new Color(68, 68, 69);
            repeatPasswordText41.Position = new Vector2f(1045, 657);
            
            
            
            Text titlerequestСodeNumberPhoneTextMini41 = new Text("Запросить код на номер телефона", font);
            titlerequestСodeNumberPhoneTextMini41.CharacterSize = 32;
            titlerequestСodeNumberPhoneTextMini41.FillColor = new Color(68, 68, 67);
            titlerequestСodeNumberPhoneTextMini41.Position = new Vector2f(723, 275);




            Text requestСodeNumberPhoneText41 = new Text("Запросить код", font);
            requestСodeNumberPhoneText41.CharacterSize = 20;
            requestСodeNumberPhoneText41.FillColor = new Color(35, 35, 35);
            requestСodeNumberPhoneText41.Position = new Vector2f(1089, 352);




            Text titlerequestСodeEmailTextMini41 = new Text("Запросить код на почту", font);
            titlerequestСodeEmailTextMini41.CharacterSize = 32;
            titlerequestСodeEmailTextMini41.FillColor = new Color(68, 68, 67);
            titlerequestСodeEmailTextMini41.Position = new Vector2f(723, 474);



            Text requestСodeEmailText41 = new Text("Запросить код", font);
            requestСodeEmailText41.CharacterSize = 20;
            requestСodeEmailText41.FillColor = new Color(35, 35, 35);
            requestСodeEmailText41.Position = new Vector2f(1089, 551);
            
            Text messageNumberPhoneText41 = new Text("Код верный", font);
            messageNumberPhoneText41.CharacterSize = 20;
            messageNumberPhoneText41.FillColor = new Color(128, 202, 128);
            messageNumberPhoneText41.Position = new Vector2f(723, 414);

            Text warningNumberPhoneText41 = new Text("Код неверный", font);
            warningNumberPhoneText41.CharacterSize = 20;
            warningNumberPhoneText41.FillColor = new Color(255, 255, 255);
            warningNumberPhoneText41.Position = new Vector2f(723, 414);

            Text messageEmailText41 = new Text("Код верный", font);
            messageEmailText41.CharacterSize = 20;
            messageEmailText41.FillColor = new Color(128, 202, 128);
            messageEmailText41.Position = new Vector2f(723, 414);

            Text warningEmailText41 = new Text("Код неверный", font);
            warningEmailText41.CharacterSize = 20;
            warningEmailText41.FillColor = new Color(255, 255, 255);
            warningEmailText41.Position = new Vector2f(723, 613);
            
            
            Text warningPasswordText41 = new Text("Пароли не совпадают", font);
            warningPasswordText41 .CharacterSize = 20;
            warningPasswordText41 .FillColor = new Color(255, 255, 255);
            warningPasswordText41 .Position = new Vector2f(723, 796);
            
            Text passwordResetText41 = new Text("Сброс пароля", font);
            passwordResetText41.CharacterSize = 36;
            passwordResetText41.FillColor = new Color(68, 68, 69);
            passwordResetText41.Position = new Vector2f(916, 870);
            
           

            while (_window.IsOpen)
            {
               

                _window.DispatchEvents();
                _window.Closed += (sender, e) => _window.Close();
              


                _window.Draw(fonFrame41);

                _window.Draw(buttonEmptyEmailSprite41);
                _window.Draw(buttonEmptyNumberPfoneSprite41);
                _window.Draw(buttonEmptyEmailSprite41);


                _window.Draw(buttonResetPasswordSprite41);
                _window.Draw(buttonRequestСodeNumberPhoneSprite41);
                _window.Draw(buttonRequestСodeEmailSprite);
                _window.Draw(titleText41);
                
                _window.Draw(buttonEmptyRepeatPasswordSprite41);
                _window.Draw(buttonEmptyPasswordSprite41);
                
                _window.Draw(titlerequestСodeNumberPhoneTextMini41);
                _window.Draw(requestСodeNumberPhoneText41);


                _window.Draw(titlerequestСodeEmailTextMini41);

                _window.Draw(requestСodeEmailText41);

                _window.Draw(titleText41);
                _window.Draw(warningNumberPhoneText41);
                _window.Draw(warningEmailText41);
                _window.Draw(warningPasswordText41);
                _window.Draw(passwordResetText41);
                _window.Draw(passwordText41);
                _window.Draw(repeatPasswordText41);

                if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    Vector2i mousePos = Mouse.GetPosition(_window);
                    if (buttonResetPasswordSprite41.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
                    {
                        buttonRequestСodeEmailSprite.Texture = requestСodeTexture41;
                        buttonRequestСodeNumberPhoneSprite41.Texture = requestСodeTexture41;
                        buttonResetPasswordSprite41.Texture = buttonTextureOff41;
                           
                        warningNumberPhoneText41.FillColor = new Color(202, 128, 128);
                        warningEmailText41.FillColor = new Color(202, 128, 128);
                        warningPasswordText41.FillColor = new Color(202, 128, 128);
                       
                    }
                }
                
                if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    Vector2i mousePos = Mouse.GetPosition(_window);
                    if (buttonRequestСodeNumberPhoneSprite41.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
                    {

                        buttonRequestСodeNumberPhoneSprite41.Texture = requestСodeOffTexture41;
                       
                        
                       

                    }
                }

                if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    Vector2i mousePos = Mouse.GetPosition(_window);
                    if (buttonRequestСodeEmailSprite.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
                    {
                        buttonRequestСodeEmailSprite.Texture = requestСodeOffTexture41;
                        
                        

                    }
                }
                
                _window.Display();
               

            }
        }

}
    
