int n = int.Parse(Console.ReadLine());


for (int first = 1; first <= n; first++)
{
    for (int second = 0; second <= n; second++)
    {
        for (int third = 0; third <= n; third++)
        {
            for (int fourth = 0; fourth <= n; fourth++)
            {
                int firstCombination = first + second;
                int secondCombination = third + fourth;

                if (firstCombination == n && secondCombination == n)
                {
                    Console.Write($"{first}{second}{third}{fourth} ");
                }
            }
        }
    }
}