namespace CasinoDiceGame.Domain.Models;

public class Bet(int amount, BetType type)
{
    public int Amount { get; } = amount;
    public BetType Type { get; } = type;
}