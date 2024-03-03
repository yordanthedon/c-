string text = Console.ReadLine();

int upperCaseCount = 0;
int lowerCaseCount = 0;
int spaceCount = 0;

foreach (char letter in text)
{
    if (char.IsUpper(letter))
    {
        upperCaseCount++;
    }
    else if (char.IsLower(letter))
    {
        lowerCaseCount++;
    }
    else if (char.IsWhiteSpace(letter))
    {
        spaceCount++;
    }
}

Console.WriteLine(upperCaseCount);
Console.WriteLine(lowerCaseCount);
Console.WriteLine(spaceCount);