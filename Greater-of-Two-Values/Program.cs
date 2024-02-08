string type = Console.ReadLine();

if (type == "int")
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine(GetGreatestInt(n1, n2));
}

else if (type == "char")
{
    char c1 = char.Parse(Console.ReadLine());
    char c2 = char.Parse(Console.ReadLine());

    Console.WriteLine(GetGreatestChar(c1, c2));
}

else if (type == "string")
{
    string one = Console.ReadLine();
    string two = Console.ReadLine();

    Console.WriteLine(GetGreatestString(one, two));
}

static int GetGreatestInt(int num1, int num2)
{
    if (num1 > num2) return num1;
    else return num1;
}

static char GetGreatestChar(char char1, char char2)
{ 
    if (char1 > char2) return char1;
    else return char2;
}

static string GetGreatestString(string s1, string s2)
{
    if (s1.CompareTo(s2) > 0) return s1;
    else return s2;
}