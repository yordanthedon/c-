int pages = int.Parse(Console.ReadLine());
int hourPage = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int reading = pages / hourPage;
int hourDay = reading / days;

Console.WriteLine(hourDay);