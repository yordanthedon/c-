List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

int[] bonbsArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

int bombNumber = bonbsArgs[0];
int bombPower = bonbsArgs[1];

for (int i = 0; i < numbers.Count; i++)
{
    int currentNumber = numbers[i];
    if (currentNumber == bombNumber)
    {
        int leftIndex = i - bombPower;
        if (leftIndex < 0)
        {
            leftIndex = 0;
        }

        int rightIndex = i + bombPower;
        if (rightIndex > numbers.Count - 1)
        {
            rightIndex = numbers.Count - 1;
        }

        int numbersToDetonate = rightIndex - leftIndex + 1;
        for (int j = 0; j < numbersToDetonate; j++)
        {
            numbers.RemoveAt(leftIndex);
        }

        i = leftIndex -1;
    }
}

Console.WriteLine(GetSumOfListItems(numbers));

static int GetSumOfListItems(List<int> number)
{
    int sum = 0;
    foreach (int numberItem in number)
    {
        sum += numberItem;
    }
    return sum;
}