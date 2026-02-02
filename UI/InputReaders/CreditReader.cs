using CasinoDiceGame.UI.InputHandlers;

namespace CasinoDiceGame.UI.InputReaders;

public static class CreditReader
{
    public static int ReadAmount(int maxInputCreditAmount)
    {
        while (true)
        {
            Console.WriteLine("Please set a credit amount:");
            string? inputAmount = Console.ReadLine();
            int creditAmount = InputHandler.TryGetInputAmount(inputAmount);
            if (creditAmount > 0 && creditAmount <= maxInputCreditAmount)
            {
                return creditAmount;
            }
            
            Console.WriteLine("Invalid credit! Number must be between 1 and 2.000.000.");
        }
    }
}