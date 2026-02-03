namespace CasinoDiceGame.Infrastructure;

public class RandomNumberProvider
{
    private readonly Random _random = new();

    public int GetRandomNumber(int min, int max)
    {
        return _random.Next(min, max + 1);
    }
}