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
            int player1= initialPosition;
            int player2= initialPosition;
            int DieCount = 0;
            Console.WriteLine("Welcome To Snake Ladder Game!");
            while ((player1 < finalPosition) || (player1 < finalPosition))
            {
                DieCount++;
                Random random1= new Random();
                int DieNumber1= random1.Next(1, 7);
                Console.WriteLine("DieNumber For Player1 :" + DieNumber1);//DieNumber For Player2
                Random random2= new Random();
                int DieNumber2= random2.Next(1, 7);
                Console.WriteLine("DieNumber For Player2 :" + DieNumber2);
                //UC3 Setting Options For the Game(NoPlay, Ladd);
                Random randomA= new Random();
                int playerOption1= randomA.Next(0,4);
                const int SNAKE = 1;
                const int LADDER = 2;
                const int noPlay = 0; 
                Console.WriteLine("Player 1 : "+ playerOption1);
                Random randomB= new Random();
                int playerOption2= randomB.Next(0,4);
                const int SNAKE1 =1;
                const int LADDER1 = 2;
                const int noPlay1 = 0;
                Console.WriteLine("Player 2 : " + playerOption2);
                //Console.WriteLine("playerPosition : " + playerPosition);
                switch (playerOption1)
                {
                    case LADDER:
                        player1 += DieNumber1;// If ladder comes player position will be incremented;
                        if (player1> finalPosition) // This If condition executed When ever player position More than 100 and sets previous value if the die number is more than required number
                        {
                            player1 -= DieNumber1;//Setting player positionto previous position
                        }
                        break;
                       
                    case SNAKE:
                        player1 -= DieNumber1; // If Snake comes player position will be decremented;
                        if (player1 < initialPosition) // This If condition executed When ever player position less than 0 and sets Value player initial value zero;
                        {
                            player1 = initialPosition; 
                        }

                        break;
                    case noPlay:
                        player1 = player1; // If Noplay comes player should stay on the Same position;
                        break;

                    default:
                        player1 += DieNumber1;
                        if (player1 > finalPosition) // This If condition executed When ever player position More than 100 and sets previous value if the die number is more than required number
                        {
                             player1 -= DieNumber1; // seting player position to previous position
                        }

                        break;
                }
                switch (playerOption2)
                {
                    case LADDER1:
                        player2+= DieNumber1;// If ladder comes player position will be incremented;
                        if (player2 > finalPosition) // This If condition executed When ever player position More than 100 and sets previous value if the die number is more than required number
                        {
                            player2 -= DieNumber2;//Seting player positionto previous position
                        }
                        break;
                    case SNAKE1:
                        player2 -= DieNumber2; // If Snake comes player position will be decremented;
                        if (player2 < initialPosition) // This If condition executed When ever player position less than 0 and sets Value player initial value zero;
                        {
                            player2 = initialPosition;
                        }

                        break;
                    case noPlay1:
                        player2 = player2;//If Noplay comes player should stay on the Same position;
                        break;

                    default:
                        player2 += DieNumber2;
                        if (player2 > finalPosition) // This If condition executed When ever player position More than 100 and sets previous value if the die number is more than required number
                        {
                            player2 -= DieNumber2;//seting player position to previous position
                        }

                        break;
                }
                Console.WriteLine("player1: " + player1);
                Console.WriteLine("player2: "+ player2);

            }
            Console.WriteLine("DieCount : " + DieCount);
            if (player1==finalPosition)
            {
                Console.WriteLine("Winner is Player1 and Die count is " + DieCount + " Times");
            }
            else
            {
                Console.WriteLine("Winner is Player2 and die count is " + DieCount + " Times");
            }
            
            
        }
    }
}