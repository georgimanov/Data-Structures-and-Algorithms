namespace Trees
{
    using System;

    class Program
    {
        static long[,,,,] memo = new long[11, 11, 11, 11, 5];

        static void Main(string[] args)
        {
            memo[0, 0, 0, 0, 0] = 1;
            memo[0, 0, 0, 0, 1] = 1;
            memo[0, 0, 0, 0, 2] = 1;
            memo[0, 0, 0, 0, 3] = 1;

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            var answer = PlaceTrees(a, b, c, d, 4);

            Console.WriteLine(answer);
        }

        static long PlaceTrees(int a, int b, int c, int d, int lasttype)
        {
            if (memo[a, b, c, d, lasttype] > 0)
            {
                return memo[a, b, c, d, lasttype];
            }

            long count = 0;

            if (a > 0 && lasttype != 0)
            {
                count += PlaceTrees(a - 1, b, c, d, 0);
            }

            if (b > 0 && lasttype != 1)
            {
                count += PlaceTrees(a, b - 1, c, d, 1);
            }

            if (c > 0 && lasttype != 2)
            {
                count += PlaceTrees(a, b, c - 1, d, 2);
            }

            if (d > 0 && lasttype != 3)
            {
                count += PlaceTrees(a, b, c, d - 1, 3);
            }

            memo[a, b, c, d, lasttype] = count;

            return count;
        }
    }
}
