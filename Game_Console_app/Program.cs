using System.Data;

namespace Game_Console_app
{
    internal class Program
    {
        static void PrintGames()
        {
            Console.WriteLine("These are all the games that is avalible:");
            Console.WriteLine("Tic-Tac-Toe  - In Progress");   //NYI
            Console.WriteLine("Hangman      - NYI");       //NYI
            Console.WriteLine("Yatzee       - NYI");        //NYI
            Console.WriteLine("Maze game    - NYI");     //NYI
            //TODO: When done, more games to implement
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hugo's game center!");
            Console.WriteLine("Type 'help' for commands, or 'list' to list all games avalible");
            string comand;
            string[] cmd;

            while (true)
            {
                Console.Write("> ");
                comand = Console.ReadLine();
                cmd = comand.Split();
                //TODO: Refactor
                //FIXME: Input error handling
                if (cmd[0] == "quit") break;
                else if (cmd[0] == "start")
                {
                    if (cmd[1] == "tic-tac-toe")
                    {
                        Console.WriteLine("NYI - Tic-Tac-Toe");
                    }
                }
                else if (cmd[0] == "list") Console.WriteLine("NYI - List all games avalible");
                else if (cmd[0] == "help") PrintGames();
                else Console.WriteLine($"{comand} is not a valid comand, type 'help' to get all the avalible commands");
            }
        }
    }
}
