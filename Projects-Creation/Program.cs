﻿string name = Console.ReadLine();  
int projects = int.Parse(Console.ReadLine());

int hours = projects * 3;

Console.WriteLine($"The architect {name} will need {hours} hours to complete {projects} project/s.");