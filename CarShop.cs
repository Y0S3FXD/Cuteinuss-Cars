// A list of avaiable cars is created, and there is added code so that the list can be expanded or shortened, while there is a desctiption of each car:
public class CarShop
{

    public List<Car> ourcars = new List<Car>();

    public CarShop()
    {
        ourcars.Add(new Car(CarBrand.AUDI, CarColor.blue, 870, TyreBrand.Michelin));
        ourcars.Add(new Car(CarBrand.BMW, CarColor.yellow, 420, TyreBrand.Continental));
    }

    public Car Buy(Car CAR)
    {
        ourcars.Remove(CAR);
        return CAR;
    }
    public Car Insert(Car CAR)
    {
        ourcars.Add(CAR);
        return CAR;
    }

    public List<Car> showcars()
    {

        foreach (Car CAR in ourcars)
        {
            Console.WriteLine(ourcars.IndexOf(CAR)
            + ". this car is " + CAR.color
            + "  colored, and model name is " + CAR.brand
            + "  and the car costs " + CAR.price
            + "  with tyres " + CAR.tyre);
        }
        return ourcars;
    }
}
