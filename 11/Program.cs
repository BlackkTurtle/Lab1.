using System;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number=:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("n=:");
            int n = int.Parse(Console.ReadLine());
            int c = 10;
            for (int i = 1; i < n - 1; i++)
            {
                c = c * 10;
            }
            double a = (double)number / c / 10;
            string nDigit = Convert.ToString(a % 1);
            nDigit = nDigit.Substring(2);
            nDigit= nDigit.Substring(0,nDigit.Length-(nDigit.Length-1));
            Console.WriteLine(nDigit);
        }
    }
}
