int numberLoops = int.Parse(Console.ReadLine());

int divideToTwo = 0;
int divideToThree = 0;
int divideToFour = 0;

for (int i = 1; i <= numberLoops; i++)
{
    int numberToDivide = int.Parse(Console.ReadLine());
    
    if (numberToDivide % 2 == 0)
    {
        divideToTwo += 1;
    }
    if (numberToDivide % 3 == 0)
    {
        divideToThree += 1;
    }
    if (numberToDivide % 4 == 0)
    {
        divideToFour += 1;
    }
}
double twoDivision = (double)divideToTwo / numberLoops * 100;
double threeDivision = (double)divideToThree / numberLoops * 100;
double fourDivision = (double)divideToFour / numberLoops * 100;

Console.WriteLine($"{twoDivision:F2}%");
Console.WriteLine($"{threeDivision:F2}%");
Console.WriteLine($"{fourDivision:F2}%");