namespace Fibonacci
{
    using System;

    public class Startup
    {
        const int MOD = 1000000007;

        public static long Fibonacci(long n)
        {
            long a = 0;
            long b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = (temp + b) % MOD;
            }
            return a;
        }

        static long PowMod(long a, long p)
        {
            if (p == 0)
            {
                return 1;
            }

            if (p % 2 == 1)
            {
                return PowMod(a, p - 1) * a % MOD;
            }

            a = PowMod(a, p / 2);

            return a * a % MOD;
        }

        static void Main()
        {
            long input = 100000000000000000;
            Console.WriteLine(6);

            // int n = int.Parse(Console.ReadLine());

            // Console.WriteLine(PowMod(2, 30));
        }
    }
}
