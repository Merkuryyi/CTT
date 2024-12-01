using SFML.Graphics;
using SFML.Window;
using SFML.System;
namespace CTT.Frame;
    public class Frame1
    {
        private static Button buttonLogin;
        private static Button backgroundFrame;
        private static Texts titleText; 
        private static Texts buttonText;
        private static bool canClick;
        private static Clock clock;
        private static Vector2i mousePosition;
        private static float clickDelay;
        private static InputLine line;
        private static FlagFrames flagFrames;
        public void Sructure1()
        {
            clock = new Clock();
            clickDelay = 0.3f;  
            line = new InputLine();
            Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
            Texture backgroundTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundFrame1.png"));
            Texture buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
            Color baseColorText = new Color(68, 68, 69);
            Color colorText = new Color(0, 0, 0);
            string titleTextFrame = "Зарегистрироваться";
            string buttonMiniText = "Войти";
            buttonLogin = new Button(858,571 , buttonTexture);
            backgroundFrame = new Button(53, 53, backgroundTexture);
            titleText = new Texts(685, 455, font, 64, baseColorText, titleTextFrame );
            buttonText = new Texts(929, 571, font, 48, colorText, buttonMiniText );
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
           mousePosition = Mouse.GetPosition(_window);
            clic();
            if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
            {
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

