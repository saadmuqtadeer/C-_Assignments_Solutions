using System;

namespace Calculator {
    internal class Program {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("WELCOME TO BASIC CALCULATOR");
                Console.WriteLine("Enter 2 Numbers");
                Console.WriteLine("Number-1:");
                float number1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Number-2:");
                float number2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Select an operation from Below options");
                Console.WriteLine("0. Exit:");
                Console.WriteLine("1.Add two numbers:");
                Console.WriteLine("2.Subtract two numbers:");
                Console.WriteLine("3.Multiply two numbers:");
                Console.WriteLine("4.Divide two numbers:");
                int option = int.Parse(Console.ReadLine());
                float ans;
                switch (option) {
                    case 0: 
                        Console.WriteLine("Thanking for using Basic Calculator, Existing...");
                        return;
                    case 1:
                        ans = number1+number2;
                        Console.WriteLine("Addition of two numbers is: {0}", ans);
                        break;
                    case 2:
                        ans = number1 - number2;
                        Console.WriteLine("Suntraction of two numbers is: {0}", ans);
                        break;
                    case 3:
                        ans = number1 * number2;
                        Console.WriteLine("Multiplication of two numbers is: {0}", ans);
                        break;
                    case 4:
                        if (number2 != 0)
                        { 
                            ans = number1 / number2;
                            Console.WriteLine("Division of two numbers is: {0}", ans);
                        }
                        else Console.WriteLine("Error: Division by zero is not allowed");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}