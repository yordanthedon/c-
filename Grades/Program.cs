﻿double g = double.Parse(Console.ReadLine());

PrintGrade(g);

static void PrintGrade(double grade)
{
    if (grade < 3.00)
    {
        Console.WriteLine("Fail");
    }
    else if (grade < 3.50)
    {
        Console.WriteLine("Average");
    }
    else if (grade < 4.50)
    {
        Console.WriteLine("Good");
    }
    else if (grade < 5.50)
    {
        Console.WriteLine("Very good");
    }
    else
    {
        Console.WriteLine("Excellent");
    }
}