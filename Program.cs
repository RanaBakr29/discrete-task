﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefect_number_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  i, sum;

            Console.WriteLine("Find perfect numbers within a given number of range:\n");
            Console.WriteLine("------------------------------------------------------");


            Console.Write("Input the starting range or number : ");
            int mn = int.Parse(Console.ReadLine());
            Console.Write("Input the ending range of number : ");
            int mx = int.Parse(Console.ReadLine());
            Console.Write("The Perfect numbers within the given range : ");
            for ( int n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum += i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");
        }
    }
}
