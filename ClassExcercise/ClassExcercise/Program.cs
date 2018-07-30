using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int a = 0;
            int temp = 0;
            for(int i = 1; i <= 100; i++)
            {
                a = a + 1;
                temp = (a*a) + temp;
            }

            int b = 0;
            int c = 0;
            int total = 0;
            for (int i = 1; i <= 100; i++)
            {
                b = b + 1;
                c = total;
                total = (c + b);
                
            }
            int grandtotal = total * total;
            Console.WriteLine(grandtotal-temp);

        }
    }
}