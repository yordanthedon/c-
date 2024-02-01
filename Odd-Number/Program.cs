double numbers = double.Parse(Console.ReadLine());

while (numbers % 2 == 0)
{
   numbers = double.Parse(Console.ReadLine());
}
Console.WriteLine(numbers);