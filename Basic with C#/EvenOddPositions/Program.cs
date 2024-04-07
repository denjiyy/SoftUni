int n = int.Parse(Console.ReadLine()!);

double oddSum = 0;
double oddMin = double.MaxValue;
double oddMax = double.MinValue;

double evenSum = 0;
double evenMin = double.MaxValue;
double evenMax = double.MinValue;

for (int i = 1; i <= n; i++)
{
    double num = double.Parse(Console.ReadLine()!);

    if (i % 2 == 0)
    {
        evenSum += num;
        evenMin = Math.Min(evenMin, num);
        evenMax = Math.Max(evenMax, num);
    }
    else
    {
        oddSum += num;
        oddMin = Math.Min(oddMin, num);
        oddMax = Math.Max(oddMax, num);
    }
}

Console.WriteLine("OddSum=" + oddSum.ToString("F2"));
Console.WriteLine("OddMin=" + (oddMin != double.MaxValue ? oddMin.ToString("F2") : "No"));
Console.WriteLine("OddMax=" + (oddMax != double.MinValue ? oddMax.ToString("F2") : "No"));
Console.WriteLine("EvenSum=" + evenSum.ToString("F2"));
Console.WriteLine("EvenMin=" + (evenMin != double.MaxValue ? evenMin.ToString("F2") : "No"));
Console.WriteLine("EvenMax=" + (evenMax != double.MinValue ? evenMax.ToString("F2") : "No"));