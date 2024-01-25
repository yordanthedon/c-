int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int sumSec = firstTime + secondTime + thirdTime;

int sumMin = sumSec / 60;
int sumMins = sumSec % 60;

Console.WriteLine($"{sumMin}:{sumMins:D2}");