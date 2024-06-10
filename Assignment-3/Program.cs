using System;
using System.Security;

namespace CelciusTOFaren {

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("WELCOME TO TEMPERATURE CONVERTOR");
                Console.WriteLine("Enter value of currect temperature");
                Console.WriteLine("Current temperature:");
                float currentTemp = float.Parse(Console.ReadLine());
                Console.WriteLine("Select an operation from Below options");
                Console.WriteLine("0. Exit:");
                Console.WriteLine("1.Convert to Celcius:");
                Console.WriteLine("2.Convert to Fahrenheit:");
                int option = int.Parse(Console.ReadLine());
                float ans;
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Thanking for using Temperature Convertor, Existing...");
                        return;
                    case 1:
                        ans = currentTemp;
                        Console.WriteLine("Temperature in CELCIUS: {0}^C", ans);
                        break;
                    case 2:
                        ans = ((currentTemp*9)/5) + 32;
                        Console.WriteLine("Temperature in FEHRENHEIT: {0}^F", ans);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}