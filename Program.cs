using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The namespace across the program and classes must all share the same name
namespace ClassStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player("Steve", 32, "The Destroyer", "Good", 6);
            var player2 = new Player("Steve", 24, "Gayboy79", "Average", 3);
            var player3 = new StarcraftPlayer("Yo Hin", 19, "Shnrrr", "Pro", 987, "Zerg", "Korean", 432);
            

            Console.WriteLine(player1.ToString());
            Console.WriteLine(" ");
            Console.WriteLine(player2.ToString());
            Console.WriteLine(" ");
            Console.WriteLine(player3.ToString());

        }
       
    }
}
