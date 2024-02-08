int b = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());

Console.WriteLine(PowerOfTwoDigits(b, p));

static double PowerOfTwoDigits(int baseNum, int power)
{
    return Math.Pow(baseNum, power);
}