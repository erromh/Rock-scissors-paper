using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            char stop;

            Console.WriteLine("Rock - scissors - paper \n");

            do
            {
                Console.WriteLine("Enter the game element: \n");
                Console.WriteLine(" -> Rock - " + "'0' \n");
                Console.WriteLine(" -> Scissors - " + "'1'\n");
                Console.WriteLine(" -> Paper - " + "'2'");
                Console.WriteLine();

                Console.Write(" -> ");
                string choise = Console.ReadLine();
                Console.WriteLine();

                Winner(choise);
                Console.WriteLine();
                Console.WriteLine("Do you wanna play again ? \n\n" + "Press 'y' to continue \nPress 'Ctrl + c' to stop");

                Console.WriteLine();
                stop = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

            } while (stop == 'y');
        }

        static string Generate_Random()
        {
            string[] player_value = { "0", "1", "2" };

            Random rand = new Random();
            int index = rand.Next(player_value.Length);

            string randThrow = player_value[index];
            return randThrow;
        }

        static string Winner(string player_1)
        {

            string Player_Throw = player_1;
            string PC_Throw = Generate_Random();

            int player_win = 0, PC_win = 0;

            if ((Player_Throw == "0" && PC_Throw == "2") || (Player_Throw == "1" && PC_Throw == "0") || (Player_Throw == "2" && PC_Throw == "1"))
            {   
                player_win++;
                Console.WriteLine("|-----------|");
                Console.WriteLine("| You win ! |" + "\t\t\t Score:\t Player - " + player_win);
                Console.WriteLine("|-----------|" + "\t\t\t\t PC - " + PC_win);
                Console.WriteLine();
                return "Player 1";
            }

            else if ((PC_Throw == "0" && Player_Throw == "2") || (PC_Throw == "1" && Player_Throw == "0") || (PC_Throw == "2" && Player_Throw == "1"))
            {   
                PC_win++;
                Console.WriteLine("|----------|");
                Console.WriteLine("| PC win ! |" + "\t\t\t Score:\t Player - " + player_win);
                Console.WriteLine("|----------|" + "\t\t\t\t PC - " + PC_win);
                Console.WriteLine();
                return "Computer";
            }

            else if (Player_Throw == PC_Throw)
            {
                Console.WriteLine("|--------|");
                Console.WriteLine("| draw ! |" + "\t\t\t Score:\t Player - " + player_win);
                Console.WriteLine("|--------|" + "\t\t\t\t PC - " + PC_win);
                Console.WriteLine();
                return "Draw";
            }

            else
            {
                return "Error";
            }
        }
    }
}
