namespace CTT;

public class RandomClass
{
    public int RandomCode()
    {
        Random random = new Random();
        int randomNumber = random.Next(1000, 10000);
        return randomNumber;
    }
}