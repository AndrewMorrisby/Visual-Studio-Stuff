using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Starcraft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Click=Click)
            {
                var player1 = new Player("Terry", "The Destroyer", 32, "Excellent", 54);
                var player2 = new Player("Gary", "The Idiot", 24, "poor", 23);
                var player3 = new StarcraftPlayer("Tim", "The Moron", 24, "Average", 12, "Zerg", "Korean", 454);
                var player4 = new StarcraftPlayer("Andrew", "The Dunce", 24, "Pro", 79, "Terran", "British", 407);

                Console.WriteLine(player1.ToString());
                Console.WriteLine(" ");
                Console.WriteLine(player2.ToString());
                Console.WriteLine(" ");
                Console.WriteLine(player3.ToString());
                Console.WriteLine(" ");
                Console.WriteLine(player4.ToString());
            }
            else { }


        }
    }
    
}
