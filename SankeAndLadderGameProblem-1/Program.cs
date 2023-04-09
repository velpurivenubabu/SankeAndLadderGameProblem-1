using System;

namespace SankeAndLadderGameProblem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1 Initilizing initialPosition,finalPosition,playerInitialPosition
            int initialPosition = 0;
            int finalPosition = 100;
            int playerPosition = initialPosition;
            int DieCount = 0;
            Console.WriteLine("Welcome To Snake Ladder Game!");
            while (playerPosition < finalPosition)
            {
                DieCount++;
                Random random = new Random();
                int DieNumber = random.Next(1, 7);
                Console.WriteLine("DieNumber : "+ DieNumber);
                //UC3 Setting Options For the Game(NoPlay, Ladd);
                Random random1 = new Random();
                int playerOption = random1.Next(0,4);
                const int SNAKE = 1;
                const int LADDER = 2;
                const int noPlay = 0;
                Console.WriteLine("PlayerOption : " + playerOption);
                //Console.WriteLine("playerPosition : " + playerPosition);
                switch (playerOption)
                {
                    case LADDER:
                        playerPosition += DieNumber; // If ladder comes player position will be incremented;
                        if (playerPosition > finalPosition) // This If condition executed When ever player position More than 100 and sets previous value if the die number is more than required number
                        {
                            playerPosition -= DieNumber; // seting player position to previous position
                        }
                        break;
                    case SNAKE:
                        playerPosition -= DieNumber; // If Snake comes player position will be decremented;
                        if (playerPosition < initialPosition) // This If condition executed When ever player position less than 0 and sets Value player initial value zero;
                        {
                            playerPosition = initialPosition; 
                        }

                        break;
                    case noPlay:
                        playerPosition = playerPosition; // If Noplay comes player should stay on the Same position;
                        break;

                    default:
                        playerPosition += DieNumber;
                        if (playerPosition > finalPosition) // This If condition executed When ever player position More than 100 and sets previous value if the die number is more than required number
                        {
                            playerPosition -= DieNumber; // seting player position to previous position
                        }

                        break;
                }
                Console.WriteLine("playerPosition : " + playerPosition);

            }
            Console.WriteLine("DieCount : " + DieCount);
            Console.WriteLine("Player Final Position : " + playerPosition + " And Die Rolled For " + DieCount + " Times");
            
        }
    }
}