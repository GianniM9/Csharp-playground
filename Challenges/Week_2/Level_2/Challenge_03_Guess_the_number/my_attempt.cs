using System;

class Program
{
    static void Main()
    {
        var random = new Random();
        int secretNumber = random.Next(1, 101);
        int guessedNumber = -1;
        int attempt = 0;
        while (guessedNumber != secretNumber)
        {
            Console.Write("Guess the number: ");
            guessedNumber = int.Parse(Console.ReadLine());
            attempt++;
            if (guessedNumber > secretNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (guessedNumber < secretNumber)
            {
                Console.WriteLine("Too low!");
            }
            
            if (guessedNumber == secretNumber)
            {
                Console.WriteLine("Correct!");
            }                                 
        }
        Console.WriteLine($"Number of attempts: {attempt}");
    }
}