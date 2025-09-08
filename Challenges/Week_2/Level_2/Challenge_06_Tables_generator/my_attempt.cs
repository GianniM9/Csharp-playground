using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        for (int multiplier = 1; multiplier <= 10; multiplier++)
        {
            int result = number * multiplier;
            Console.WriteLine($"{number} x {multiplier} = {result}");
        }
    }
}