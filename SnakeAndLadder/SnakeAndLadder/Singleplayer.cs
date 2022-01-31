using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Singleplayer
    {
        int StartPoint = 0, Count = 0;
        const int Ladder = 1, Snake = 2, No_Play = 0, WinningPosition = 100;
        
        Random random = new Random();
        public int Dice()
        {
            Count++;
            return random.Next(1, 7);
        }

        public void StartPlay()
        {
            while (StartPoint < WinningPosition)
            {

                int option = random.Next(0, 3);
                switch (option)
                {

                    case Ladder:
                        if (StartPoint + Dice() < 100)
                        {
                            StartPoint += Dice();
                            Console.WriteLine("Player moves ahead to " + StartPoint);
                        }
                        break;

                    case Snake:
                        if (StartPoint - Dice() >= 0)
                        {
                            StartPoint = StartPoint - Dice();
                            Console.WriteLine("Player moves behind to " + StartPoint);
                        }
                        break;

                    case No_Play:
                        Console.WriteLine("Player is in the same position");
                        break;

                }
                
                if (StartPoint >= 100)
                {     
                    Console.WriteLine("Player Won!");
                }
               
              }
              Console.WriteLine("Exact win position : " +StartPoint);
              Console.WriteLine("Dice rolled : " +Count +" times");
           }       
       }
    }
