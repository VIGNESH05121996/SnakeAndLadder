using System;

namespace SnakeAndLadder
{
    class PlrRollDie
    {
        
        static void Main(string[] args)
        {

            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine("Number Obtained on Die is:" + die);

        }
    }
}
