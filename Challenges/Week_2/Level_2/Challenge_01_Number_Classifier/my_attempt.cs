using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (number > 0 && number % 2 == 0)
        {
            Console.WriteLine("Positive and Even");
        }
        else if (number > 0 && number % 2 != 0)
        {
            Console.WriteLine("Positive and Odd");
        }
        else if (number < 0 && number % 2 == 0)
        {
            Console.WriteLine("Negative and Even");
        }
        else if (number < 0 && number % 2 != 0)
        {
            Console.WriteLine("Negative and Odd");
        }
    }
}