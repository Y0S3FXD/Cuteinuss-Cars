using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Customer");
        CarShop shop = new CarShop();
        Player mainCharacter = new Player(1000);
        bool selling = false;
        //method with a case and break to determine the action the player is to take, which calls methods to either buy or sell, or exits:
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
            //There is taken an answer, assigned to a abreviated variable,which is parsed and instatiates an object: 
            Console.WriteLine("We currently are only buying BMW, AUDI, Mercedes, Ford, Ferrari, please write which kind you are selling (case sensitive string)");
            string cm = Console.ReadLine();
            CarBrand carModel = Enum.Parse<CarBrand>(cm);
            Console.WriteLine("how much do you want");
            string carprice = Console.ReadLine();
            int converted = int.Parse(carprice);
            converted = int.Parse(carprice);
            Console.WriteLine("what color is it? (yellow, blue, red, black)");
            string cc = Console.ReadLine();
            CarColor ccolor = Enum.Parse<CarColor>(cc);
            Console.WriteLine("what brand of tyre does it have? (Michelin, Continental, GoodYear, Imperial)");
            string BOT = Console.ReadLine();
            TyreBrand BrandOfTyre = Enum.Parse<TyreBrand>(BOT);
            //= Console.ReadLine();
            Car new_car = new Car(carModel, ccolor, converted, TyreBrand.Continental);
            Car carpaymentsuccesful = shop.Insert(new_car);
            mainCharacter.AddMoney(converted);
            Console.WriteLine("now your balance is $" + mainCharacter.GetMoney());
            Console.WriteLine("Want to sell another car yes/no");
            string ansswer = Console.ReadLine();
            if (ansswer == "no")
            {
                selling = false;
            }
        }

        void buyCar()
        {
            //The list is shown, and if the method made to check if the player can afford the car returns true the price calls the method to deduct the price of the car:

            List<Car> cars = shop.showcars();
            Console.WriteLine("\nwhich one you want, write integer, remember you only have $" + mainCharacter.GetMoney());
            string answer = Console.ReadLine();
            int converted = int.Parse(answer);
            if (mainCharacter.CanAfford(cars[converted].price))
            {
                mainCharacter.DeductMoney(cars[converted].price);
                Car newcar = shop.Buy(cars[converted]);
                Console.WriteLine("\nCongratz on your new car its an " + newcar.brand + "  its very shiny " + newcar.color + " this is special edition color. You now only have $" + mainCharacter.GetMoney());
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
        //Sends error message if surden unintended events take place:
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