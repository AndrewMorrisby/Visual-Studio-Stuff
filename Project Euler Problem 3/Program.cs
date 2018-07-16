using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Problem_3
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("What's the smallest positive number that is evenly divisible by all of the numbers from 1 - 20");
            Console.WriteLine("What's the answer principle skinner?");
            Console.WriteLine("No ralph jesus didn't have wheels but this is the answer");
            Console.WriteLine("Press enter to get the answer");
            Console.ReadLine();
            bool number = false;
            for (int i = 20; !number; i++)
            {
                if (i % 1 == 0 &&
                   i % 2 == 0 &&
                   i % 3 == 0 &&
                   i % 4 == 0 &&
                   i % 5 == 0 &&
                   i % 6 == 0 &&
                   i % 7 == 0 &&
                   i % 8 == 0 &&
                   i % 9 == 0 &&
                   i % 10 == 0 &&
                   i % 11 == 0 &&
                   i % 12 == 0 &&
                   i % 13 == 0 &&
                   i % 14 == 0 &&
                   i % 15 == 0 &&
                   i % 16 == 0 &&
                   i % 17 == 0 &&
                   i % 18 == 0 &&
                   i % 19 == 0 &&
                   i % 20 == 0)
                {
                    number = true;
                    Console.WriteLine(i);
                }

            }
            
        }
    }
}
        
      
    


