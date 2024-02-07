double stopNumber = double.Parse(Console.ReadLine());

double realStop = 0;
double previousNumber = double.Parse(Console.ReadLine());

while (true)
{
    realStop = double.Parse(Console.ReadLine());
    if (realStop == stopNumber)
    {
        previousNumber *= 1.2;
        break;
    }
    previousNumber = realStop;
}
Console.WriteLine(previousNumber);