int n = int.Parse(Console.ReadLine()!);

int p1Count = 0, p2Count = 0, p3Count = 0, p4Count = 0, p5Count = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine()!);

    if (number < 200)
        p1Count++;
    else if (number >= 200 && number <= 399)
        p2Count++;
    else if (number >= 400 && number <= 599)
        p3Count++;
    else if (number >= 600 && number <= 799)
        p4Count++;
    else
        p5Count++;
}

double p1 = (double)p1Count / n * 100;
double p2 = (double)p2Count / n * 100;
double p3 = (double)p3Count / n * 100;
double p4 = (double)p4Count / n * 100;
double p5 = (double)p5Count / n * 100;

Console.WriteLine($"{p1:f2}%");
Console.WriteLine($"{p2:f2}%");
Console.WriteLine($"{p3:f2}%");
Console.WriteLine($"{p4:f2}%");
Console.WriteLine($"{p5:f2}%");