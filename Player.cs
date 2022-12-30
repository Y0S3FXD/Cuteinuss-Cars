public class Player
{
    private int _money;

    public Player(int walletAmount)
    {
        this._money = walletAmount;
    }

    public void DeductMoney(int amount)
    {
        _money -= amount;
    }

    public Boolean CanAfford(int amount)
    {
        return amount <= _money;
    }

    public int GetMoney()
    {
        return _money;
    }
}
