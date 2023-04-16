using System;
using System.Security.Cryptography.X509Certificates;

namespace SankeAndLadderGameProblem_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //UC1 Initilizing initialPosition,finalPosition,playerInitialPosition
            int initialPosition = 0;
            int finalPosition = 100;
            int player1 = initialPosition;
            int player2 = initialPosition;
            int dieCount = 0;
            bool extraChance1 = false;
            bool extraChance2 = false;
            void roalTheDieForPlayer1()
            {
                Random random1 = new Random();
                int dieNumber1 = random1.Next(1, 7);
                Console.WriteLine("DieNumber For Player1 :" + dieNumber1);//DieNumber For Player2 
                //UC3 Setting Options For the Game(NoPlay, Ladd);
                Random randomA = new Random();
                int playerOption1 = randomA.Next(0, 4);
                const int SNAKE = 1;
                const int LADDER = 2;
                const int noPlay = 0;
                Console.WriteLine("player1Option : " + playerOption1);
                switch (playerOption1)
                {
                    case LADDER:

                        player1 += dieNumber1;// If ladder comes player position will be incremented;
                        if (player1 > finalPosition) // This If condition executed When ever player position More than 100 and sets previous value if the die number is more than required number
                        {
                            player1 -= dieNumber1;//Setting player positionto previous position
                        }
                        extraChance1 = true;
                        Console.WriteLine("player1: " + player1);
                        break;

                    case SNAKE:
                        player1 -= dieNumber1; // If Snake comes player position will be decremented;
                        if (player1 < initialPosition) // This If condition executed When ever player position less than 0 and sets Value player initial value zero;
                        {
                            player1 = initialPosition;
                        }
                        extraChance1 = false;
                        Console.WriteLine("player1: " + player1);
                        break;
                    case noPlay:
                        player1 = player1; // If Noplay comes player should stay on the Same position;
                        Console.WriteLine("player1: " + player1);
                        extraChance1 = false;
                        break;

                    default:
                        player1 += dieNumber1;
                        if (player1 > finalPosition) // This If condition executed When ever player position More than 100 and sets previous value if the die number is more than required number
                        {
                            player1 -= dieNumber1; // seting player position to previous position
                        }
                        extraChance1 = false;
                        Console.WriteLine("player1: " + player1);
                        break;
                }
            }
            void roalTheDieForPlayer2()
            {
                Random random2 = new Random();
                int dieNumber2 = random2.Next(1, 7);
                Console.WriteLine("DieNumber For Player2 :" + dieNumber2);
                Random randomB = new Random();
                int playerOption2 = randomB.Next(0, 4);
                const int SNAKE1 = 1;
                const int LADDER1 = 2;
                const int noPlay1 = 0;
                Console.WriteLine("Player2Option : " + playerOption2);
                switch (playerOption2)
                {
                    case LADDER1:

                        player2 += dieNumber2;// If ladder comes player position will be incremented;
                        if (player2 > finalPosition) // This If condition executed When ever player position More than 100 and sets previous value if the die number is more than required number
                        {
                            player2 -= dieNumber2;//Setting player positionto previous position
                        }
                        extraChance2 = true;
                        Console.WriteLine("player2: " + player2);
                        break;

                    case SNAKE1:
                        player2 -= dieNumber2; // If Snake comes player position will be decremented;
                        if (player2 < initialPosition) // This If condition executed When ever player position less than 0 and sets Value player initial value zero;
                        {
                            player2 = initialPosition;
                        }
                        extraChance2 = false;
                        Console.WriteLine("player2: " + player2);
                        break;
                    case noPlay1:
                        player2 = player2; // If Noplay comes player should stay on the Same position;
                        Console.WriteLine("player2: " + player2);
                        extraChance2 = false;
                        break;

                    default:
                        player2 += dieNumber2;
                        if (player2 > finalPosition) // This If condition executed When ever player position More than 100 and sets previous value if the die number is more than required number
                        {
                            player2 -= dieNumber2; // seting player position to previous position
                        }
                        extraChance2 = false;
                        Console.WriteLine("player2: " + player2);
                        break;


                }
            }
            Console.WriteLine("Welcome To Snake Ladder Game!");
            while ((player1 < finalPosition) && (player2 < finalPosition))
            {
                dieCount++;
                roalTheDieForPlayer1();
                if (extraChance1)
                {
                    Console.Write("Extrachance ");
                    roalTheDieForPlayer1();
                }
                roalTheDieForPlayer2();
                if (extraChance2)
                {
                    Console.Write("Extrachance ");
                    roalTheDieForPlayer2();
                }

            }
            Console.WriteLine("DieCount : " + dieCount); // This If condition finds the Winner among Two Players
            if (player1 == finalPosition)
            {
                Console.WriteLine("Winner is Player1 and Die count is " + dieCount + " Times");
            }
            else
            {
                Console.WriteLine("Winner is Player2 and die count is " + dieCount + " Times");
            }
        }
    }
}