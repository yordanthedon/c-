string input = Console.ReadLine();

while (input != "End")
{
    int number = int.Parse(input);
    int sumDigits = 0;

    while (number > 0)
    {
        int digits = number % 10;
        sumDigits += digits;
        number /= 10;
    }
    Console.WriteLine($"Sum of digits = {sumDigits}");
    
    input = Console.ReadLine();
}
Console.WriteLine("Goodbye");