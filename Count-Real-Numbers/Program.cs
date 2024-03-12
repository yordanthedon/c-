List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

SortedDictionary<double, int> counter = new SortedDictionary<double, int>();

foreach (var number in numbers)
{
    if (counter.ContainsKey(number))
    {
        counter[number]++;
    }
    else
    {
        counter.Add(number, 1);
    }
}

foreach (var number in counter)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}