int number = int.Parse(Console.ReadLine());

bool isValid = number >= 1 && number <= 100;

while (!isValid)
{
    number = int.Parse(Console.ReadLine());
    isValid = number >= 1 && number <= 100;
}

Console.WriteLine(number);