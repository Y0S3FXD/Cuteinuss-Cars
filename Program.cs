using System.ComponentModel;
using System.Runtime.InteropServices;
/*
* Todays work will be refactoring the Car, Door and Tire class into seperate files
* and laying the ground work for the next assignment
*/

//Instantiating a Car class / Creating an object of type Car


Console.WriteLine("Hello Customer");
carshop shop = new carshop();

Console.WriteLine("Write an action [buy, sell, exit]");
string input = Console.ReadLine();
while (true)
{
    switch (input)
    {
        case "buy":
            List<car> cars = shop.showcars();
            Console.WriteLine("which one you want, write integer.");
            string answer = Console.ReadLine();
            int converted = Int32.Parse(answer);
            car newcar = shop.Buy(cars[converted]);
            Console.WriteLine(newcar.brand + "  and  ", newcar.color);
            break;
        case "sell":
            Console.WriteLine("We currently are only buying BMW, AUDI, MERCEDESM, FORD, FERRARI");
            string cm = Console.ReadLine();
            var carmodel = (Enum.Parse(typeof(carbrand), cm));
            Console.WriteLine("What is the price");
            string carprice = Console.ReadLine();
            converted = Int32.Parse(carprice);
            Console.WriteLine("what color is it");
            //int colorcar = GetIntInput("No, it needs to an integer");
            //Console.WriteLine("You chose color ; " + (carcolor)colorcar);
            string cc = Console.ReadLine();
            var ccolor = (Enum.Parse(typeof(carcolor), cc));
         //= Console.ReadLine();
            car thirdcar = new car((carbrand)carmodel, (carcolor)ccolor, converted);

            List<car> car = shop.showcars();
            car.Add(thirdcar);
            shop.showcars();
            break;
        case "exit":
            return;
        default:
            return;
    }
}


Console.ReadKey();

//Class definition

int GetIntInput(string errorMessage)
{
    while (true)
    {
        var input = Console.ReadLine();

        if (int.TryParse(input, out var value))
        {
            return value;
        }
        else
        {
            Console.WriteLine(errorMessage);
        }
    }
}

string GetStringInput(string errorMessage)
{
    while (true)
    {
        var input = Console.ReadLine();

        if (input != null)
        {
            return input;
        }
        else
        {
            Console.WriteLine(errorMessage);
        }
    }
}