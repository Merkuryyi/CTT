namespace CTT;
using SFML.System;

public class DelayClic
{
    public static bool canClick = true;
    public static Clock clock;
    public static float clickDelay = 0.5f;
    public void clicTime()
    {
        clock = new Clock();
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
            canClick = true;
        }
    }
    
}