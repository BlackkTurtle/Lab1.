using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=:");
            int n=int.Parse(Console.ReadLine());
            if (n>20&n%2!=0)
            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("False"); }
        }
    }
}
