int n = int.Parse(Console.ReadLine());

List<int> firstArray = new List<int>();
List<int> secondArray = new List<int>();
            
for (int i = 0; i < n; i++)            
{
    List<int> numbers = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();

    if (i % 2 == 0)
    {
        var firstArrayNumber = numbers[0];
        var secondArrayNumber = numbers[1];
        firstArray.Add(firstArrayNumber);
        secondArray.Add(secondArrayNumber);
    }
    else
    {
        var firstArrayNumber = numbers[1];
        var secondArrayNumber = numbers[0];
        firstArray.Add(firstArrayNumber);
        secondArray.Add(secondArrayNumber);
    }
}

Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));