List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandElements = command.Split().ToArray();

    if (commandElements[0] == "Add")
    {
        int number = int.Parse(commandElements[1]);

        numbers.Add(number);
    }
    else if (commandElements[0] == "Remove")
    {
        int num = int.Parse(commandElements[1]);

        numbers.Remove(num);
    }
    else if (commandElements[0] == "RemoveAt")
    {
        int position = int.Parse(commandElements[1]);

        numbers.RemoveAt(position);
    }
    else if (commandElements[0] == "Insert")
    {
        int num = int.Parse(commandElements[1]);
        int position = int.Parse(commandElements[2]);

        numbers.Insert(position, num);
    }


    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));