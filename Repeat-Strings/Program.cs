string[] strings = Console.ReadLine().Split().ToArray();

string output = "";

foreach (string s in strings)
{
    for (int i = 0; i < s.Length; i++)
    {
        output += s;
    }
}

Console.WriteLine(output);