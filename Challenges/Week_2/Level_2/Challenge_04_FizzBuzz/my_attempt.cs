using System;

class Program
{
    static void Main()
    {
        for (int number = 1; number <= 100; number++)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Frizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine($"{number}");
            }
        }
    }
}