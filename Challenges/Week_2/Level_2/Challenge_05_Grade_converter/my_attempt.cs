using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a numeric grade: ");
        int grade = int.Parse(Console.ReadLine());
        if (grade > 100 || grade < 0)
        {
            Console.WriteLine("Invalid grade");
        }
        else if (grade <= 100 && grade >= 97)
        {
            Console.WriteLine("A+");
        }
        else if (grade <= 96 && grade >= 93)
        {
            Console.WriteLine("A");
        }
        else if (grade <= 92 && grade >= 90)
        {
            Console.WriteLine("A-");
        }
        else if (grade <= 89 && grade >= 87)
        {
            Console.WriteLine("B+");
        }
        else if (grade <= 86 && grade >= 83)
        {
            Console.WriteLine("B");
        }
        else if (grade <= 82 && grade >= 80)
        {
            Console.WriteLine("B-");
        }
        else if (grade <= 79 && grade >= 77)
        {
            Console.WriteLine("C+");
        }
        else if (grade <= 76 && grade >= 73)
        {
            Console.WriteLine("C");
        }
        else if (grade <= 72 && grade >= 70)
        {
            Console.WriteLine("C-");
        }
        else if (grade <= 69 && grade >= 67)
        {
            Console.WriteLine("D+");
        }
        else if (grade <= 66 && grade >= 63)
        {
            Console.WriteLine("D");
        }
        else if (grade <= 62 && grade >= 60)
        {
            Console.WriteLine("D-");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}