double pages = double.Parse(Console.ReadLine()!);
double pagesPerHour = double.Parse(Console.ReadLine()!);
double daysCount = double.Parse(Console.ReadLine()!);

double timeNeeded = pages / pagesPerHour;
double hoursPerDay = timeNeeded / daysCount;

Console.WriteLine($"{hoursPerDay:f1}");