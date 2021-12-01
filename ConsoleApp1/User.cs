using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    public class User {

        private string name;
        private char choice;
        private int score;

        public User()
        {

        }

        public User(string name , char choice, int score)
        {
            this.name = name;
            this.choice = choice;
            this.score = score;
        }

        public string Name { 
            get { return name; }
            set { name = value; }
        }
        public char Choice { get { return choice; } set { choice = value; } } 

        public int Score { get { return score; } set => score = value; }

    }
}
