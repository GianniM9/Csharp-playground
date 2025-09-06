using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a start year: ");
        int startYear = int.Parse(Console.ReadLine());
        Console.Write("Enter an end year: ");
        int endYear = int.Parse(Console.ReadLine());
        int found = 0;
        Console.WriteLine($"Leap years between {startYear} and {endYear}:");
        if (startYear > endYear)
        {
            Console.WriteLine("Invalid input.");
            return;
        }
        for (int year = startYear; year <= endYear; year++)
        {
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                int leapYear = year;
                Console.WriteLine($"{leapYear}");
                found++;  
            }                             
        }
        if (found == 0)
        {
            Console.WriteLine($"No leap years found.");
        }
    }
}