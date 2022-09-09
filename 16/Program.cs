using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("d=:");
            string str=Console.ReadLine();
            double d;
            bool result = double.TryParse(str, out d);
            string[] myArray;
            myArray = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (result == false)
            {
                Console.WriteLine("not valid");
            }
            else
            {
                if (d > 0 & d < 8 & d % 1 == 0)
                {
                    int a = Convert.ToInt32(d);
                    Console.WriteLine(myArray[a - 1]);
                }
                else { Console.WriteLine("not valid"); }
            }
                
        }
    }
}
