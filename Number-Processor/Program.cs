int n = int.Parse(Console.ReadLine());

string word = word = Console.ReadLine();

while (word != "End")
{
    if (word == "Inc")
    {
        n++;
    }
    else if (word == "Dec")
    {
        n--;
    }
    word = Console.ReadLine();
}
Console.WriteLine(n);