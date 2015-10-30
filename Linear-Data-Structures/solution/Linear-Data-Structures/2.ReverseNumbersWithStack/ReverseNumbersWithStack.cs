namespace _2.ReverseNumbersWithStack
{
    using System;
    using System.Collections.Generic;
    
    /* 2.
     * Write a program that reads N integers from theconsole and reverses them using a stack. 
     * Use the Stack<int> class.
     */
    class ReverseNumbersWithStack
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of integers (N) = ");
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("[" + i + "] = ");
                int number = int.Parse(Console.ReadLine());
                stack.Push(number);
            }

            int index = 0;
            while (stack.Count > 0)
            {
                int result = stack.Pop();
                Console.WriteLine("[{0}] = {1}", index++, result);
            }
        }
    }
}
