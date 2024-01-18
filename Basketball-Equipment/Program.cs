int fee = int.Parse(Console.ReadLine());

double sneakers = fee - (fee * 0.4);
double team = sneakers - (sneakers * 0.2);
double basketball = team * 0.25;
double accessories = basketball * 0.2;
double total = fee + sneakers + team + basketball + accessories;

Console.WriteLine(total);