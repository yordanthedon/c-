int pensPackage = int.Parse(Console.ReadLine());
int markersPackage = int.Parse(Console.ReadLine());
int litersCleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double penPrice = pensPackage * 5.80;
double markersPrice = markersPackage * 7.20;
double cleanerPrice = litersCleaner * 1.20;
double allPrice = penPrice + markersPrice + cleanerPrice;
double discountAll = allPrice - (allPrice * (discount / 100.0));

Console.WriteLine(discountAll);