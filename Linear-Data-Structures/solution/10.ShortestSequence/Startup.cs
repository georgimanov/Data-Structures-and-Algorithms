namespace _10.ShortestSequence
{
    using System;
    using System.Collections;

    /* 10.
     * We are given numbers N and M and the following operations:
     * N = N+1
     * N = N+2
     * N = N*2
     * Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
     * Hint: use a queue.
     * Example: N = 5, M = 16
     * Sequence: 5 → 7 → 8 → 16
     */
    class Startup
    {
        static void Main(string[] args)
        {
            const int start = 100;
            const int end = 1000;

            var stack = new Stack();
            stack.Push(end);

            var current = end;
            while (true)
            {
                var n1 = current / 2;
                var n2 = current - 2;
                var n3 = current - 1;

                if (n1 == start && current % 2 == 0)
                {
                    stack.Push(n1);
                    break;
                }

                if (n2 == start)
                {
                    stack.Push(n2);
                    break;
                }

                if (n3 == start)
                {
                    stack.Push(n3);
                    break;
                }

                if (current / 2 > start)
                {
                    if (current % 2 != 0)
                    {
                        current -= 1;
                        stack.Push(current);
                        continue;
                    }

                    current /= 2;
                    stack.Push(current);
                }
                else if (current - 2 > start)
                {
                    current -= 2;
                    stack.Push(current);
                }
                else
                {
                    current -= 1;
                    stack.Push(current);
                }
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Count != 1 ? "{0} -> " : "{0}", stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
