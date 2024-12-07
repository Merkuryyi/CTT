namespace CTT.Frame;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class MainPage
{
    
    private static Clock clock;
    private static float clickDelay;
    private Database database;
    private FlagFrames flagFrames;
    private Vector2i mousePosition;
    private Button backgroundRight;
    private Button ticketUpper;
    private Button ticketMiddle;
    private Button ticketLower;
    private string benefitsShared;
    private string benefitsPension;
    private string benefitsStudent;
    private string priceShare;
    private string priceStudent;
    private string pricePension;
    private Texts titleTicketUpper;
    private Texts titleTicketMiddle;
    private Texts titleTicketLower;
    private Button plusTicket;
    private Texts decriptionTicketUpper;
    private Texts decriptionTicketLower;
    private Texts decriptionTicketMiddle;
    private Texts warningTextUpper;
    private Texts warningTextLower;
    private Texts warningTextMiddle;
    private Texts priceTicketUpper;
    private Texts priceTicketMiddle;
    private Texts priceTicketLower;
    private Texts timeTicketUpper;
    private Texts timeTicketMiddle;
    private Texts timeTicketLower;
    private Texts dateTicketUpper;
    private Texts dateTicketMiddle;
    private Texts dateTicketLower;

    private static bool canClick;
    private static bool ticketUpperFlag = false;
    private static bool ticketMiddleFlag = false;
    private static bool ticketLowerFlag = false;
    public void Display(RenderWindow _window)
    {
        backgroundRight.Draw(_window);;
        ticketUpper.Draw(_window);;
        ticketMiddle.Draw(_window);;
        ticketLower.Draw(_window);;

        titleTicketUpper.Draw(_window);;
        titleTicketMiddle.Draw(_window);;
        titleTicketLower.Draw(_window);;
        plusTicket.Draw(_window);;
        decriptionTicketUpper.Draw(_window);;
        decriptionTicketLower.Draw(_window);;
        decriptionTicketMiddle.Draw(_window);;
        warningTextUpper.Draw(_window);;
        warningTextLower.Draw(_window);;
        warningTextMiddle.Draw(_window);;
        priceTicketUpper.Draw(_window);;
        priceTicketMiddle.Draw(_window);;
        priceTicketLower.Draw(_window);;
        timeTicketUpper.Draw(_window);;
        timeTicketMiddle.Draw(_window);;
        timeTicketLower.Draw(_window);;
        dateTicketUpper.Draw(_window);;
        dateTicketMiddle.Draw(_window);;
        dateTicketLower.Draw(_window);;
    }

    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;   
        database = new Database();
        flagFrames = new FlagFrames();
        Texture backgroundCard =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundCards.png"));
        Texture cardIcon =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "cardsIcon.png"));
        Texture farherMini =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "cardsIcon.png"));
        Texture backgroundTravelTicketMainPage =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundTravelTicketMainPage.png"));
        Texture backgroundTicketsTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundTicket.png"));
        Texture backgroundNewsMainPage =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundNewsMainPage.png"));
        Texture fartherIcon =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fartherIcon.png"));
        Texture backgroundRightTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundRightWithTop.png"));
        Texture plus =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "plus.png"));
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        
        backgroundRight = new Button(994, 170, backgroundRightTexture);
        ticketUpper = new Button(1055, 309, backgroundTicketsTexture);
        ticketMiddle = new Button(1055, 535, backgroundTicketsTexture);
        ticketLower = new Button(1055, 760, backgroundTicketsTexture);
        plusTicket = new Button(1777, 208, plus);
        
        benefitsShared = "Общий";
        benefitsPension = "Пенсионный";
        benefitsStudent = "Студенческий";
        Color warningTextColor = new Color(202, 128, 128);
        Color colorMessage = new Color(136, 136, 136);
        Color baseColorText = new Color(68, 68, 69);
        priceShare = database.ticketCardPriceGet(benefitsShared);
        priceStudent = database.ticketCardPriceGet(benefitsStudent);
        pricePension = database.ticketCardPriceGet(benefitsPension);
        
        titleTicketUpper = new Texts(1240, 336, font, 36, baseColorText, "");
        titleTicketMiddle = new Texts(1240, 562, font, 36, baseColorText, "");
        titleTicketLower = new Texts(1240, 787, font, 36, baseColorText, "");
        
        decriptionTicketUpper = new Texts(1244, 391, font, 20, baseColorText, "");
        decriptionTicketMiddle = new Texts(1244, 617, font, 20, baseColorText, "");
        decriptionTicketLower = new Texts(1244, 842, font, 20, baseColorText, "");

        warningTextUpper = new Texts(1069, 449, font, 20, warningTextColor, "");
        warningTextMiddle = new Texts(1069, 715, font, 20, warningTextColor, "");
        warningTextLower = new Texts(1069, 940, font, 20, warningTextColor, "");
        
        priceTicketUpper = new Texts(1080, 426, font, 24, baseColorText, "");
        priceTicketMiddle = new Texts(1080, 652, font, 24, baseColorText, "");
        priceTicketLower = new Texts(1080, 877, font, 24, baseColorText, "");
        
        timeTicketUpper = new Texts(1703, 325, font, 36, baseColorText, "");
        timeTicketMiddle = new Texts(1703, 551, font, 36, baseColorText, "");
        timeTicketLower = new Texts(1703, 776, font, 36, baseColorText, "");
        
        dateTicketUpper = new Texts(1711, 382, font, 24, baseColorText, "");
        dateTicketMiddle = new Texts(1711, 608, font, 24, baseColorText, "");
        dateTicketLower = new Texts(1711, 833, font, 24, baseColorText, "");
        
        
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