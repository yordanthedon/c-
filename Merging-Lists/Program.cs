int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

List<int> mergedList = new List<int>();

int longerArrayLenght = Math.Max(arrayOne.Length, arrayTwo.Length);

for (int i = 0; i < longerArrayLenght; i++)
{
    if (i < arrayOne.Length)
    {
        mergedList.Add(arrayOne[i]);
    }
    if (i < arrayTwo.Length)
    {
        mergedList.Add(arrayTwo[i]);
    }
}

Console.WriteLine(string.Join(" ", mergedList));