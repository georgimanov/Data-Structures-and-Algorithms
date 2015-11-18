namespace Rabbits
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, long>();

            int askedRabbits = int.Parse(Console.ReadLine());

            for (int i = 0; i < askedRabbits; i++)
            {
                string answer = Console.ReadLine();
                if (!dict.ContainsKey(answer))
                {
                    dict.Add(answer, 1);
                }
                else
                {
                    dict[answer]++;
                }
            }

            long sum = 0;

            foreach (var rabbit in dict)
            {
                long answ = long.Parse(rabbit.Key) + 1;

                if (rabbit.Value == 1)
                {
                    sum += answ;
                }
                else
                {
                    var pairs = rabbit.Value / answ;

                    if (rabbit.Value % answ != 0)
                    {
                        pairs++;
                    }

                    sum += pairs * answ;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
