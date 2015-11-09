namespace FibonacciFuck
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        const int MOD = 1000000007;

        const ulong max = 100000000000000000;

        const string filePath = "result.txt";

        static void Main(string[] args)
        {
            var queue = new Queue<ulong>();

            ulong a = 0;
            ulong b = 1;
            for (ulong i = 1; i <= max; i++)
            {
                ulong temp = a;
                a = b;
                b = (temp + b) % MOD;

                queue.Enqueue(a);

                if (i % 100 == 0)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
                    {
                        while (queue.Count > 0)
                        {
                            file.Write("{0}, ", queue.Dequeue());
                        }
                        file.WriteLine();
                    }
                }
            }
        }
    }
}