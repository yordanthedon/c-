string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());

double ticketPrice = 0;

if (type == "Premiere")
{
    ticketPrice = 12.00;
}
else if (type == "Normal")
{
    ticketPrice = 7.50;
}
else if (type == "Discount")
{
    ticketPrice = 5.00;
}

double totalPrice = rows * seats * ticketPrice;
Console.WriteLine($"{totalPrice:F2}");