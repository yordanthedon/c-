int n = int.Parse(Console.ReadLine());

int realNum = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int n2 = int.Parse(Console.ReadLine());

    if (realNum < n2)
    {
          realNum = n2;
    }
}
Console.WriteLine(realNum);