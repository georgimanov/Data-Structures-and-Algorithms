namespace Test
{
    using System;
    using System.Collections.Generic;

    class HelpingProgram
    {
        private const int StartNumber = 2;

        public static void Main()
        {
            var numbersQueue = new Queue<int>();
            var counter = 0;

            numbersQueue.Enqueue(StartNumber);

            while (counter < 50)
            {
                var number = numbersQueue.Dequeue();
                Console.WriteLine("Number {0}: {1}", counter + 1, number);
                counter++;

                numbersQueue.Enqueue(number + 1);
                numbersQueue.Enqueue(2 * number + 1);
                numbersQueue.Enqueue(number + 2);
            }
        }
    }
}
