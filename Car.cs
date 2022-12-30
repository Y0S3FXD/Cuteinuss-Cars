public class Car
{
    public CarBrand brand;
    public CarColor color;
    public int price;
    public TyreBrand tyre;

    //car constructor takes in parameters which are input when a new cardealer is instiantiated og when a car is sold to the dealership
    public Car(CarBrand brand, CarColor color, int price, TyreBrand brandOfTyre)
    {
        this.brand = brand;
        this.color = color;
        this.price = price;
        this.tyre = brandOfTyre;
    }
}
