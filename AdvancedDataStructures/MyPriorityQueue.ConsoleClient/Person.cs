namespace MyPriorityQueue.ConsoleClient
{
    using System;

    public class Person : IComparable<Person>
    {
        string Name
        {
            get; set;
        }

        int Age
        {
            get; set;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person other)
        {
            return this.Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Name, Age);
        }
    }
}
