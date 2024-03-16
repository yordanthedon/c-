var students = new Dictionary<string, List<double>>();

int count = int.Parse(Console.ReadLine());

for  (int i = 0; i < count; i++)
{
    string student = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (students.ContainsKey(student))
    {
        students[student].Add(grade);
    }
    else
    {
        students.Add(student, new List<double> { grade });
    }
}

foreach (var pair in students)
{
    string studnet = pair.Key;
    double average = pair.Value.Average();
    if (average >= 4.50)
    {
        Console.WriteLine($"{studnet} -> {average:F2}");
    }   
}
