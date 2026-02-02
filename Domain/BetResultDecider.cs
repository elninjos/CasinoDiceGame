using CasinoDiceGame.Domain.Models;

namespace CasinoDiceGame.Domain;

public static class BetResultDecider
{
    public static bool IsWin(BetType bet, int diceResult)
    {
        return bet switch
        {
            BetType.Low => diceResult is >= 1 and <= 3,
            BetType.High => diceResult is >= 4 and <= 6,
            _ => false
        };
    }
}