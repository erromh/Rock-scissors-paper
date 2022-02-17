using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            char stop;
            int player_win = 0, PC_win = 0, draw = 0;
            

            Console.WriteLine("Rock - scissors - paper \n");

            do
            {
                Console.WriteLine("Enter the game element: \n");
                Console.WriteLine(" -> Rock - " + "'0' \n");
                Console.WriteLine(" -> Scissors - " + "'1'\n");
                Console.WriteLine(" -> Paper - " + "'2'");
                Console.WriteLine();

                Console.Write(" -> ");
                string Player_Throw = Console.ReadLine();
                Console.WriteLine();
                
                string PC_Throw = Get_RandomNumber();

                if ((Player_Throw == "0" && PC_Throw == "2") || (Player_Throw == "1" && PC_Throw == "0") || (Player_Throw == "2" && PC_Throw == "1"))
                {
                    Console.WriteLine("|-----------|");
                    Console.WriteLine("| You win ! |");
                    Console.WriteLine("|-----------|");
                    Console.WriteLine();
                    player_win++;
                }

                else if ((PC_Throw == "0" && Player_Throw == "2") || (PC_Throw == "1" && Player_Throw == "0") || (PC_Throw == "2" && Player_Throw == "1"))
                {
                    Console.WriteLine("|----------|");
                    Console.WriteLine("| PC win ! |");
                    Console.WriteLine("|----------|");
                    Console.WriteLine();
                    PC_win++;
                }

                else if (Player_Throw == PC_Throw)
                {
                    Console.WriteLine("|--------|");
                    Console.WriteLine("| Draw ! |");
                    Console.WriteLine("|--------|");
                    Console.WriteLine();
                    draw++;
                }

                Console.WriteLine();
                Console.WriteLine("Do you wanna play again ? \n\n" + "Press 'y' to continue \nPress 'n' to stop");

                Console.WriteLine();
                stop = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Score : \nPlayer - " + player_win + "\n" + "PC - " + PC_win + "\n" + "Draw - " + draw + "\n");

            } while (stop == 'y');

        }
        static string Get_RandomNumber()
        {
            string[] player_value = { "0", "1", "2" };

            Random rand = new Random();
            int index = rand.Next(player_value.Length);

            string randThrow = player_value[index];
            return randThrow;
        } 

    }

}
