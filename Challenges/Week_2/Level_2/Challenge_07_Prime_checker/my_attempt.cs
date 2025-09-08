using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int n = 2; n <= (number - 1); n++)
            {
                if (number % n == 0)
                {
                    isPrime = false;
                    break;
                }
                else if (number % 1 == 0 && number % n == 0)
                {
                    isPrime = true;
                    break;
                }
            }
        }
        if (isPrime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
    }
}