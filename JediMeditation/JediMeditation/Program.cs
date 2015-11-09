namespace JediMeditation
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(new[] { ' ' });

            List<string> m = new List<string>();
            List<string> k = new List<string>();
            List<string> p = new List<string>();

            for (int i = 0; i < n; i++)
            {
                if (arr[i][0] == 'm')
                {
                    m.Add(arr[i]);
                }

                if (arr[i][0] == 'k')
                {
                    k.Add(arr[i]);
                }

                if (arr[i][0] == 'p')
                {
                    p.Add(arr[i]);
                }
            }

            Console.Write(string.Join(" ", m));
            Console.Write(" ");
            Console.Write(string.Join(" ", k));
            Console.Write(" ");
            Console.Write(string.Join(" ", p));
        }
    }
}
