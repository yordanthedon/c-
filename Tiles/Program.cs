double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHight = double.Parse(Console.ReadLine());

double bathArea = width * height;
double surplus = bathArea + (bathArea * 0.1);
double tileArea = tileWidth * tileHight;
double tileNeeded = surplus / tileArea;

Console.WriteLine(Math.Round(tileNeeded));