namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static List<Person> list = new List<Person>
            {
                new Person("a", 15),
                new Person("b", 14),
                new Person("c", 15),
                new Person("d", 13),
                new Person("e", 15),
            };

        static void Main(string[] args)
        {
            var elements = GetAdults();

            Console.WriteLine("Adults");
            foreach (var item in elements)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }

            Console.WriteLine();
            Console.WriteLine("UnderAge");
            var underage = UnderAge();

            foreach (var item in underage)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }

        public static IEnumerable<Person> GetAdults()
        {
            return GetAll(p => p.Age >= 18);
        }

        public static IEnumerable<Person> UnderAge()
        {
            return GetAll(p => p.Age < 18);
        }

        public static IEnumerable<Person> GetAll(Func<Person, bool> func)
        {
            return list
                .Where(func)
                .OrderBy(p => p.Name)
                .OrderBy(p => p.Age)
                .ToList();
        }
    }
}
