using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Singleplayer
    {
        public int StartPoint = 0; 
        public int Dice;
        public void StartPlay()
        {
            Random random = new Random(); 
            Dice = random.Next(1, 7); 
            Console.WriteLine("Player Role......");
            Console.WriteLine("Dice number is : " + Dice);
        }
    }
}
