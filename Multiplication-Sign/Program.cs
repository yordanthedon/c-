int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

NumberPositive(num1, num2, num3);

static void NumberPositive(int num1, int num2, int num3)
{
    int totalSum = num1 * num2 * num3;

    if (totalSum > 0)
    {
        Console.WriteLine("positive");
    }
    else if (totalSum < 0)
    {
        Console.WriteLine("negative");
    }
    else
    {
        Console.WriteLine("zero");
    }
}