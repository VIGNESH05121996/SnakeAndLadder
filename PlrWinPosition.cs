﻿using System;

namespace SnakeAndLadder
{
    class PlrWinPosition
    {
        public const int NOPLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        static void Main(string[] args)
        {
            int position = 0;
            Console.WriteLine("Game is played by single player");
            Console.WriteLine("Player Start Position is:" + position);

            while (position < 100 )
            {
                Random random = new Random();
                int die = random.Next(1, 7);
                Console.WriteLine("\nNumber Obtained on Die is:" + die);

                Random randoms = new Random();
                int option = randoms.Next(0, 3);
                Console.WriteLine("Player Option Is:" + option);

                if (option == NOPLAY)
                {
                    Console.WriteLine("NOPLAY:" + NOPLAY);
                    Console.WriteLine("NOPLAY: Player Is In Same Position:" + position);
                }
                else if (option == LADDER)
                {
                    Console.WriteLine("LADDER:" + LADDER);
                    position = die + position;
                    Console.WriteLine("LADDER: Proceed With Ladder and Move Forward Upto " + position);
                }
                else if (option == SNAKE)
                {
                    Console.WriteLine("SNAKE:" + SNAKE);
                    position = position - die ;
                    Console.WriteLine("SNAKE: Bitten By Snake and Move Down upto " + position);
                }

            }
        }
    }
}
