string text = Console.ReadLine();

Console.WriteLine(CountOfVowels(text));

static int CountOfVowels(string text)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)
    {
        char c = char.ToLower(text[i]);
        if (c == 'a' || c == 'e' || c == 'o' || c == 'u' || c == 'i')
        {
            count++;
        }
    }

    return count;
}