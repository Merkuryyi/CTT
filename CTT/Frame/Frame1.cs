
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
        private static  bool canClick = false;
        private static Clock clock;
        private static float clickDelay;
        public void Sructure1()
        {
            clock = new Clock();
            clickDelay = 0.3f;  
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

     
        public void Display(RenderWindow _window)
        {
            _window.Clear(new Color(230, 230, 230));
            backgroundFrame.Draw(_window); 
            buttonLogin.Draw(_window); 
            titleText.Draw(_window); 
            buttonText.Draw(_window); 
            
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
            InputLine line = new InputLine();
            FlagFrames flagFrames = new FlagFrames();
            clic();
            if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (titleText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    _window.Clear(Color.White);
                
                    line.clearLine();
                    flagFrames.ChangeFlagsFrame();
                    MainForm.frame2 = true;


                }
                if (buttonLogin.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    _window.Clear(Color.White);
             
                    line.clearLine();
                    MainForm.frame4 = true;
                }
            }
        }

        public void workProgram(RenderWindow _window)
        {
             
                Display(_window);
                ButtonInteraction(_window);
            
               
            
        }
    }

