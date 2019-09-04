using System;

namespace FizzBuzzStrategy
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzFactory.Create().Echo(i));
            }

            Console.ReadKey();
        }
    }
}
