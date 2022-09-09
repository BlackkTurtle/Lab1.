using System;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            char lastDigit = n[n.Length - 1];
            Console.WriteLine(lastDigit);
        }
    }
}
