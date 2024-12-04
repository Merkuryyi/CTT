namespace CTT.Frame;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Frame9
{
    
    private static Clock clock;
    private static float clickDelay;
    private Database database;
    private FlagFrames flagFrames;
    private Vector2i mousePosition;
    private Button backgroundLeft;
    private Button backgroundRight;
    private Button fartherLeft;
    private Button fartherRight;
    private Button ticketUpper;
    private Button ticketMiddle;
    private Button ticketLower;
    private Button ticketTravelUpper;
    private Button ticketTravelMiddle;
    private Button ticketTravelLower;
    private Texts titleTicketPensionText;
    private Texts decriptionTicketPensionText;
    private Texts warningPensionText;
    private Texts pricePensionTicketText;
    private Texts titleTicketSharedText;
    private Texts decriptionTicketSharedText;
    private Texts priceSharedTicketText;
    private Texts titleTicketBaggageText;
    private Texts decriptionTicketBaggageText;
    private Texts priceBaggageTicketText;
    private Texts titleTicketText;
    private Texts titleTravelTicketText;
    private Texts titleTicketCardPensionText;
    private Texts titleTicketCardPensionText2;
    private Texts warningPensionCardText;
    private Texts pricePensionTicketCardText;
    private Texts titleTicketCardSharedText;
    private Texts titleTicketCardSharedText2;
    private Texts priceSharedTicketCardText;
    private Texts titleTicketCardStudentText;
    private Texts titleTicketCardStudentText2;
    private Texts priceStudentTicketCardText;
    private Texts warningsStudentCardText;

    private static bool canClick;
    public void Display(RenderWindow _window)
    {
        backgroundLeft.Draw(_window);
        backgroundRight.Draw(_window);
        fartherLeft.Draw(_window);
        fartherRight.Draw(_window);
        ticketUpper.Draw(_window);
        ticketMiddle.Draw(_window);
        ticketLower.Draw(_window);
        ticketTravelUpper.Draw(_window);
        ticketTravelMiddle.Draw(_window);
        ticketTravelLower.Draw(_window);
        titleTicketPensionText.Draw(_window);
        decriptionTicketPensionText.Draw(_window);
        warningPensionText.Draw(_window);
        pricePensionTicketText.Draw(_window);
        titleTicketSharedText.Draw(_window);
        decriptionTicketSharedText.Draw(_window);
        priceSharedTicketText.Draw(_window);
        titleTicketBaggageText.Draw(_window);
        decriptionTicketBaggageText.Draw(_window);
        priceBaggageTicketText.Draw(_window);
        titleTicketText.Draw(_window);
        titleTravelTicketText.Draw(_window);
        
        titleTicketCardPensionText.Draw(_window);
        titleTicketCardPensionText2.Draw(_window);
        warningPensionCardText.Draw(_window);
        pricePensionTicketCardText.Draw(_window);
        titleTicketCardSharedText.Draw(_window);
        titleTicketCardSharedText2.Draw(_window);
        priceSharedTicketCardText.Draw(_window);
        titleTicketCardStudentText.Draw(_window);
        titleTicketCardStudentText2.Draw(_window);
        priceStudentTicketCardText.Draw(_window);
        warningsStudentCardText.Draw(_window);
    }

    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;   
        database = new Database();
        flagFrames = new FlagFrames();
        Texture backgroundLeftTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundLeftWithTop.png"));
        Texture backgroundRightTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundRightWithTop.png"));
        Texture backgroundTicketsTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgrondTicket.png"));
        Texture fartherIcon =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fartherIcon.png"));
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        backgroundLeft = new Button(53, 170, backgroundLeftTexture);
        backgroundRight = new Button(994, 170, backgroundRightTexture);
        fartherLeft = new Button(877, 231, fartherIcon);
        fartherRight = new Button(1790, 231, fartherIcon);
        ticketUpper = new Button(97, 316, backgroundTicketsTexture);
        ticketMiddle = new Button(97, 542, backgroundTicketsTexture);
        ticketLower = new Button(97, 767, backgroundTicketsTexture);
        
        ticketTravelUpper = new Button(1038, 316, backgroundTicketsTexture);
        ticketTravelMiddle = new Button(1038, 542, backgroundTicketsTexture);
        ticketTravelLower = new Button(1038, 767, backgroundTicketsTexture);
        
        Color baseColorText = new Color(68, 68, 69);
        Color warningTextColor = new Color(202, 128, 128);

        string titleTicket = "Каталог разовых билетов";
        titleTicketText = new Texts(96, 227, font, 36, baseColorText, titleTicket);
        string titleTravelTicket = "Каталог проездных билетов";
        titleTravelTicketText = new Texts(1038, 227, font, 36, baseColorText, titleTravelTicket);
        
        string titleTicketShared = "Общий билет";
        string descriptionTicketShared = database.ticketDecriptionGet(titleTicketShared);
        string priceSharedTicket = database.ticketPriceGet(titleTicketShared);
        titleTicketSharedText = new Texts(282, 343, font, 36, baseColorText, titleTicketShared);
        decriptionTicketSharedText = new Texts(286, 398, font, 20, baseColorText, descriptionTicketShared);
        priceSharedTicketText = new Texts(135, 432, font, 24, baseColorText, priceSharedTicket);
        
        string titleTicketPension = "Пенсионный билет";
        string descriptionTicketPension = database.ticketDecriptionGet(titleTicketPension);
        string warning = "*Необходим документ";
        string pricePensionTicket = database.ticketPriceGet(titleTicketPension);
        titleTicketPensionText = new Texts(282, 569, font, 36, baseColorText, titleTicketPension);
        decriptionTicketPensionText = new Texts(286, 624, font, 20, baseColorText, descriptionTicketPension);
        warningPensionText = new Texts(111, 722, font, 20, warningTextColor, warning);
        pricePensionTicketText = new Texts(135, 659, font, 24, baseColorText, pricePensionTicket);
        
        string titleTicketBaggage = "Багажный билет";
        string descriptionTicketBaggage = database.ticketDecriptionGet(titleTicketBaggage);
        string priceBaggageTicket = database.ticketPriceGet(titleTicketBaggage);
        titleTicketBaggageText = new Texts(282, 794, font, 36, baseColorText, titleTicketBaggage);
        decriptionTicketBaggageText = new Texts(286, 849, font, 20, baseColorText, descriptionTicketBaggage);
        priceBaggageTicketText = new Texts(135, 884, font, 24, baseColorText, priceBaggageTicket);
        
        string titleTicketCard2 = "проездной билет";
        
        string titleTicketCardShared = "Общий";
        string priceSharedTicketCard = database.ticketCardPriceGet(titleTicketCardShared);
        titleTicketCardSharedText = new Texts(1235, 343, font, 36, baseColorText, titleTicketCardShared);
        titleTicketCardSharedText2 = new Texts(1235, 387, font, 36, baseColorText, titleTicketCard2);
        priceSharedTicketCardText = new Texts(1080, 432, font, 24, baseColorText, priceSharedTicketCard);
        
     
        
        
        
        
        string titleTicketCardStudent = "Студенческий";
        string priceStudentTicketCard = database.ticketCardPriceGet(titleTicketCardStudent);
        titleTicketCardStudentText = new Texts(1235, 569, font, 36, baseColorText, titleTicketCardStudent);
        titleTicketCardStudentText2 = new Texts(1235, 613, font, 36, baseColorText, titleTicketCard2);
        priceStudentTicketCardText = new Texts(1080, 659, font, 24, baseColorText, priceStudentTicketCard);
        warningsStudentCardText = new Texts(1070, 722, font, 20, warningTextColor, warning);
           
        string titleTicketCardPension = "Пенсионный";
     
        
        
        string pricePensionTicketCard = database.ticketCardPriceGet(titleTicketCardPension);
        titleTicketCardPensionText = new Texts(1235, 794, font, 36, baseColorText, titleTicketCardPension);
        titleTicketCardPensionText2 = new Texts(1235, 838, font, 36, baseColorText, titleTicketCard2);
        warningPensionCardText = new Texts(1070, 947, font, 20, warningTextColor, warning);
        pricePensionTicketCardText = new Texts(1080, 884, font, 24, baseColorText, pricePensionTicketCard);
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