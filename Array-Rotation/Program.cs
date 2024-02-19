List<int> numbers = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();

int expectedRotations = int.Parse(Console.ReadLine());
int performedRotations = 0;
            
while (performedRotations != expectedRotations)
{            
    int firstEl = numbers[0];
    
    for (int i = 1; i < numbers.Count; i++)            
    {
        numbers[i - 1] = numbers[i];            
    }
    
    numbers[numbers.Count - 1] = firstEl;
    
    performedRotations++;            
}            
Console.WriteLine(string.Join(" ", numbers));