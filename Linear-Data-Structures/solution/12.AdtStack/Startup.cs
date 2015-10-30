namespace _12.AdtStack
{
    using System;

    /* 12.
     * Implement the ADT stack as auto-resizable array.
     * Resize the capacity on demand (when no space is available to add / insert a new element).
     */

    public class Startup
    {
        static void Main()
        {
            AdtStack<int> stack = new AdtStack<int>();

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
                Console.WriteLine("Push: [{0}]", i);
            }

            for (int i = 0; i < 10; i++)
            {
                var current = stack.Pop();
                Console.WriteLine("Pop: [{0}]", current);
            }
        }
    }
}
