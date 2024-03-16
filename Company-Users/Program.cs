var companiesWithEmpl = new Dictionary<string, List<string>>();

string input = Console.ReadLine();

while (input != "End")
{
    string[] inputParams = input.Split(" -> ");
    string company = inputParams[0];
    string emplName = inputParams[1];

    if (companiesWithEmpl.ContainsKey(company))
    {
        if (!companiesWithEmpl[company].Contains(emplName))
        {
            companiesWithEmpl[company].Add(emplName);
        }
    }
    else
    {
        companiesWithEmpl.Add(company, new List<string>() { emplName });
    }

    input = Console.ReadLine();
}

foreach (var pair in companiesWithEmpl)
{
    Console.WriteLine(pair.Key);
    foreach (var employee  in pair.Value)
    {
        Console.WriteLine($"-- {employee}");
    }
} 