List<string> strings = Console.ReadLine().Split().ToList();

List<string> newList = new List<string>();

foreach (string s in strings)
{
    if (s.Length % 2 == 0)
    {
        newList.Add(s);
    }
}

foreach (string s in newList)
{
    Console.WriteLine(s);
}

//List<string> str = Console.ReadLine()
//                       .Split()
//                       .Where(s => s.Length % 2 == 0)
//                       .Select(s => { Console.WriteLine(s); return s; })
//                       .ToList();