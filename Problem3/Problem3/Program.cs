using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        { //To count from 100 - 999 that being the range that we want to check.

            for (int i = 100; i <= 10000000; i++)

            {   // To count from 1 - 20, this being the conditions of the problem
                for (int j = 2; j <= 20; j++)
                {
                    //If i e.g 100 modular of j e.g 1 doesnt return a remainder this is true. If so show i
                    if (i % j == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                            {
                        Console.WriteLine("");
                            }
                    

                }
               
            }
        }
    }
}
