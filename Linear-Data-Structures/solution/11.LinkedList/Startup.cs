namespace _11.LinkedList
{
    /* 11.
    * Implement the data structure linked list. 
    * Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
    * Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
    */

    using System;
    public class Startup
    {
        static void Main()
        {
            var linkedList = new LinkedList<int> { FirstElement = new ListItem<int>(1) };
            linkedList.InsertAfter(linkedList.FirstElement, new ListItem<int>(3));
            linkedList.InsertAfter(linkedList.FirstElement, new ListItem<int>(2));

            Console.WriteLine(linkedList.FirstElement.Value);
            Console.WriteLine(linkedList.FirstElement.NextItem.Value);
            Console.WriteLine(linkedList.FirstElement.NextItem.NextItem.Value);
        }
    }

}
