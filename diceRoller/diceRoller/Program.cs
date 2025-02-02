using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceRoller
{
    internal class Program
    {
        static int playerRandomNum; // made static
        static int enemyRandom;
        static int playerPoints = 0;
        static int enemyPoints = 0;
        static Random random = new Random(); // made static
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to proceed");
                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("you've rolled a dice: " + playerRandomNum);

                Console.WriteLine("....");
                System.Threading.Thread.Sleep(1000);
                enemyRandom = random.Next(1, 7);
                Console.WriteLine("enemy rolled a dice: " + enemyRandom);

                /*if(playerRandomNum == enemyRandom)
                {
                    Console.WriteLine("draw");
                }else if(playerRandomNum > enemyRandom)
                {
                    Console.WriteLine("player wins");
                }
                else
                {
                    Console.WriteLine("enemy wins");
                }
                */
                if (playerRandomNum > enemyRandom)
                {
                    playerPoints++; // increment playerPoints
                }
                else if (playerRandomNum < enemyRandom)
                {
                    enemyPoints++; // increment enemyPoints
                }
                else if (playerRandomNum == enemyRandom)
                {
                    continue;
                }
                Console.WriteLine("playerPoints: " + playerPoints); // corrected variables
                Console.WriteLine("enemyPoints: " + enemyPoints); // corrected variables

                Console.ReadKey();
            }
        }
    }
}


