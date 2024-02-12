int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

for (int firstDig = 2;  firstDig <= max1; firstDig += 2)
{
    for (int secondDig = 1; secondDig <= max2; secondDig++)
    {
        for (int thirdDig = 2; thirdDig <= max3; thirdDig += 2)
        {
            if (IsPrime(secondDig))
            {
                Console.WriteLine($"{firstDig}{secondDig}{thirdDig}");
            }
        }
    }
}

static bool IsPrime(int number)
{
    bool isPrime = true;

    if (number <= 1)
    {
        isPrime = false;
    }
    else if (number > 2) 
    {
        int topDivider = (int)Math.Ceiling(Math.Sqrt(number));
        for (int i = 2; i <= topDivider; i++)
        {
            if (number % i == 0) 
            {
                isPrime = false;
                break;
            }
        }

    }
    return isPrime;
}