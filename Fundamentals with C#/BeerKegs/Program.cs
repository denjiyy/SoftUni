int n = int.Parse(Console.ReadLine()!);
double volume = 0;
string biggestKegModel = "";
double biggestKegVolume = 0;
for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine()!;
    float radius = float.Parse(Console.ReadLine()!);
    int height = int.Parse(Console.ReadLine()!);

    volume = Math.PI * (radius * radius) * height;

    if (biggestKegVolume < volume)
    {
        biggestKegModel = model;
        biggestKegVolume = volume;
    }
}
Console.WriteLine(biggestKegModel);