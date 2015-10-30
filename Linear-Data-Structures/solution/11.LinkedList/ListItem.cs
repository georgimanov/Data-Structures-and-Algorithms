namespace _11.LinkedList
{
    /* 11.
     * Implement the data structure linked list. 
     * Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
     * Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
     */
    public class ListItem<T>
    {
        public ListItem(T value)
        {
            this.Value = value;
            this.NextItem = null;
        }

        public T Value { get; set; }
        public ListItem<T> NextItem { get; set; }
    }
}
