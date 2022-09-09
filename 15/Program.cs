using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a:=");
            double a=double.Parse(Console.ReadLine());
            Console.WriteLine("b:=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c:=");
            double c = double.Parse(Console.ReadLine());
            if (a * b * c >= 0)
            {
                Console.WriteLine("Positive");
            }
            else { Console.WriteLine("Negative"); }
        }
    }
}
