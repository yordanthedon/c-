int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int heigth = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double realPerc = percentage / 100.0;

double volumeAcuarium = length * width * heigth;
double volumeLiters = volumeAcuarium / 1000;
double requiredLiters = volumeLiters * (1 - realPerc);

Console.WriteLine($"{requiredLiters:F2}");