int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int total = 0;

for (int i = 0; i < numbers.Length; i++)
{
    total += numbers[i];
}

Console.WriteLine(total);