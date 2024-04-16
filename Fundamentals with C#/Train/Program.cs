int numberOfWagons = int.Parse(Console.ReadLine()!);

List<int> peopleInWagons = new List<int>();

for (int i = 0; i < numberOfWagons; i++)
{
    peopleInWagons.Add(int.Parse(Console.ReadLine()!));
}

Console.WriteLine($"{string.Join(" ", peopleInWagons)}");
Console.WriteLine(peopleInWagons.Sum());