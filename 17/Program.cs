﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=:");
            int n=int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i=2; i<=n; i++)
            {
              factorial=factorial*i;
            }
            Console.WriteLine(factorial);
        }
    }
}
