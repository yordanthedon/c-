string figure = Console.ReadLine();

double area = 0;

if (figure == "square")
{
    double side = double.Parse(Console.ReadLine());
    area = side * side;
}
else if (figure == "rectangle")
{
    double width = double.Parse(Console.ReadLine());
    double lenght = double.Parse(Console.ReadLine());
    area = width * lenght;
}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    area = Math.PI * radius * radius;
}
Console.WriteLine($"{area:F2}");