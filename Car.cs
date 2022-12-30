public class Car
{
    public CarBrand brand;
    public CarColor color;
    public int price;
    public TyreBrand tyre;

    public Car(CarBrand brand, CarColor color, int price, TyreBrand brandOfTyre)
    {
        this.brand = brand;
        this.color = color;
        this.price = price;
        this.tyre = brandOfTyre;
    }
}
