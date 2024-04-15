int n = int.Parse(Console.ReadLine()!);
int sum = 0;
int litres;
int tankCapacity = 255;
for (int i = 0; i < n; i++)
{
    litres = int.Parse(Console.ReadLine()!);

    if (litres > tankCapacity)
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        sum += litres;
        tankCapacity -= litres;
    }
}
Console.WriteLine(sum);