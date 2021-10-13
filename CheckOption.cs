using System;

namespace SnakeAndLadder
{
    class CheckOption
    {
        public const int NOPLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        static void Main(string[] args)
        {
            int position = 0;
            Console.WriteLine("Game is played by single player");
            Console.WriteLine("Player Start Position is:" + position);

            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine("Number Obtained on Die is:" + die);

            Random randoms = new Random();
            int option = randoms.Next(0, 3);
            Console.WriteLine("\nPlayer Option Is:" + option);

            if(option==NOPLAY)
            {
                Console.WriteLine("NOPLAY:" + NOPLAY);
                Console.WriteLine("\nNOPLAY: Player Is In Same Position" + position);
            }
            else if(option==LADDER)
            {
                Console.WriteLine("LADDER:" + LADDER);
                position = die + position;
                Console.WriteLine("\nLADDER: Proceed With Ladder and Move Up " + position);
            }
            else if(option==SNAKE)
            {
                Console.WriteLine("SNAKE:" + SNAKE);
                position = die - position;
                Console.WriteLine("\nSNAKE: Bitten By Snake and Move Down " + position);
            }


        }
    }
}
