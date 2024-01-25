string season = Console.ReadLine();
string type = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double totalExpen = 0;

if (season == "Spring")
{
    if (type == "Hotel")
    {
        totalExpen = days * 30 - (days * 30 * 0.2);
    }
    else if (type == "Camping")
    {
        totalExpen = days * 10 - (days * 10 * 0.2);
    }
}
else if (season == "Summer")
{
    if (type == "Hotel")
    {
        totalExpen = days * 50;
    }
    else if (type == "Camping")
    {
        totalExpen = days * 30;
    }
}
else if (season == "Autumn")
{
    if (type == "Hotel")
    {
        totalExpen = days * 20 - (days * 20 * 0.3);
    }
    else if (type == "Camping")
    {
        totalExpen = days * 15 - (days * 15 * 0.3);
    }
}
else if (season == "Winter")
{
    if (type == "Hotel")
    {
        totalExpen = days * 40 - (days * 40 * 0.1);
    }    
    else if (type == "Camping")
    {
        totalExpen = days * 10 - (days * 10 * 0.1);
    }    
}
Console.WriteLine($"{totalExpen:F2}");