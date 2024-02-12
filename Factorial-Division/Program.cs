int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(DivisonOfSums(num1, num2));

static int DivisonOfSums(int num, int num2)
{
    int firstFactorial = 1;
    int secondFactorial = 1;

    for (int i = 1; i <= num; i++)
    {
        firstFactorial *= i;
    }

    for (int j = 1; j <= num2; j++)
    {
        secondFactorial *= j;
    }

    return firstFactorial / secondFactorial;
}