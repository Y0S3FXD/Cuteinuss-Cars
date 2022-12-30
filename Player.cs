//the player is a public class with the integer for its money, which is instantiated at the start of the program
public class Player
{
    private int _money;

    public Player(int walletAmount)
    {
        this._money = walletAmount;
    }
    //to methods are added to take or add money to the object's integer
    public void DeductMoney(int amount)
    {
        _money -= amount;
    }
    public void AddMoney(int amount)
    {
        _money += amount;
    }

    public Boolean CanAfford(int amount)
    {
        return amount <= _money;
    }

    // as the _money is private, as this is object-oriented and it doesn't allow the player to change the money by changing the variable, there is a getter to access it
    public int GetMoney()
    {
        return _money;
    }
}
