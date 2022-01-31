using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Singleplayer
    {
        int StartPoint = 0;
        const int Ladder = 1, Snake = 2, No_Play = 0;
        
        Random random = new Random();
        public int Dice()
        {
            return random.Next(1, 7);
        }

        public void StartPlay()
        {
            int option = random.Next(0, 3);
            Console.WriteLine("Player Role......");
            switch (option)
            {
                
                case Ladder:
                    StartPoint += Dice();
                    Console.WriteLine("Player moves ahead by " + StartPoint);
                    break;
                case Snake:
                    StartPoint -= Dice();
                    Console.WriteLine("Player moves behind by " + StartPoint);
                    break;
                case No_Play:
                    Console.WriteLine("Player is in the same position");
                    break;
                default:
                    break;
            }

        }
    }
}
