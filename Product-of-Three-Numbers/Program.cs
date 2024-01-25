int one = int.Parse(Console.ReadLine());
int two = int.Parse(Console.ReadLine());
int three = int.Parse(Console.ReadLine());

if (one == 0 ||
    two == 0 ||
    three == 0)
{
    Console.WriteLine("zero");
}
else if (one < 0)
{
    if (two > 0 &&
        three > 0)
    {
        Console.WriteLine("negative");
    }
    else
    {
        Console.WriteLine("positive");
    }
}
else if (two < 0)
{
    if (three > 0 &&
        one > 0)
    {
        Console.WriteLine("negative");
    }
    else
    {
        Console.WriteLine("positive");
    }
}
else if (three < 0)
{
    if (one > 0 &&
        two > 0)
    {
        Console.WriteLine("negative");
    }
    else
    {
        Console.WriteLine("positive");
    }
}    