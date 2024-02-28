int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int middle = numbers.Length / 2;

int firstNum = numbers[middle - 1];
int secondNum = numbers[middle];

double result = (firstNum + secondNum) / 2.00;

Console.WriteLine($"{result:F2}");