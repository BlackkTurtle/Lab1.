using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=:");
            int a=int.Parse(Console.ReadLine());
            if (a % 9 == 0 || a % 11 == 0 || a % 13 == 0)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
        }
    }
}
