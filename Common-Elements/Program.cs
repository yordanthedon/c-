int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();


foreach (int num1 in first)
{
    foreach (int num2 in second)
    {
        if (num1 == num2)
        {
            Console.Write($"{num1} ");
        }
    }
}

Console.WriteLine();