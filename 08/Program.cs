using System;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a =:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b =:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c =:");
            int c = int.Parse(Console.ReadLine());
            double average = (double)(a + b + c) / 3;
            average=Math.Round(average, 5);
            Console.WriteLine("Average =:"+average);
        }
    }
}
