using System;
using System.Text;

namespace isPalindrone {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter the text:");
            string s = Console.ReadLine().Trim();
            string t = Reverse(s);
            if (s == t)
                Console.WriteLine("{0} is a Valid Palindrone", s);
            else
                Console.WriteLine("{0} is not a Valid Palindrone", s);
        }

        static string Reverse(string str)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }
            return reversed.ToString();
        }
    }

}