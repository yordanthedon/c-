int dogFood = int.Parse(Console.ReadLine());
int catFood = int.Parse(Console.ReadLine());

double expenses = dogFood * 2.50 + catFood * 4.00;

Console.WriteLine($"{expenses:F2} lv.");