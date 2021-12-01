using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    public class Board {

        char[] game = new char[9]
        {
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9'
        };

        char[] initialGame = new char[9]
        {
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9'
        };

        public void resetGame()
        {
            game[0] = '1';
            game[1] = '2';
            game[2] = '3';
            game[3] = '4';
            game[4] = '5';
            game[5] = '6';
            game[6] = '7';
            game[7] = '8';
            game[8] = '9';
        }

        public void printGame()
        {
            Console.WriteLine("                 " + game[0] + "|" + game[1] + "|" + game[2] + "                 ");
            Console.WriteLine("                 " + game[3] + "|" + game[4] + "|" + game[5] + "                 ");
            Console.WriteLine("                 " + game[6] + "|" + game[7] + "|" + game[8] + "                 ");
        }

        public bool play(User user, int numberChoice)
        {
            if (game[numberChoice] != initialGame[numberChoice])
            {
                Console.WriteLine("Este lugar já está ocupado, pfv escolha outro");
                printGame();
                return false;
            }
            else
            {
                game[numberChoice] = user.Choice;
                win(user);
                printGame();
                return true;
            }

        }

        public bool win(User user)
        {
            if (game[0] == user.Choice && game[1] == user.Choice && game[2] == user.Choice ||
                game[3] == user.Choice && game[4] == user.Choice && game[5] == user.Choice ||
                game[6] == user.Choice && game[7] == user.Choice && game[8] == user.Choice ||
                game[0] == user.Choice && game[3] == user.Choice && game[6] == user.Choice ||
                game[1] == user.Choice && game[4] == user.Choice && game[7] == user.Choice ||
                game[2] == user.Choice && game[5] == user.Choice && game[8] == user.Choice ||
                game[0] == user.Choice && game[4] == user.Choice && game[8] == user.Choice ||
                game[2] == user.Choice && game[4] == user.Choice && game[6] == user.Choice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

