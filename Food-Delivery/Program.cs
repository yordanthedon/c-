int chiken = int.Parse(Console.ReadLine());
int fish = int.Parse(Console.ReadLine());
int vegetarian = int.Parse(Console.ReadLine());

double delivery = 2.50;

double chikenMenus = chiken * 10.35;
double fishMenus = fish * 12.40;
double vegetarianMenus = vegetarian * 8.15;
double totalMenus =  chikenMenus + fishMenus + vegetarianMenus;
double dessert = totalMenus * 0.2;
double totalOrder = totalMenus + dessert + delivery;

Console.WriteLine(totalOrder);