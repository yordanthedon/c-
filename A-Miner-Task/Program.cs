string input = Console.ReadLine();

var resources = new Dictionary<string, double>();

while (input != "stop")
{
    int quantity = int.Parse(Console.ReadLine());
    
    if (resources.ContainsKey(input))
    {
        resources[input] += quantity;
    }
    else
    {
        resources.Add(input, quantity);
    }

    input = Console.ReadLine();
}

foreach (var pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}