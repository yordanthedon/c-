string drink = Console.ReadLine();
string extra = Console.ReadLine();

double price = 0;

if (drink == "coffee" && extra == "sugar")
{
    price = 1 + 0.4;
}
else if (drink == "tea" && extra == "sugar")
{
    price = 0.6 + 0.4;
}
else if (drink == "coffee" && extra == "no")
{
    price = 1;
}
else if (drink == "tea" && extra == "no")
{
    price = 0.6;
}
Console.WriteLine($"Final price: ${price:F2}");