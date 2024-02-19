List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    bool hasEqualAdjacents = false;
    for (int i = 0; i < numbers.Count - 1; i++)
    {
        int currentNumber = numbers[i];
        int nextNumber = numbers[i + 1];
        
        if (currentNumber == nextNumber)
        {
            int sum = currentNumber + nextNumber;
            numbers.RemoveAt(i);
            numbers.RemoveAt(i);
            
            numbers.Insert(i, sum);

            hasEqualAdjacents = true;
            break;

        }
    }
    if (!hasEqualAdjacents)
    {
        break;
    }
}
Console.WriteLine(string.Join(" ", numbers));