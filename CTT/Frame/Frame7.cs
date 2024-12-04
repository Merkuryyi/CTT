namespace CTT.Frame;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Frame7
{
    
    private static Clock clock;
    private static float clickDelay;
    private Database database;
    private FlagFrames flagFrames;
    private Vector2i mousePosition;
    
    private static bool canClick;
    public void Display(RenderWindow _window)
    {
       
    }

    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;   
        database = new Database();
        flagFrames = new FlagFrames();
        
    }

    private void ButtonInteraction(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
           
           
            
            clock.Restart();
            canClick = false;
        }

        clic();
    }
    public void workProgram(RenderWindow _window)
    {
        Display(_window);
        ButtonInteraction(_window);
    }
    public void clic()
    {
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
            canClick = true;
        }
    }
    
}