string prod = Console.ReadLine();
int quan = int.Parse(Console.ReadLine());

Console.WriteLine($"{TotalOrders(prod, quan):F2}");

static double TotalOrders(string p, int q)
{
    double totalSum = 0;

    if (p == "coffee")
    {
        totalSum = q * 1.50;
    }
    else if (p == "water")
    {
        totalSum = q * 1.00;
    }
    else if (p == "coke")
    {
        totalSum = q * 1.40;
    }
    else if (p == "snacks")
    {
        totalSum = q * 2.00;
    }
    return totalSum;
}