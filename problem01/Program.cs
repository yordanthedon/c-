int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());

int maxNumber = numbers.Skip(startNum).Take(endNum - startNum + 1).Max();

int minNumber = numbers.Skip(startNum).Take(endNum - startNum + 1).Min();

int sum = maxNumber + minNumber;

Console.WriteLine(sum);