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
    private Button backgroundLeft;
    private Button backgroundRight;
    private Texts titleFrameText;
    private Texts monthText;
    private Texts titleTravelTicketText;
    private Texts benefitsSharedText;
    private Texts benefitsPensionText;
    private Texts benefitsStudentText;
    private Texts titleTravelTicketText2;
    private Texts priceTravelTicketText;
    private string warningDocument;
    private string warning;
    private Texts warningText;
    private Texts lineText;
    private Texts lineText2;
    private Texts lineText3;
    private Texts paymentText;
    private Texts amountText;
    private Texts warningPaymentText;
    private Button chooseBenefitsShared;
    private Button chooseBenefitsStudent;
    private Button chooseBenefitsPension;
    private Button lines;
    private Button travelTicket;
    private Button qrCode;
    private Button buttonPayment;
    private Texts paymentTitleText;
    private Texts titleFrameTextRight;
    private Texture chooseBenefitsOnTexture;
    private Texture chooseBenefitsOffTexture;
    private string benefitsShared;
    private string benefitsPension;
    private string benefitsStudent;
    private static bool canClick;
   // public float amount;
    private string amount;
    public void Display(RenderWindow _window)
    {
        backgroundLeft.Draw(_window);
        backgroundRight.Draw(_window);
        titleFrameText.Draw(_window);
        titleFrameTextRight.Draw(_window);
        monthText.Draw(_window);
       
        benefitsSharedText.Draw(_window);
        benefitsPensionText.Draw(_window);
        benefitsStudentText.Draw(_window);
        
        
        warningText.Draw(_window);
        lineText.Draw(_window);
        lineText2.Draw(_window);
        lineText3.Draw(_window);
        paymentText.Draw(_window);
        amountText.Draw(_window);
        warningPaymentText.Draw(_window);
        chooseBenefitsShared.Draw(_window);
        chooseBenefitsStudent.Draw(_window);
        chooseBenefitsPension.Draw(_window);
        lines.Draw(_window);
        travelTicket.Draw(_window);
        qrCode.Draw(_window);
        buttonPayment.Draw(_window);
        paymentTitleText.Draw(_window);
        titleTravelTicketText.Draw(_window);
        titleTravelTicketText2.Draw(_window);
        priceTravelTicketText.Draw(_window);
    }
    private string GetMonthName()
    {
        DateTime currentDate = DateTime.Now;
        DateTime monthToReturn = currentDate.Day <= 15 ? currentDate : currentDate.AddMonths(1);
        string monthName = monthToReturn.ToString("MMMM");
        string capitalizedMonthName = char.ToUpper(monthName[0]) + monthName.Substring(1).ToLower();

        return capitalizedMonthName;
    }
    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;   
        database = new Database();
        flagFrames = new FlagFrames();
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        Texture backgroundLeftTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundLeftWithTop.png"));
        Texture backgroundRightTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundRightWithTop.png"));
        chooseBenefitsOnTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "chooseBenefitsOn.png"));
        chooseBenefitsOffTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "chooseBenefitsOff.png"));
        Texture lineTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "line.png"));
        Texture travelTicketTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "travelTicket.png"));
        Texture qrCodeTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "qrCode.png"));
        
        Texture buttonPaymentTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonPayment.png"));
        backgroundLeft = new Button(53, 170, backgroundLeftTexture);
        backgroundRight = new Button(994, 170, backgroundRightTexture);
        chooseBenefitsShared = new Button(114, 310, chooseBenefitsOnTexture);
        chooseBenefitsStudent = new Button(285, 310, chooseBenefitsOffTexture);
        chooseBenefitsPension = new Button(530, 310, chooseBenefitsOffTexture);
        lines = new Button(114, 376, lineTexture);
        travelTicket = new Button(114, 396, travelTicketTexture);
        qrCode = new Button(1283, 437, qrCodeTexture);
        buttonPayment = new Button(1310, 878, buttonPaymentTexture);
        
        string titleFrame = "Купить проездной:";
        
        benefitsShared = "Общий";
        benefitsPension = "Пенсионный";
        benefitsStudent = "Студенческий";
        
        string titleTicketCard2 = "проездной билет";
        string priceTravelTicket = database.ticketCardPriceGet(benefitsShared) + "\u20bd";
        amount = database.ticketCardPriceGet(benefitsShared);
        warningDocument = "*необходим документ, можно купить только 1 за месяц";
        warning = "*можно купить только 1 за месяц";
        
        
        string titleFrameRight = "Оплата проездного билета";
        string line = "Для оплаты проезда нажмите “оплатить”, а после  предъявите ";
        string line2 = "необходимые документы кондуктору транспортного средства.";
        string line3 = "Хорошей поездки!";
        string payment = "К оплате:";

        string paymentTitle = "Оплатить";
        string warningPayment = "*недостаточно средств";
        Color baseColorText = new Color(68, 68, 69);
        Color warningTextColor = new Color(202, 128, 128);
        Color colorMessage = new Color(136, 136, 136);
        
        titleFrameText = new Texts(114, 237, font, 36, baseColorText, titleFrame);
        monthText = new Texts(530, 237, font, 36, baseColorText, GetMonthName());
        
        benefitsSharedText = new Texts(169, 313, font, 24, baseColorText, benefitsShared);
        benefitsPensionText = new Texts(585, 313, font, 24, baseColorText, benefitsPension);
        benefitsStudentText = new Texts(340, 313, font, 24, baseColorText, benefitsStudent);
        
        titleTravelTicketText = new Texts(380, 455, font, 36, baseColorText, benefitsShared);
        titleTravelTicketText2 = new Texts(380, 496, font, 36, baseColorText, titleTicketCard2);
        
        priceTravelTicketText = new Texts(160, 558, font, 32, baseColorText, priceTravelTicket);
        warningText = new Texts(134, 660, font, 20, warningTextColor, warning);
        titleFrameTextRight = new Texts(1037, 237, font, 36, baseColorText, titleFrameRight);
        
        lineText = new Texts(1037, 309, font, 24, colorMessage, line);
        lineText2 = new Texts(1037, 345, font, 24, colorMessage, line2);
        lineText3 = new Texts(1037, 379, font, 24, colorMessage, line3);
        paymentText = new Texts(1345, 739, font, 36, baseColorText, payment);
        amountText = new Texts(1345, 786, font, 36, baseColorText, priceTravelTicket);
        warningPaymentText = new Texts(1315, 838, font, 20, warningTextColor, warningPayment);
        
        paymentTitleText = new Texts(1345, 886, font, 36, baseColorText, paymentTitle);
        //amount = float.Parse(priceTravelTicket);
    }

    private void ButtonInteraction(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
            if (chooseBenefitsShared.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (chooseBenefitsShared.IfTexture(chooseBenefitsOffTexture))
                {
                    chooseBenefitsShared.SetTexture(chooseBenefitsOnTexture);
                    chooseBenefitsPension.SetTexture(chooseBenefitsOffTexture);
                    chooseBenefitsStudent.SetTexture(chooseBenefitsOffTexture);
                    priceTravelTicketText.SetText(database.ticketCardPriceGet(benefitsShared));
                    amountText.SetText(database.ticketCardPriceGet(benefitsShared));
                    titleTravelTicketText.SetText(benefitsShared);
                    amount = database.ticketCardPriceGet(benefitsShared);
                }
                else
                {
                    chooseBenefitsShared.SetTexture(chooseBenefitsOffTexture);
                }
            }
            if (chooseBenefitsStudent.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (chooseBenefitsStudent.IfTexture(chooseBenefitsOffTexture))
                {
                    chooseBenefitsStudent.SetTexture(chooseBenefitsOnTexture);
                    chooseBenefitsPension.SetTexture(chooseBenefitsOffTexture);
                    chooseBenefitsShared.SetTexture(chooseBenefitsOffTexture);
                    priceTravelTicketText.SetText(database.ticketCardPriceGet(benefitsStudent));
                    amountText.SetText(database.ticketCardPriceGet(benefitsStudent));
                    titleTravelTicketText.SetText(benefitsStudent);
                    amount = database.ticketCardPriceGet(benefitsStudent);
                }
                else
                {
                    chooseBenefitsStudent.SetTexture(chooseBenefitsOffTexture);
                }
            }
            if (chooseBenefitsPension.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (chooseBenefitsPension.IfTexture(chooseBenefitsOffTexture))
                {
                    chooseBenefitsPension.SetTexture(chooseBenefitsOnTexture);
                    chooseBenefitsStudent.SetTexture(chooseBenefitsOffTexture);
                    chooseBenefitsShared.SetTexture(chooseBenefitsOffTexture);
                    priceTravelTicketText.SetText(database.ticketCardPriceGet(benefitsPension));
                    amountText.SetText(database.ticketCardPriceGet(benefitsPension));
                    titleTravelTicketText.SetText(benefitsPension);
                    amount = database.ticketCardPriceGet(benefitsPension);
                }
                else
                {
                    chooseBenefitsPension.SetTexture(chooseBenefitsOffTexture);
                }
            }

            if (buttonPayment.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                string numberPhone = WorkWithJson.ReadPhoneNumberFromFile();
                string email = WorkWithJson.ReadEmailFromFile();
                int id = database.GetUserId(numberPhone, email);
               database.notificationsAdd(id, "Списание", amount);
               //yfgbcfnm ,fkfyc
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