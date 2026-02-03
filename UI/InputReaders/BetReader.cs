using CasinoDiceGame.Domain;
using CasinoDiceGame.Domain.Models;
using CasinoDiceGame.UI.InputHandlers;

namespace CasinoDiceGame.UI.InputReaders;

public static class BetReader
{
    public static int ReadAmount(int creditAmount)
    {
        while (true)
        {
            Console.WriteLine("Place a bet amount:");
            string? inputAmount = Console.ReadLine();
            int betAmount = InputHandler.TryGetInputAmount(inputAmount);
            if (betAmount > 0 && betAmount <= creditAmount)
            {
                return betAmount;
            }
            
            Console.WriteLine($"Invalid bet! Number must be between 1 and {creditAmount}.");
        }
    }
    
    public static BetType ReadBetType()
    {
        while (true)
        {
            Console.WriteLine("\nChoose bet type. Write down 'low' for numbers 1–3 or 'high' for numbers 4–6:");
            string? betTypeValue = Console.ReadLine();
            BetType betType = InputHandler.TryGetInputBetType(betTypeValue);
            if (betType != BetType.Undefined)
            {
                return betType;
            }
            
            Console.WriteLine("Invalid bet type! Type 'Low' or 'High'.");
        }
    }
}