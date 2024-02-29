int[] digits = Console.ReadLine().Split().Select(int.Parse).ToArray();
int singleDigit = int.Parse(Console.ReadLine());

int[] newDigits = new int[singleDigit];

for (int i = 0; i < newDigits.Length; i++)
{
    newDigits[i] = digits[i];
}

Console.WriteLine(newDigits.Max());
Console.WriteLine(newDigits.Min());