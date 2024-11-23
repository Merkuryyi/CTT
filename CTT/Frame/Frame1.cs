
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using CTT;

    public class Frame1
    {
        private static Button buttonLogin;
        private static Button backgroundFrame;
        private static Texts titleText; 
        private static Texts buttonText;
            
        public void Sructure1()
        {
            Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
            
            Texture backgroundTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundFrame1.png"));
            Texture buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
            
            Color baseColorText = new Color(68, 68, 69);
            Color colorText = new Color(0, 0, 0);

            string titleTextFrame = "Зарегистрироваться";
            string buttonMiniText = "Войти";
            
            int xPositionButtonLogin = 858;
            int yPositionButtonLogin = 571;
            int xyPositionBackground = 53;
            int yPositionTitleText = 455;
            int xPositionTitleText = 685;
            int xPositionButtonText = 929;
            
            uint sizeTextMax = 64;
            uint sizeTextMiniTitle = 48;
            
            buttonLogin = new Button(xPositionButtonLogin,yPositionButtonLogin , buttonTexture);
            backgroundFrame = new Button(xyPositionBackground, xyPositionBackground, backgroundTexture);
            titleText = new Texts(xPositionTitleText, yPositionTitleText, font, sizeTextMax, baseColorText, titleTextFrame );
            buttonText = new Texts(xPositionButtonText, yPositionButtonLogin, font, sizeTextMiniTitle, colorText, buttonMiniText );
        }

        public void IventsWindow1(RenderWindow _window)
        {
            _window.DispatchEvents();
            _window.Closed += (sender, e) => _window.Close();
         
        }
        public void Display1(RenderWindow _window)
        {
            _window.Clear(new Color(230, 230, 230));
            backgroundFrame.Draw(_window); 
            buttonLogin.Draw(_window); 
            titleText.Draw(_window); 
            buttonText.Draw(_window); 
            
        }

        public void workProgram(RenderWindow _window)
        {
             
             InputLine line = new InputLine();
             while (_window.IsOpen)
            {
                IventsWindow1(_window);
                Display1(_window);
                
                if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    Vector2i mousePosition = Mouse.GetPosition(_window);
                    if (titleText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                    {
                        _window.Clear(Color.White);
                        Frame2 frame2 = new Frame2();
                        frame2.workProgram(_window);
                        line.clearLine();
                        
                        
                    }
                    if (buttonLogin.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                    {
                       _window.Clear(Color.White);
                        Frame4 frame4 = new Frame4();
                        frame4.workProgram(_window);
                        line.clearLine();
                    }
                }
                _window.Display();
               
            }
        }
    }

