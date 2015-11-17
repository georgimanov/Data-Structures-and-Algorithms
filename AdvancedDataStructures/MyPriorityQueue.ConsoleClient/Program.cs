namespace MyPriorityQueue.ConsoleClient
{
    using System;
    using System.Linq;
    using MyPriorityQueue;

    public class PriorityQueueExample
    {
        static void Main()
        {
            var people = new MyPriorityQueue<Person>();
            people.Enqueue(new Person("Doncho", 25));
            people.Enqueue(new Person("Niki", 24));
            people.Enqueue(new Person("Ivo", 25));
            people.Enqueue(new Person("Asya", 22));
            people.Enqueue(new Person("Pesho", int.MinValue));

            while (people.Count > 0)
            {
                Console.WriteLine(people.Dequeue());
            }
        }
    }
}
