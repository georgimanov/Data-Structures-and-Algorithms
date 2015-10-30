namespace _12.AdtStack
{
     /* 12.
     * Implement the ADT stack as auto-resizable array.
     * Resize the capacity on demand (when no space is available to add / insert a new element).
     */

    using System;
    using System.Linq;

    public class AdtStack<T>
    {
        private const int InitialStackSize = 4;

        private T[] elements;

        private int topIndex;

        public AdtStack()
        {
            this.elements = new T[InitialStackSize];
            this.topIndex = 0;
        }

        public void Push(T value)
        {
            if (this.IsFull())
            {
                var elementsNew = new T[this.elements.Count()*2];

                for (int i = 0; i < this.elements.Count(); i++)
                {
                    elementsNew[i] = this.elements[i];
                }

                this.elements = elementsNew;
            }

            this.elements[this.topIndex++] = value;
        }

        public T Pop()
        {
            if (this.topIndex < 0)
            {
                throw new ArgumentException("Stack is empty");
            }

            return this.elements[--this.topIndex];
        }

        public T Peek()
        {
            return this.elements[this.topIndex];
        }

        private bool IsFull()
        {
            return this.elements.Count() == this.topIndex;
        }
    }
}