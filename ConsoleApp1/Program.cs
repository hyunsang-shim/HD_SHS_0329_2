using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            while (i<=6)
            {
                int j = 1;
                while (j<=9)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                    j++;
                }

                Console.WriteLine("");
                i += 2;

            }
        }
    }
}
