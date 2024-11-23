using CTT;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Profile
{
    private static InputLine line;
    public void Display(RenderWindow _window)
    {
        
    }

    public void Structure()
    {
        
    }

    public static void Warning(RenderWindow _window)
    {

    }

    public static void ButtonInteraction(RenderWindow _window)
    {
        
    }
    public void Ivents(RenderWindow _window)
    {
        
        _window.DispatchEvents();
        _window.Closed += (sender, e) => _window.Close();
        _window.KeyPressed += line.OnKeyPressedName;
        
    }
    public void workProgram(RenderWindow _window)
    {
        
        
        while (_window.IsOpen)
        {
            Ivents(_window);
            Display(_window);
            ButtonInteraction(_window);
            
            
            _window.Display();

        }


    }
    

}