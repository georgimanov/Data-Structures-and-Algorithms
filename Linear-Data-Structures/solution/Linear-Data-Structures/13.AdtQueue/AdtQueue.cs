namespace _13.AdtQueue
{
    using System;
    using System.Collections.Generic;

    /* 13.
     * Implement the ADT queue as dynamic linked list.
     * Use generics (LinkedQueue<T>) to allow storing different data types in the queue.
     */
    public class AdtQueue<T>
    {
        private LinkedList<T> elements;

        public AdtQueue()
        {
            this.elements = new LinkedList<T>();
        }

        public void Enque(T value)
        {
            if (!this.HasElements())
            {
                this.elements.AddFirst(value);
                return;
            }

            this.elements.AddBefore(this.elements.First, value);
        }

        public T Deque()
        {
            if (!this.HasElements())
            {
                throw new ArgumentOutOfRangeException("Queue is empty!");
            }

            var last = this.elements.Last;

            this.elements.RemoveLast();

            return last.Value;
        }

        public bool HasElements()
        {
            return this.elements.Count != 0;
        }
    }
}
