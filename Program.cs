using CasinoDiceGame.Domain;
using CasinoDiceGame.Domain.Models;
using CasinoDiceGame.UI.InputReaders;

const int numberOfRounds = 10;
const int maxInputCreditAmount = 2000000;

Console.WriteLine("   ____          _               ____  _             ____                      \n  / ___|__ _ ___(_)_ __   ___   |  _ \\(_) ___ ___   / ___| __ _ _ __ ___   ___ \n | |   / _` / __| | '_ \\ / _ \\  | | | | |/ __/ _ \\ | |  _ / _` | '_ ` _ \\ / _ \\\n | |__| (_| \\__ \\ | | | | (_) | | |_| | | (_|  __/ | |_| | (_| | | | | | |  __/\n  \\____\\__,_|___/_|_| |_|\\___/  |____/|_|\\___\\___|  \\____|\\__,_|_| |_| |_|\\___|\n");
Console.WriteLine("Welcome to Casino Dice Game!\n");

int creditAmount = CreditReader.ReadAmount(maxInputCreditAmount);
var player = new Player(creditAmount);
var dice = new Dice();

int i;
for (i = 0; i < numberOfRounds; i++)
{
    Console.WriteLine($"\n----- Round {i+1} -----");
    
    int betAmount = BetReader.ReadAmount(player.GetCredit());
    BetType betType = BetReader.ReadBetType();
    var bet = new Bet(betAmount, betType);
    
    Console.WriteLine("\nRolling dice...");
    int diceNumber = dice.Roll();
    Console.WriteLine($"Dice rolled: {diceNumber}");

    bool roundWin = BetResultDecider.IsWin(bet.Type, diceNumber);
    int newCreditAmount = roundWin ? player.GetCredit() + bet.Amount : player.GetCredit() - bet.Amount;
    player.SetCredit(newCreditAmount);
    
    Console.WriteLine(roundWin ? $"\nYou WIN {bet.Amount}!" : "\nYou LOSE!");

    if (player.GetCredit() <= 0)
    {
        break;
    }
    
    Console.WriteLine($"Current credit: {newCreditAmount}");
}

Console.WriteLine("Game over!\n");
Console.WriteLine($"Rounds played: {i}/{numberOfRounds}");
Console.WriteLine($"Final credit: {player.GetCredit()}\n");
Console.WriteLine("Thank you for playing!");