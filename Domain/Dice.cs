using CasinoDiceGame.Infrastructure;

namespace CasinoDiceGame.Domain;

public class Dice
{
    private const int Min = 1;
    private const int Max = 6;
    private readonly RandomNumberProvider _randomProvider = new();
    
    public int Roll()
    {
        return _randomProvider.GetRandomNumber(Min, Max);
    }
}