int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();

bool isIdentical = true;

for (int i = 0; i < first.Length; i++)
{
    if (first[i] != second[i])
    {
        isIdentical = false;
        break;
    }
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}    