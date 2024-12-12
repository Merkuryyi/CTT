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
    private string benefitsShared;
    private string benefitsPension;
    private string benefitsStudent;
    private static bool canClick;
    private static bool ticketUpperFlag;
    private static bool ticketMiddleFlag;
    private static bool ticketLowerFlag;
    private static bool travelTickets;
    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;   
        database = new Database();
        flagFrames = new FlagFrames();
        Texture backgroundCard =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundCards.png"));
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
        backgroundNews = new Button(53, 842, backgroundNewsMainPage);
        backgroundTravelTicket = new Button(53, 490, backgroundTravelTicketMainPage);
        backgroundCards = new Button(53, 170, backgroundCard);
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
        titleTicketPay = new Texts(1055, 221, font, 36, baseColorText, "Купить билет");
        titleTicketUpper = new Texts(1240, 336, font, 36, baseColorText, "");
        titleTicketMiddle = new Texts(1240, 562, font, 36, baseColorText, "");
        titleTicketLower = new Texts(1240, 787, font, 36, baseColorText, "");
        decriptionTicketUpper = new Texts(1244, 391, font, 20, baseColorText, "");
        decriptionTicketMiddle = new Texts(1244, 617, font, 20, baseColorText, "");
        decriptionTicketLower = new Texts(1244, 842, font, 20, baseColorText, "");
        priceTicketUpper = new Texts(1080, 426, font, 24, baseColorText, "");
        priceTicketMiddle = new Texts(1080, 652, font, 24, baseColorText, "");
        priceTicketLower = new Texts(1080, 877, font, 24, baseColorText, "");
        timeTicketUpper = new Texts(1703, 325, font, 36, baseColorText, "");
        timeTicketMiddle = new Texts(1703, 551, font, 36, baseColorText, "");
        timeTicketLower = new Texts(1703, 776, font, 36, baseColorText, "");
        dateTicketUpper = new Texts(1711, 382, font, 24, baseColorText, "");
        dateTicketMiddle = new Texts(1711, 608, font, 24, baseColorText, "");
        dateTicketLower = new Texts(1711, 833, font, 24, baseColorText, "");
        titleNews = new Texts(97, 899, font, 36, baseColorText, "Транспортные новости");
        string ticketNo = "Билеты не найдены";
        string ticketTavelNo = "Проездные билеты не найдены";
        titleNoTickets = new Texts(1289, 526, font, 36, colorMessage, ticketNo);
        titleNoTravelTickets = new Texts(270, 634, font, 36, colorMessage, ticketTavelNo);
        titleTavelTicketsPay = new Texts(97, 524, font, 36, baseColorText, "Купить проездной");
        titleCard = new Texts(108, 189, font, 36, baseColorText, "Карты");
        titleTavelTickets = new Texts(294, 620, font, 36, baseColorText, "");
        title2TavelTickets = new Texts(294, 661, font, 36, baseColorText, "проездной билет");
        priceTravelTickets = new Texts(139, 697, font, 24, baseColorText, "" );
        monthTravelTickets = new Texts(747, 629, font, 36, baseColorText, "");
        expirationDateTravelTickets = new Texts(757, 688, font, 24, baseColorText, "");
        warningTravelTickets = new Texts(130, 768, font, 20, warningTextColor, "");
        DateTime today = DateTime.Today;
        date = new Texts(326, 202, font, 20, baseColorText,  today.ToString("dd.MM.yyyy"));
        title1Cards = new Texts(108, 269, font, 36, colorMessage, "В будущем здесь будут ");
        title2Cards = new Texts(108, 311, font, 36, colorMessage, "появляться все ваши");
        title3Cards = new Texts(108, 355, font, 36, colorMessage, "карты и счета");
        UpdateTickets();
    }
    public string expirationDateTickets(string month)
    {
        string[] months = {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
            "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
        };
        int currentMonthIndex = Array.FindIndex(months, m => m.Equals(month, StringComparison.OrdinalIgnoreCase));
        int nextMonthIndex = (currentMonthIndex + 1) % 12;
        return $"до 01.{nextMonthIndex + 1:D2}";
    }
    public void UpdateTickets()
    {
        int id = database.GetUserId(WorkWithJson.ReadPhoneNumberFromFile(), WorkWithJson.ReadEmailFromFile());
        string titleTavelTicket = database.TravelTicketTitleGet(id);
        string priceTravelTicket = "";
        if (!string.IsNullOrEmpty(titleTavelTicket))
        {
            travelTickets = true;
            priceTravelTicket = database.TicketCardPriceGet(titleTavelTicket);
        }
        string month = database.GetDateTravelTicket(id);
        monthTravelTickets.SetText(month);
        titleTavelTickets.SetText(titleTavelTicket);
        if (titleTavelTickets.IfTexts("Пенсионный") || titleTavelTickets.IfTexts("Студенческий"))
        { warningTravelTickets.SetText("*необходим документ"); }
        else
        { warningTravelTickets.SetText(""); }
        priceTravelTickets.SetText(priceTravelTicket);
        timeTicketUpper.SetText(database.GetDateTicket(id, "time", "upper"));
        timeTicketMiddle.SetText(database.GetDateTicket(id, "time", "middle"));
        timeTicketLower.SetText(database.GetDateTicket(id, "time", "lower"));
        dateTicketUpper.SetText(database.GetDateTicket(id, "date", "upper"));
        dateTicketMiddle.SetText(database.GetDateTicket(id, "date", "middle"));
        dateTicketLower .SetText(database.GetDateTicket(id, "date", "lower"));    
        expirationDateTravelTickets.SetText(expirationDateTickets(month));
        string nameTicketUpper = database.GetTicketName(id, "upper");
        if (!string.IsNullOrEmpty(nameTicketUpper))
        { ticketUpperFlag = true; }
        string nameTicketMiddle = database.GetTicketName(id, "middle");
        if (!string.IsNullOrEmpty(nameTicketMiddle))
        { ticketMiddleFlag = true; }
        string nameTicketLower = database.GetTicketName(id, "lower");
        if (!string.IsNullOrEmpty(nameTicketLower))
        { ticketLowerFlag = true; }
        titleTicketUpper.SetText(nameTicketUpper);
        titleTicketMiddle.SetText(nameTicketMiddle);
        titleTicketLower.SetText(nameTicketLower);
        decriptionTicketUpper.SetText(database.TicketDecriptionGet(nameTicketUpper));
        decriptionTicketMiddle.SetText(database.TicketDecriptionGet(nameTicketMiddle));
        decriptionTicketLower.SetText(database.TicketDecriptionGet(nameTicketLower));
        priceTicketUpper.SetText(database.TicketPriceGet(nameTicketUpper));
        priceTicketMiddle.SetText(database.TicketPriceGet(nameTicketMiddle));
        priceTicketLower.SetText(database.TicketPriceGet(nameTicketLower));
    }
    private void ButtonInteraction(RenderWindow _window)
    {
        clic();
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
    }
    public void workProgram(RenderWindow _window)
    {
        Display(_window);
        ButtonInteraction(_window);
    }
    public void clic()
    {
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        { canClick = true; }
    }
     public void Display(RenderWindow _window)
    {
        backgroundRight.Draw(_window);
        backgroundTravelTicket.Draw(_window);
        titleTicketPay.Draw(_window);
        plusTicket.Draw(_window);
        plusTravelTicket.Draw(_window);
        backgroundCards.Draw(_window);
        titleCard.Draw(_window);
        date.Draw(_window);
        title1Cards.Draw(_window);
        title2Cards.Draw(_window);
        title3Cards.Draw(_window);
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
        if (!travelTickets)
        { titleNoTravelTickets.Draw(_window);
        }
        else
        {
            travelTicket.Draw(_window);
            titleTavelTickets.Draw(_window);
            title2TavelTickets.Draw(_window);
            priceTravelTickets.Draw(_window);
            warningTravelTickets.Draw(_window);
            monthTravelTickets.Draw(_window);
            expirationDateTravelTickets.Draw(_window);
        }
        if (!ticketUpperFlag && !ticketMiddleFlag && !ticketLowerFlag)
        { titleNoTickets.Draw(_window); }
        backgroundNews.Draw(_window);   
        titleNews.Draw(_window);
        fartherNews.Draw(_window);
        titleTavelTicketsPay.Draw(_window);
    }
    private Texts titleTicketUpper;
    private Texts titleTicketMiddle;
    private Texts titleTicketLower;
    private Texts titleCard;
    private Texts date;
    private Texts title1Cards;
    private Texts title2Cards;
    private Texts title3Cards;
    private Texts decriptionTicketUpper;
    private Texts decriptionTicketLower;
    private Texts decriptionTicketMiddle;
    private Texts titleTavelTickets;
    private Texts title2TavelTickets;
    private Texts priceTravelTickets;
    private Texts warningTravelTickets;
    private Texts monthTravelTickets;
    private Texts expirationDateTravelTickets;
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
    private Button backgroundRight;
    private Button ticketUpper;
    private Button ticketMiddle;
    private Button ticketLower;
    private Button backgroundTravelTicket;
    private Button plusTravelTicket;
    private Button travelTicket;
    private Button plusTicket;
    private Button backgroundCards;

}