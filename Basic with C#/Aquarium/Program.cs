int length = int.Parse(Console.ReadLine()!);
int width = int.Parse(Console.ReadLine()!);
int height = int.Parse(Console.ReadLine()!);
double percentOccupied = double.Parse(Console.ReadLine()!);

double volume = length * width * height;
percentOccupied /= 100;
double occupiedVolume = volume * percentOccupied;
double freeVolume = volume - occupiedVolume;
double liters = freeVolume / 1000;

Console.WriteLine($"{liters:f3}");