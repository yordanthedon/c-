char s = char.Parse(Console.ReadLine());
char e = char.Parse(Console.ReadLine());
char exc = char.Parse(Console.ReadLine());

int totalComb = 0;

for (char firstLetter = s; firstLetter <= e; firstLetter++)
{
    for (char secondLetter = s; secondLetter <= e; secondLetter++)
    {
        for (char thirdLetter = s; thirdLetter <= e; thirdLetter++)
        {
            if (firstLetter != exc && secondLetter != exc && thirdLetter != exc)
            {
                Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                totalComb++;
            }    
        }
    }
}
Console.WriteLine();
Console.WriteLine(totalComb);