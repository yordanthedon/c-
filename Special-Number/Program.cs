int specNum = int.Parse(Console.ReadLine());

int currentNum = specNum;
bool isValid = true;

while (currentNum > 0)
{
    int currentDigit = currentNum % 10;
    currentNum /= 10;

    if (specNum % currentDigit != 0)
    {
        isValid = false;
        break;
    }
}
if (isValid)
{
    Console.WriteLine($"{specNum} is special");
}
else
{
    Console.WriteLine($"{specNum} is not special");
}    