public class carshop
{

public List<car> ourcars = new List<car>();

public carshop(){

    car firstcar = new car(carbrand.AUDI, carcolor.blue, 870);
    ourcars.Add(firstcar);
    
    car second = new car(carbrand.BMW, carcolor.yellow, 420);
    ourcars.Add(second);
}

public car Buy(car CAR){
    ourcars.Remove(CAR);
    return CAR;
}
public List<car> showcars(){
    foreach (car CAR in ourcars)
    {
        Console.WriteLine("this car is   " + CAR.color + "  colored, and model name is  " + CAR.brand + "  and the car costs that much:  " +CAR.price);
    }
    return ourcars;
}
}