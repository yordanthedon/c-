int n = int.Parse(Console.ReadLine());

bool isNoMacigNum = true;

for  (int i = 1; i <= n; i++)
{
    int currentNum = i;
    int sumDigits = 0;
    bool isPrimeDigit = true;

    while (currentNum > 0)
    {
        int digits = currentNum % 10;
        currentNum /= 10;

        sumDigits += digits;

        if (digits != 2 && digits != 3 && digits != 5 && digits != 7)
        {
            isPrimeDigit = false;
        }
    }

    if (isPrimeDigit && sumDigits % 2 == 0)
    {
        Console.Write(i + " ");
        isNoMacigNum = false;
    }
}
if (isNoMacigNum)
{
    Console.WriteLine("no");
}    