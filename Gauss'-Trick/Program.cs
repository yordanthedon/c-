int[] aNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int outputNumbersLenght = aNumbers.Length / 2;

if (aNumbers.Length % 2 != 0)
{
    outputNumbersLenght++;  
}

int[] outputNumbers = new int[outputNumbersLenght];


for (int i = 0; i < outputNumbersLenght; i++)
{
    if (aNumbers.Length % 2 != 0 && i == outputNumbersLenght -1)
    {
        outputNumbers[i] = aNumbers[i];
        break;
    }

    int elementA = aNumbers[i];
    int elementB = aNumbers[aNumbers.Length - 1 - i];

    outputNumbers[i] = elementA + elementB;
}

Console.WriteLine(string.Join(" ", outputNumbers));