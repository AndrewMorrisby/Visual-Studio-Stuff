using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pallendromes = new List<int>();
            for (int j = 100; j <= 999; j++)
            {
                for (int k = 100; k <= 999; k++)
                {
                    int product = k * j;
                    bool p = IsPallendrome(product);

                    if (p)
                    {
                        pallendromes.Add(product);
                        Console.WriteLine(product);

                    }
                }
                pallendromes.Sort();
            }
            Console.WriteLine(pallendromes.Last());
        }

        // Method is here to test whether the number is a pallendrome. This will return true if the product number above reads the same way when reversed. 
        static Boolean IsPallendrome(int number)
        {
            string bob = Convert.ToString(number);
            string r = Reverse(bob);
            if (bob == r)
            {
                return true; 
            }
            else
            {
                return false;

            }
        }
        

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}