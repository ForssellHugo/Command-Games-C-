using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Console_app
{
    internal class TicTacToe
    {
        static void TicHelp()
        {
            Console.WriteLine("Avalible comands:");
            Console.WriteLine("rules -  NYI");
            Console.WriteLine("stop - NYI");
            Console.WriteLine("start - Starts game");
        }
        static void TicRules()
        {
            Console.WriteLine("RULES:");
            Console.WriteLine("NYI");
        }
        public static void StartTicTacToe()
        {
            string comand;
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("Type 'start' to start the game, or 'rules' to list the rules, Good luck! ");

            do
            {
                Console.Write("> ");
                comand = Console.ReadLine();
                switch (comand)
                {
                    case "stop":
                        break;
                    case "start":
                        TicStartGame();
                        break;
                    case "help":
                        TicHelp();
                        break;
                    case "rules":
                        TicRules();
                        break;
                    default:
                        Console.WriteLine($"'{comand}' is not a valid comand, type 'help' to get comands or 'stop' to exit game!");
                        break;
                }
            
            }
            while (comand != "stop");
        }
        public static void TicStartGame()
        {


        }
    }
}
