using System;
using System.Globalization;


namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a =:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b =:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("h =:");
            double h = Convert.ToDouble(Console.ReadLine());
            double area = (double)(a + b) / 2*h;
            area = Math.Round(area, 5);
            Console.WriteLine("Area =:" + area);
        }
    }
}
