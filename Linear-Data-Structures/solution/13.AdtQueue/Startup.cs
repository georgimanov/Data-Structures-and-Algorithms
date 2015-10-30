namespace _13.AdtQueue
{
    using System;

    /* 13.
     * Implement the ADT queue as dynamic linked list.
     * Use generics (LinkedQueue<T>) to allow storing different data types in the queue.
     */
    class Startup
    {
        private const int SomeValue = 10;

        static void Main(string[] args)
        {

            var queue = new AdtQueue<int>();

            for (int i = 0; i < SomeValue; i++)
            {
                queue.Enque(i);
                Console.WriteLine("Enque [{0}]", i);
            }

            for (int i = 0; i < SomeValue; i++)
            {
                var current = queue.Deque();
                Console.WriteLine("Dequeue [{0}]", current);
            }
        }
    }

}
