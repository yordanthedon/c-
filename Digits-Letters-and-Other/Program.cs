string input = Console.ReadLine();

string digits = "";
string letters = "";
string others = "";

foreach (char letter in input)    
{
    if (char.IsLetter(letter))
    {
        letters += letter;
    }
    else if (char.IsDigit(letter))
    {
        digits += letter;
    }
    else
    {
        others += letter;
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(others);