﻿int n = int.Parse(Console.ReadLine());

string[] days =
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday",
};

if  (n >= 1 && n <= n)
{
    Console.WriteLine(days[n - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}