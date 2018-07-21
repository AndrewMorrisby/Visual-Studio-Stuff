using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine(i * i);
               
            }
            Console.WriteLine(" ");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine((j + j)*j);
            }
        } 
    } 
}
