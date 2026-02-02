using CasinoDiceGame.Domain.Models;

namespace CasinoDiceGame.UI.InputHandlers;

public static class InputHandler
{
    public static int TryGetInputAmount(string? inputAmount)
    {
        _ = int.TryParse(inputAmount, out int amount);
        return amount;
    }
    
    public static BetType TryGetInputBetType(string? inputBetType)
    {
        return inputBetType?.ToLower() switch
        {
            "low" => BetType.Low,
            "high" => BetType.High,
            _ => BetType.Undefined
        };
    }
}