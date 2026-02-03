namespace CasinoDiceGame.Domain;

public class Player(int credit)
{
    private int _credit = credit;

    public int GetCredit()
    {
        return _credit;
    }

    public void SetCredit(int amount)
    {
        _credit = amount;
    }
}