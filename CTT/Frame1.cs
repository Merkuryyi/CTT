using CTT;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Frame1
{

    private static Font font;
    private static Texture backgroundTexture;
    private static Texture buttonTexture;
   
   
   // private static Text titleText;

    private static Button buttonLogin;
    private static Button backgroundFrame;
        
        
    public void Sructure1()
    {
        font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        backgroundTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fonFrame1.png"));
        buttonTexture = new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "button.png"));
        
        Color baseColor = new Color(68, 68, 69);
       // Text buttonText = new Text("Войти", font);
       // Text nullText = new Text("", font);
        
       
                  
       

       // titleText = new Text("Зарегистрироваться", font);
       // titleText.CharacterSize = 64;
       // titleText.FillColor = new Color(68, 68, 69);
       // titleText.Position = new Vector2f(685, 455);

        
       // buttonText.CharacterSize = 48;
       // buttonText.FillColor = new Color(0, 0, 0);
       // buttonText.Position = new Vector2f(945, 571);
        
        
        
        
        buttonLogin = new Button(858, 571, buttonTexture);
        
       backgroundFrame = new Button(53, 53, backgroundTexture);

        
        
        
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
       
      // _window.Draw(titleText); 
       
        _window.Display();
    }

    public void Run1(RenderWindow _window)
    {
       Sructure1();
      
      
       

        while (_window.IsOpen)
        {
            IventsWindow1(_window);
            Display1(_window);
            
            
            if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                Vector2i mousePos = Mouse.GetPosition(_window);
                if (titleText.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
                {
                    _window.Clear(Color.White);
                    Frame2 frame2 = new Frame2();
                    frame2.Run2(_window);
                   
                   
                }
            }
            
            if (Mouse.IsButtonPressed(Mouse.Button.Left) )
            {
                Vector2i mousePosition = Mouse.GetPosition(_window);
                if (buttonLogin.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    _window.Clear(Color.White);
                    Frame4 frame4 = new Frame4();
                    frame4.Run4(_window);
                    
                }
            }
            
            
            
            

        }
        
        
        

    }

   
    
     
    
       
    
}