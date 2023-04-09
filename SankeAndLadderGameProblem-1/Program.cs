namespace SankeAndLadderGameProblem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1 Initilizing initialPosition,finalPosition,playerInitialPosition
            int initialPosition = 0;
            int finalPosition = 100;
            int playerInitialPosition = initialPosition;
            Random random = new Random();
            int DieNumber=random.Next(1,7);
            Console.WriteLine(DieNumber);
            Console.WriteLine("Welcome To Snake Ladder Game!");
        }
    }
}