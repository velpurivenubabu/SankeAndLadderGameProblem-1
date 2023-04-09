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
            Random random = new Random();
            int DieNumber=random.Next(1,7);
            Console.WriteLine(DieNumber);
            //UC3 Setting Options For the Game(NoPlay, Ladd);
            Random random1 = new Random();
            int playerOption = random1.Next(0, 3);
            const int SNAKE = 1;
            const int LADDER = 2;
            Console.WriteLine(playerOption);
            Console.WriteLine(playerPosition);
            switch (playerOption)
            {
                case LADDER:
                   playerPosition += DieNumber; // If ladder comes player position will be incremented;
                    
                    break;
                case SNAKE:
                    
                    playerPosition -= DieNumber; // If Snake comes player position will be decremented;
                    
                    break;
                default:
                    playerPosition = playerPosition; // If Noplay comes player should stay on the Same position;
                    break;
            }
            Console.WriteLine(playerPosition);   
            Console.WriteLine("Welcome To Snake Ladder Game!");
        }
    }
}