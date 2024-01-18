double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

double tomatoTotal = tomatoPrice * tomatoQuantity;
double cucumberTotal = cucumberPrice * cucumberQuantity;
double total = tomatoTotal + cucumberTotal;

Console.WriteLine($"{total:F2}");