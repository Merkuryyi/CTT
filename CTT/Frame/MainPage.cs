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
   
    private Texts priceTicketUpper;
    private Texts priceTicketMiddle;
    private Texts priceTicketLower;
    private Texts timeTicketUpper;
    private Texts timeTicketMiddle;
    private Texts timeTicketLower;
    private Texts dateTicketUpper;
    private Texts dateTicketMiddle;
    private Texts dateTicketLower;
    private Texts titleTicketPay;
    private Texts titleNews;
    private Button fartherNews;
    private Button backgroundNews;
    private Texts titleNoTickets;
    private Texts titleNoTravelTickets;
    private Texts titleTavelTicketsPay;
    private Button backgroundTravelTicket;
    private Button plusTravelTicket;
    private Button travelTicket;
    private Texts titleTavelTickets;
    private Texts title2TavelTickets;
    private Texts priceTravelTickets;
    private Texts warningTravelTickets;
    private Texts monthTravelTickets;
    private Texts expirationDateTravelTickets;
    private Button backgroundCards;
    private Button card;
    private Button fartherMiniIcon;
    private Texts titleCard;
    private Texts upBalance;
    private Texts date;
    private Texts title1Cards;
    private Texts title2Cards;
    private Texts title3Cards;
    private Texts balance;
    private Texts cardInformation;

    private static bool canClick;
    private static bool ticketUpperFlag = false;
    private static bool ticketMiddleFlag = false;
    private static bool ticketLowerFlag = false;
    private static bool ticketNo = false;
    private static bool travelTicketNo = false;
    public void Display(RenderWindow _window)
    {
        backgroundRight.Draw(_window);
        backgroundTravelTicket.Draw(_window);
        
        titleTicketPay.Draw(_window);
        plusTicket.Draw(_window);
        plusTravelTicket.Draw(_window);
        travelTicket.Draw(_window);
        backgroundCards.Draw(_window);
        card.Draw(_window);
        fartherMiniIcon.Draw(_window);
        titleCard.Draw(_window);
        upBalance.Draw(_window);
        date.Draw(_window);
        title1Cards.Draw(_window);
        title2Cards.Draw(_window);
        title3Cards.Draw(_window);
        balance.Draw(_window);
        cardInformation.Draw(_window);
        if (ticketUpperFlag)
        {
            ticketUpper.Draw(_window);
            titleTicketUpper.Draw(_window);
            decriptionTicketUpper.Draw(_window);
           
            priceTicketUpper.Draw(_window);
            timeTicketUpper.Draw(_window);
            dateTicketUpper.Draw(_window);
        }
        if (ticketMiddleFlag)
        {
            ticketMiddle.Draw(_window);
            titleTicketMiddle.Draw(_window);
            decriptionTicketMiddle.Draw(_window);
         
            priceTicketMiddle.Draw(_window);
            timeTicketMiddle.Draw(_window);
            dateTicketMiddle.Draw(_window);
        }

        if (ticketLowerFlag)
        { 
            ticketLower.Draw(_window);
            titleTicketLower.Draw(_window);
            decriptionTicketLower.Draw(_window); 
            timeTicketLower.Draw(_window);
            dateTicketLower.Draw(_window);
            priceTicketLower.Draw(_window);
           
        }

        if (travelTicketNo)
        {
            titleNoTravelTickets.Draw(_window);
        }
        else
        {
            titleTavelTickets.Draw(_window);
            title2TavelTickets.Draw(_window);
            priceTravelTickets.Draw(_window);
            warningTravelTickets.Draw(_window);
            monthTravelTickets.Draw(_window);
            expirationDateTravelTickets.Draw(_window);
        }
        if (ticketNo)
        {
            titleNoTickets.Draw(_window);
        }
       
        
        
        backgroundNews.Draw(_window);   
        titleNews.Draw(_window);
        fartherNews.Draw(_window);
       
        titleTavelTicketsPay.Draw(_window);
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
        Texture fartherMini =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fartherMini.png"));
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
        
        int id = database.GetUserId(WorkWithJson.ReadPhoneNumberFromFile(), WorkWithJson.ReadEmailFromFile());
        backgroundRight = new Button(994, 170, backgroundRightTexture);
        backgroundNews = new Button(53, 842, backgroundNewsMainPage);
        backgroundTravelTicket = new Button(53, 490, backgroundTravelTicketMainPage);
        backgroundCards = new Button(53, 170, backgroundCard);
        
        card = new Button(108, 255, cardIcon);
        fartherMiniIcon = new Button(413, 396, fartherMini);
        
        ticketUpper = new Button(1055, 309, backgroundTicketsTexture);
        ticketMiddle = new Button(1055, 535, backgroundTicketsTexture);
        ticketLower = new Button(1055, 760, backgroundTicketsTexture);
        
        travelTicket = new Button(97, 590, backgroundTicketsTexture);
        
        plusTicket = new Button(1785, 208, plus);
        plusTravelTicket = new Button(884, 524, plus);
        fartherNews = new Button(893, 905, fartherIcon);
        
        
        benefitsShared = "Общий";
        benefitsPension = "Пенсионный";
        benefitsStudent = "Студенческий";
        Color warningTextColor = new Color(202, 128, 128);
        Color colorMessage = new Color(136, 136, 136);
        Color baseColorText = new Color(68, 68, 69);
        priceShare = database.ticketCardPriceGet(benefitsShared);
        priceStudent = database.ticketCardPriceGet(benefitsStudent);
        pricePension = database.ticketCardPriceGet(benefitsPension);
       
        titleTicketPay = new Texts(1055, 221, font, 36, baseColorText, "Купить билет");
        string nameTicketUpper = database.GetTicketName(id, "upper");
        if (!string.IsNullOrEmpty(nameTicketUpper))
        { ticketUpperFlag = true; }
        string nameTicketMiddle = database.GetTicketName(id, "middle");
        Console.WriteLine(nameTicketMiddle);
        
        if (!string.IsNullOrEmpty(nameTicketMiddle))
        { ticketMiddleFlag = true; }
        string nameTicketLower = database.GetTicketName(id, "lower");
        Console.WriteLine(nameTicketLower);
        if (!string.IsNullOrEmpty(nameTicketLower))
        { ticketLowerFlag = true; }
        titleTicketUpper = new Texts(1240, 336, font, 36, baseColorText, nameTicketUpper);
        titleTicketMiddle = new Texts(1240, 562, font, 36, baseColorText, nameTicketMiddle);
        titleTicketLower = new Texts(1240, 787, font, 36, baseColorText, nameTicketLower);

        decriptionTicketUpper = new Texts(1244, 391, font, 20, baseColorText, database.ticketDecriptionGet(nameTicketUpper));
        decriptionTicketMiddle = new Texts(1244, 617, font, 20, baseColorText, database.ticketDecriptionGet(nameTicketMiddle));
        decriptionTicketLower = new Texts(1244, 842, font, 20, baseColorText, database.ticketDecriptionGet(nameTicketLower));
        
        priceTicketUpper = new Texts(1080, 426, font, 24, baseColorText, database.ticketPriceGet(nameTicketUpper));
        priceTicketMiddle = new Texts(1080, 652, font, 24, baseColorText, database.ticketPriceGet(nameTicketMiddle));
        priceTicketLower = new Texts(1080, 877, font, 24, baseColorText, database.ticketPriceGet(nameTicketLower));
        
        timeTicketUpper = new Texts(1703, 325, font, 36, baseColorText, database.GetDateTicket(id, "time", "upper"));
        timeTicketMiddle = new Texts(1703, 551, font, 36, baseColorText, database.GetDateTicket(id, "time", "middle"));
        timeTicketLower = new Texts(1703, 776, font, 36, baseColorText, database.GetDateTicket(id, "time", "lower"));
        
        dateTicketUpper = new Texts(1711, 382, font, 24, baseColorText, database.GetDateTicket(id, "date", "upper"));
        dateTicketMiddle = new Texts(1711, 608, font, 24, baseColorText, database.GetDateTicket(id, "date", "middle"));
        dateTicketLower = new Texts(1711, 833, font, 24, baseColorText, database.GetDateTicket(id, "date", "lower"));
        
        titleNews = new Texts(97, 899, font, 36, baseColorText, "Транспортные новости");
        string ticketNo = "Билеты не найдены";
        string ticketTavelNo = "Проездные билеты не найдены";
        titleNoTickets = new Texts(1289, 526, font, 36, colorMessage, ticketNo);
        titleNoTravelTickets = new Texts(270, 634, font, 36, colorMessage, ticketTavelNo);
        
        titleTavelTicketsPay = new Texts(97, 524, font, 36, baseColorText, "Купить проездной");
        titleCard = new Texts(108, 189, font, 36, baseColorText, "Карты");
        titleTavelTickets = new Texts(294, 620, font, 36, baseColorText, "");
        title2TavelTickets = new Texts(294, 661, font, 36, baseColorText, "проездной билет");
        
        priceTravelTickets = new Texts(139, 697, font, 24, baseColorText, "1");
        monthTravelTickets = new Texts(747, 629, font, 36, baseColorText, "s");
        expirationDateTravelTickets = new Texts(757, 688, font, 20, baseColorText, "s");
        warningTravelTickets = new Texts(130, 768, font, 20, warningTextColor, "*необходим документ");
        upBalance = new Texts(108, 396, font, 20, baseColorText, "Пополнить баланс");
        DateTime today = DateTime.Today;
        date = new Texts(326, 202, font, 20, baseColorText,  today.ToString("dd.MM.yyyy"));
        
        title1Cards = new Texts(604, 248, font, 36, colorMessage, "Здесь будут");
        title2Cards = new Texts(507, 290, font, 36, colorMessage, "появляться все ваши");
        title3Cards = new Texts(582, 334, font, 36, colorMessage, "карты и счета");
        float balanceCard = database.GetUserBalance(id);
        balance = new Texts(256, 283, font, 36, baseColorText, balanceCard.ToString());
        cardInformation = new Texts(256, 329, font, 16, baseColorText, "standart " + database.GetCardId(id));
    }
/*
 
int id = database.GetUserId(WorkWithJson.ReadPhoneNumberFromFile(), WorkWithJson.ReadEmailFromFile());
        titleTicketUpper.SetText(database.GetLatestTicketName(id));
       if (database.GetLatestTicketName(id) != "")
       {
       }
        
        
        
        
*/
    private void ButtonInteraction(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
            if (plusTicket.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagFrames.ChangeFlagsFrame();
                MainForm.topPanel = true;
                MainForm.frame6 = true;
            }
            if (plusTravelTicket.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagFrames.ChangeFlagsFrame();
                MainForm.topPanel = true;
                MainForm.frame7 = true;
            }
            if (fartherNews.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagFrames.ChangeFlagsFrame();
                MainForm.topPanel = true;
                MainForm.frame8 = true;
            }

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