int n = int.Parse(Console.ReadLine()!);
int totalSum = 0;

for (int i = 0; i < n; i++)
{
    char letter = char.Parse(Console.ReadLine()!);
    int asciiCode = (int)letter;
    totalSum += asciiCode;
}

Console.WriteLine($"The sum equals: {totalSum}");