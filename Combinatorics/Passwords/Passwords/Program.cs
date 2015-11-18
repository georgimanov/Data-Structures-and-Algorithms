namespace Passwords
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input = "**************************************************";

            int count = input.Count(ch => ch == '*');

            long result = (long)Math.Pow(2, count);

            Console.WriteLine(result);
        }
    }
}
