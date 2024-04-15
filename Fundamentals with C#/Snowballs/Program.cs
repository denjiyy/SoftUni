using System.Numerics;

int n = int.Parse(Console.ReadLine()!);
BigInteger snowballValue = 0;
int bestSnow = 0;
int bestTime = 0;
int bestQuality = 0;


for (int i = 0; i < n; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine()!);
    int snowballTime = int.Parse(Console.ReadLine()!);
    int snowballQuality = int.Parse(Console.ReadLine()!);

    BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

    if (snowballValue < value)
    {
        snowballValue = value;
        bestQuality = snowballQuality;
        bestSnow = snowballSnow;
        bestTime = snowballTime;
    }
}

Console.WriteLine($"{bestSnow} : {bestTime} = {snowballValue} ({bestQuality})");