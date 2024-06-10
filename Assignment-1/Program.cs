using System;

namespace EvenOddNumberPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Even/Odd Number Printer!");
            Console.Write("Please enter a target number: ");
            int targetNumber = int.Parse(Console.ReadLine());

            Console.Write("Please select an option (even/odd): ");
            string choice = Console.ReadLine().Trim().ToLower();
            while (choice != "even" && choice != "odd")
            {
                Console.Write("Invalid option. Please select either 'even' or 'odd': ");
                choice = Console.ReadLine().Trim().ToLower();
            }

            Console.WriteLine($"Printing all {choice} numbers less than {targetNumber}:");
            if (choice == "even")
            {
                PrintEvenNumbers(targetNumber);
            }
            else
            {
                PrintOddNumbers(targetNumber);
            }   
        }

        static void PrintEvenNumbers(int target)
        {
            for (int i = 0; i < target; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintOddNumbers(int target)
        {
            for (int i = 1; i < target; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
