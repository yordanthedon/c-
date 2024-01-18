double depositAmount = double.Parse(Console.ReadLine());
int termDeposit = int.Parse(Console.ReadLine());
double annualRate = double.Parse(Console.ReadLine());

double annual = annualRate / 100;

double accumulatedInterest = depositAmount * annual;
double monthlyInterest = accumulatedInterest / 12;
double amount = depositAmount + termDeposit * monthlyInterest;

Console.WriteLine(amount);