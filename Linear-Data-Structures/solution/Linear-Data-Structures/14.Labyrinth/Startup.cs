namespace _14.Labyrinth
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var labyrinth = new Labyrinth(SeedLabyrinth());

            labyrinth.CalculateDistance();

            labyrinth.PrintResult();
        }

        private static char[,] SeedLabyrinth()
        {
            return new [,]
            {
                {'0', '0', '0', 'x','0', 'x' },
                {'0', 'x', '0', 'x','0', 'x' },
                {'0', '*', 'x', '0','x', '0' },
                {'0', 'x', '0', '0','0', '0' },
                {'0', '0', '0', 'x','x', '0' },
                {'0', '0', '0', 'x','0', 'x' },
            };
        }
    }
}
