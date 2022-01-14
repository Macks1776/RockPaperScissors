using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace RockPaperScissorsConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerInput;
            int randomInt;
            bool playAgain = true;
            string playerResponse;

            while(playAgain)
            {
                int playerScore = 0;
                int cpuScore = 0;

                while (playerScore < 3 && cpuScore < 3)
                {
                    Console.Write("CHOOSE ROCK, PAPER, OR SCISSORS:  ");
                    playerInput = Console.ReadLine();
                    playerInput = playerInput.ToUpper();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch(randomInt)
                    {
                        case 1:
                            Console.WriteLine("CPU chose ROCK");
                            if(playerInput == "ROCK")
                            {
                                Console.WriteLine("DRAW!!");
                                Console.WriteLine("Score: Player {0} - {1}", playerScore, cpuScore);
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!");
                                playerScore++;
                                Console.WriteLine("Score: Player {0} - {1}", playerScore, cpuScore);
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!");
                                cpuScore++;
                                Console.WriteLine("Score: Player {0} - {1}", playerScore, cpuScore);
                            }
                            break;

                        case 2:
                            Console.WriteLine("CPU chose PAPER");
                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("CPU WINS");
                                cpuScore++;
                                Console.WriteLine("Score: Player {0} - {1}", playerScore, cpuScore);
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("DRAW!!");
                                Console.WriteLine("Score: Player {0} - {1}", playerScore, cpuScore);
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!");
                                playerScore++;
                                Console.WriteLine("Score: Player {0} - {1}", playerScore, cpuScore);
                            }
                            break;

                        case 3:
                            Console.WriteLine("CPU chose SCISSORS");
                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS");
                                playerScore++;
                                Console.WriteLine("Score: Player {0} - {1}", playerScore, cpuScore);
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!");
                                cpuScore++;
                                Console.WriteLine("Score: Player {0} - {1}", playerScore, cpuScore);
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!");
                                Console.WriteLine("Score: Player {0} - {1}", playerScore, cpuScore);
                            }
                            break;
                    }
                    
                    if(playerScore == 3 || cpuScore == 3)
                    {
                        Console.WriteLine("Final Score: Player {0} - {1}", playerScore, cpuScore);
                        Console.WriteLine("DO YOU WANT TO PLAY AGAIN?? YES OR NO");
                        playerResponse = Console.ReadLine();
                        playerResponse = playerResponse.ToUpper();

                        if(playerResponse == "YES")
                        {
                            playAgain = true;
                            Console.Clear();
                        }
                        else if (playerResponse == "NO")
                        {
                            playAgain = false;
                            Console.Clear();
                        }
                    }


                }
            }
        }
    }
}
