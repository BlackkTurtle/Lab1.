using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=:");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("b=:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c=:");
            int c = int.Parse(Console.ReadLine());
            int[] myArray;
            myArray = new int[3] { a, b, c };
            Console.WriteLine(myArray.Max());
        }
    }
}
