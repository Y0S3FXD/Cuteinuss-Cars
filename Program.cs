using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Runtime.InteropServices;
/*
* Todays work will be refactoring the Car, Door and Tire class into seperate files
* and laying the ground work for the next assignment
*/

internal class Program
{
    private static void Main(string[] args)
    {
        //Instantiating a Car class / Creating an object of type Car
        Console.WriteLine("Hello Customer");
        CarShop shop = new CarShop();
        Player mainCharacter = new Player(1000);
        bool selling = false;

        void cardealer(string input)
        {
            switch (input)
            {
                case "buy":
                    buyCar();
                    break;
                case "sell":
                    selling = true;
                    while (selling)
                    {
                        sellCar();
                    }
                    break;
                case "exit":
                    return;
                default:
                    return;
            }
        }

        void sellCar()
        {
            Console.WriteLine("We currently are only buying BMW, AUDI, MERCEDESM, FORD, FERRARI, please write which kind you are selling (case sensitive)");
            string cm = Console.ReadLine();
            CarBrand carModel = Enum.Parse<CarBrand>(cm);
            Console.WriteLine("how much do you want");
            string carprice = Console.ReadLine();
            int converted = int.Parse(carprice);
            converted = int.Parse(carprice);
            Console.WriteLine("what color is it(yellow, blue, red, black)");
            //int colorcar = GetIntInput("No, it needs to an integer");
            //Console.WriteLine("You chose color ; " + (carcolor)colorcar);
            string cc = Console.ReadLine();
            CarColor ccolor = Enum.Parse<CarColor>(cc);
            //= Console.ReadLine();
            Car new_car = new Car(carModel, ccolor, converted, TyreBrand.Continental);
            Car carpaymentsuccesful = shop.Insert(new_car);
            Console.WriteLine("Want to sell another car yes/no");
            string ansswer = Console.ReadLine();
            if (ansswer == "no")
            {
                selling = false;
            }
        }

        void buyCar()
        {
            List<Car> cars = shop.showcars();
            Console.WriteLine("\nwhich one you want, write integer.");
            string answer = Console.ReadLine();
            int converted = int.Parse(answer);
            if (mainCharacter.CanAfford(cars[converted].price))
            {
                mainCharacter.DeductMoney(cars[converted].price);
                Car newcar = shop.Buy(cars[converted]);
                Console.WriteLine("\nCongratz on your new car its an " + newcar.brand + "  its very shiny " + newcar.color + " this is special edition color\n");
            }
            else
            {
                Console.WriteLine("you don't have the dough you only have $" + mainCharacter.GetMoney());
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
    }
}