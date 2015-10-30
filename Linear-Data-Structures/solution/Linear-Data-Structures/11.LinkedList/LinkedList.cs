namespace _11.LinkedList
{
    /* 11.
    * Implement the data structure linked list. 
    * Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
    * Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
    */
    public class LinkedList<T>
    {
        public LinkedList()
        {
            this.FirstElement = null;
        }

        public ListItem<T> FirstElement { get; set; }

        public void InsertAfter(ListItem<T> insertAfterItem, ListItem<T> newItem)
        {
            if (insertAfterItem.NextItem == null)
            {
                insertAfterItem.NextItem = newItem;
                return;
            }

            insertAfterItem.NextItem.Value = newItem.Value;
            insertAfterItem.NextItem.NextItem = newItem.NextItem;

            insertAfterItem.NextItem.NextItem =
                new ListItem<T>(insertAfterItem.NextItem.Value)
                {
                    NextItem = insertAfterItem.NextItem.NextItem
                };
        }
    }
}
