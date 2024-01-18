int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hoursWork = int.Parse(Console.ReadLine());

double bags = 0.40;

double nylonAmount = (nylon + 2) * 1.50;
double paintAmount = (paint + (paint * 0.1)) * 14.50;
double thinnerAmount = thinner * 5;
double totalMaterials = nylonAmount + paintAmount + thinnerAmount + bags;
double craftsmen = (totalMaterials * 0.3) * hoursWork;
double total = totalMaterials + craftsmen;

Console.WriteLine(total);