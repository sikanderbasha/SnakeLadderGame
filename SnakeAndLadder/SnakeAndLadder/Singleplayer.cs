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
        public void StartPlay()
        {
            Console.WriteLine("Game Started!"); 

            Console.WriteLine("You are at " + StartPoint);
        }
    }
}
