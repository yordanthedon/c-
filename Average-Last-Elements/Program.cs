int[] digits = Console.ReadLine().Split().Select(int.Parse).ToArray();
int singleDigit = int.Parse(Console.ReadLine());

int arrLenght = digits.Length;

int sum = 0;
for (int i = 0; i < singleDigit; i++)
{
    int currentNum = digits[arrLenght - 1 - i];
    sum += currentNum;
}

double lastElAvarege = (double)sum / singleDigit;

Console.WriteLine($"{lastElAvarege:F2}");