namespace CTT.Frame;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class News
{
    public void Structure()
    {
        database = new Database();
        Texture newsPhotoArea =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "phooAreaNews.png"));
        Texture backgroundLeftTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundLeftWithTop.png"));
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        background = new Button(53, 170, backgroundLeftTexture);
        newsPhotoUpper = new Button(97, 316, newsPhotoArea);
        newsPhotoMiddle = new Button(97, 521, newsPhotoArea);
        newsPhotoLower = new Button(97, 726, newsPhotoArea);
        Color baseColorText = new Color(68, 68, 69);
        string titleNews = "Транспортные новости";
        string titleNewsUpper = database.GetNewsTitle("new");
        string descriptionNewsUpper = database.GetNewsDescription("new");
        string dateNewsUpper = database.GetNewsDate("new");
        string titleNewsMiddle = database.GetNewsTitle("avarage");
        string descriptionNewsMiddle = database.GetNewsDescription("average");;
        string dateNewsMiddle = database.GetNewsDate("average");
        string titleNewsLower = database.GetNewsTitle("latest");
        string descriptionNewsLower = database.GetNewsDescription("latest");
        string dateNewsLower = database.GetNewsDate("latest");
        titleNewsText = new Texts(96, 227, font, 36, baseColorText, titleNews);
        titleNewsUpperText = new Texts(512, 324, font, 36, baseColorText, titleNewsUpper);
        descriptionNewsUpperText = new Texts(515, 378, font, 24, baseColorText, descriptionNewsUpper);
        dateNewsUpperText = new Texts(515, 417, font, 24, baseColorText, dateNewsUpper);
        titleNewsMiddleText = new Texts(512, 529, font, 36, baseColorText, titleNewsMiddle);
        descriptionNewsMiddleText = new Texts(515, 583, font, 24, baseColorText, descriptionNewsMiddle);
        dateNewsMiddleText = new Texts(515, 622, font, 24, baseColorText, dateNewsMiddle);
        titleNewsLowerText = new Texts(512, 734, font, 36, baseColorText, titleNewsLower);
        descriptionNewsLowerText = new Texts(515, 788, font, 24, baseColorText, descriptionNewsLower);
        dateNewsLowerText = new Texts(515, 827, font, 24, baseColorText, dateNewsLower);
    }
    public void workProgram(RenderWindow _window)
    { Display(_window); }
    private Database database;
    private Button background;
    private Button newsPhotoUpper;
    private Button newsPhotoMiddle;
    private Button newsPhotoLower;
    private Texts titleNewsText;
    private Texts titleNewsUpperText;
    private Texts descriptionNewsUpperText;
    private Texts titleNewsMiddleText;
    private Texts descriptionNewsMiddleText;
    private Texts dateNewsMiddleText;
    private Texts titleNewsLowerText;
    private Texts descriptionNewsLowerText;
    private Texts dateNewsLowerText;
    private Texts dateNewsUpperText;
    private static bool canClick;
    public void Display(RenderWindow _window)
    {
        background.Draw(_window);
        newsPhotoUpper.Draw(_window);
        newsPhotoMiddle.Draw(_window);
        newsPhotoLower.Draw(_window);
        titleNewsText.Draw(_window);
        titleNewsUpperText.Draw(_window);
        descriptionNewsUpperText.Draw(_window);
        titleNewsMiddleText.Draw(_window);
        descriptionNewsMiddleText.Draw(_window);
        dateNewsMiddleText.Draw(_window);
        titleNewsLowerText.Draw(_window);
        descriptionNewsLowerText.Draw(_window);
        dateNewsLowerText.Draw(_window);
        dateNewsUpperText.Draw(_window);
    }
}