public class carshop
{

public List<car> ourcars = new List<car>();

public carshop(){

    ourcars.Add(new car(carbrand.AUDI, carcolor.blue, 870));
    
    ourcars.Add(new car(carbrand.BMW, carcolor.yellow, 420));
    
}

public car Buy(car CAR){
    ourcars.Remove(CAR);
    return CAR;
}
public car insert(car CAR){
    ourcars.Add(CAR);
    return CAR;
}
public List<car> showcars(){

    foreach (car CAR in ourcars)
    {
        Console.WriteLine(ourcars.IndexOf(CAR) + ". this car is   " + CAR.color + "  colored, and model name is  " + CAR.brand + "  and the car costs that much:  " +CAR.price);
    }
    return ourcars;
}
}