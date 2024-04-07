int n = int.Parse(Console.ReadLine()!);

int divisibleBy2Count = 0, divisibleBy3Count = 0, divisibleBy4Count = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine()!);

    if (number % 2 == 0)
        divisibleBy2Count++;

    if (number % 3 == 0)
        divisibleBy3Count++;

    if (number % 4 == 0)
        divisibleBy4Count++;
}

double p1 = (double)divisibleBy2Count / n * 100;
double p2 = (double)divisibleBy3Count / n * 100;
double p3 = (double)divisibleBy4Count / n * 100;

Console.WriteLine($"{p1:f2}%");
Console.WriteLine($"{p2:f2}%");
Console.WriteLine($"{p3:f2}%");