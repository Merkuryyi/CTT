namespace CTT;
using SFML.System;

public static class DelayClic
{
    private static Clock clock = new Clock();
 
    private static float clickDelay = 0.5f;

    private static Clock clockR = new Clock();
    private static bool canClickR = true;
    private static float clickDelayR = 0.080f;
    
    public static bool clic(bool canClick)
    {
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
            clock.Restart();
            return false;
        }

        
        return true;
    }
    public static bool clicRestoreAcess()
    {
        if (!canClickR && clockR.ElapsedTime.AsSeconds() >= clickDelayR)
        {
            canClickR = true;
        }

        if (canClickR)
        {
            canClickR = false;
            clockR.Restart();
            return true;
        }

        return false;
    }
}