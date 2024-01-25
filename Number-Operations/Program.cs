double one = double.Parse(Console.ReadLine());
double two = double.Parse(Console.ReadLine());
string opr = Console.ReadLine();

double result = 0;

if (opr == "+")
{
    result = one + two;
}
else if (opr == "-")
{
    result = one - two;
}
else if (opr == "*")
{
    result = one * two;
}
else if (opr == "/")
{
    result = one / two;
}

Console.WriteLine($"{one} {opr} {two} = {result:F2}");