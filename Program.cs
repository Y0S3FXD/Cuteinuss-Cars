using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Runtime.InteropServices;
/*
* Todays work will be refactoring the Car, Door and Tire class into seperate files
* and laying the ground work for the next assignment
*/

//Instantiating a Car class / Creating an object of type Car


Console.WriteLine("Hello Customer");
carshop shop = new carshop();
void cardealer(string input){
    switch (input)
    {
        case "buy":
            List<car> cars = shop.showcars();
            Console.WriteLine("\nwhich one you want, write integer.");
            string answer = Console.ReadLine();
            int converted = Int32.Parse(answer);
            car newcar = shop.Buy(cars[converted]);
            Console.WriteLine("\nCongratz on your new car its an "+newcar.brand +"  its very shiny  " + newcar.color + " this is sepcial edition color\n");
            break;
        case "sell":
        bool selling = true;
        while (selling)
        {
            
        
            Console.WriteLine("We currently are only buying BMW, AUDI, MERCEDESM, FORD, FERRARI");
            string cm = Console.ReadLine();
            carbrand carmodel = (Enum.Parse<carbrand>(cm));
            Console.WriteLine("What is the price");
            string carprice = Console.ReadLine();
            converted = Int32.Parse(carprice);
            Console.WriteLine("what color is it");
            //int colorcar = GetIntInput("No, it needs to an integer");
            //Console.WriteLine("You chose color ; " + (carcolor)colorcar);
            string cc = Console.ReadLine();
            carcolor ccolor = (Enum.Parse<carcolor>(cc));
         //= Console.ReadLine();
            car new_car = new car((carbrand)carmodel, (carcolor)ccolor, converted);
            car carpaymentsuccesful = shop.insert(new_car);
            List<car>cars1 = shop.showcars();
            Console.WriteLine("Want to sell another car yes/no");
            string ansswer = Console.ReadLine();
            if (ansswer == "no")
            {
                selling = false;
            }
        }
            break;
        case "exit":
            return;
        default:
            return;
    }
}
bool process = true;
while (process)
{
    Console.WriteLine("Write an action [buy, sell, exit]");
cardealer(Console.ReadLine());
Console.WriteLine("Anything else yes/no");
string answer = Console.ReadLine();
if (answer == "no")
{
    process = false;
}

}

Console.WriteLine("Good bye deer friend, and take care driving");
Thread.Sleep(3200);
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