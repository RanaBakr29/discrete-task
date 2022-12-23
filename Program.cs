using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find prime numbers within a given number of range:");
            Console.WriteLine("------------------------------------------------------");


            Console.WriteLine("ENTER THE NUMBER 1 ");
            int startnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE NUMBER 2 ");
            int endnumber = int.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("the prime numbers : ");
            for (int i = startnumber; i <= endnumber; i++)
            {
                for (int r = 1; r <=i; r++)
                {
                    if (i % r == 0)
                    {
                        sum++;

                    }
                   
                }
                if (sum == 2)
                {
                    Console.WriteLine( "{0}" ,i);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                    continue;
                }
            }
          


        }

        }
        
    }

