using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {//fibonnaci sequence
            int a = 1;
            int b = 2;
            int c = a + b;
            long total = 2;
            for (int i = 0; i < 4000000; i++)
            { a = b;
                b = c;
                c = b + a;
                bool isEven = ((c % 2) == 0);
                if (c >= 4000000) { break; }
                if (isEven == true)
                {
                    total = total + c;
                }
            }
            Console.WriteLine(total);


        }
    }
}
