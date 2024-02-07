int numChar = int.Parse(Console.ReadLine());

int totalSum = 0;

for (int i = 1; i <= numChar; i++)
{
    char newChar = char.Parse(Console.ReadLine());

    if (newChar == 'a')
    {
        totalSum += 1;
    }
    if (newChar == 'e')
    {
        totalSum += 2;
    }
    if (newChar == 'i')
    {
        totalSum += 3;
    }
    if (newChar == 'o')
    {
        totalSum += 4;
    }
    if (newChar == 'u')
    {
        totalSum += 5;
    }
}
Console.WriteLine(totalSum);