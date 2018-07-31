using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStuff
{
    class StarcraftPlayer : Player
    {
        public string RacePreference { get; set; }
        public string Nationality { get; set; }
        public int APM { get; set; }

        public StarcraftPlayer() { }

        public StarcraftPlayer(string name, int age, string nickname, string ability, int gamewins, string racepreference, string nationality, int apm)
        {
            this.Name = name;
            this.Age = age;
            this.NickName = nickname;
            this.Ability = ability;
            this.GameWins = gamewins;
            this.RacePreference = racepreference;
            this.Nationality = nationality;
            this.APM = apm;
        }
        public override string ToString()
        {
            string s = $" Players name is : {Name} \n Players Age is : {Age} \n Players Nickname is : {NickName} \n Players Ability is : {Ability} \n Players GameWins are : {GameWins}";
            string s1 = "Average";
            string s2 = "Poor";
            string s3 = "Intermediate";
            bool b = s1.Contains(s1);
            bool c = s2.Contains(s2);
            bool d = s3.Contains(s3);
            if ((b) || (c) || (d))
            {

            }

            return s;
        }
    }
}
