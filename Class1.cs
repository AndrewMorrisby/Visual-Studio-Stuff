using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStuff
{
    // This is the parent class that sets the intial properties of the class. 
    class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string NickName { get; set; }
        public string Ability { get; set; }
        public int GameWins { get; set; }

        // You need to initialise the class type by making a public instance of it. You do it as below.
        public Player() { }
      
        //You then need to create a constructor of the class that initialises the type of variables it has.
        // You need to "feed in" the type of information within the brackets. 
        //So the class has a name, age, nickaname, ability and gamewins. Each variable name needs to be preceded by its variable type.
        public Player(string name, int age, string nickname, string ability, int gamewins)
        {
            //You need to set the variables. Using this. references the parent class. 
            //Notice that Name has a capital letter but name is lower case as it is referencing
            //the contructor level scope.
            this.Name = name;
            this.Age = age;
            this.NickName = nickname;
            this.Ability = ability;
            this.GameWins = gamewins;
        }

        // The ToString method is something built into C#. To get around this you need to use the
        //override key word to set your own ToString Method. Or you could call it something else.
        public override string ToString()
        {
            string s = $" Players name is : {Name} \n Players Age is : {Age} \n Players Nickname is : {NickName} \n Players Ability is : {Ability} \n Players GameWins are : {GameWins}";
            string t = $"Players name is : {Name} \n Players Age is : {Age} \n Players Nickname is : {NickName} \n Players Ability is : Not very good";
            string s1 = "Average";
            string s2 = "Poor";
            string s3 = "Intermediate";
            bool b = s1.Contains(s1);
            bool c = s2.Contains(s2);
            bool d = s3.Contains(s3);
            if ((b) || (c) || (d))
            {
                return t;
            }
            else
            {
                return s;
            }
            
            
            
        }

    }
}
