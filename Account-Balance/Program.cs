string cmd = Console.ReadLine();
double balance  = 0;    

while (cmd != "End")
{
    double increaseOrDecrease;
    var isNumber = double.TryParse(cmd, out increaseOrDecrease);
    if (isNumber)
    {
        if (increaseOrDecrease > 0)
        {
            balance += increaseOrDecrease;
            Console.WriteLine($"Increase: {increaseOrDecrease:F2}");
        }
        else
        {
            balance += increaseOrDecrease;
            Console.WriteLine($"Decrease: {Math.Abs(increaseOrDecrease):F2}");
        }
    }
    cmd = Console.ReadLine();
}
Console.WriteLine($"Balance: {balance:F2}");