int budget = int.Parse(Console.ReadLine()!);
string season = Console.ReadLine()!;
int fishermenCount = int.Parse(Console.ReadLine()!);

double boatRentalPrice = 0;

switch (season)
{
    case "Spring":
        boatRentalPrice = 3000;
        break;
    case "Summer":
    case "Autumn":
        boatRentalPrice = 4200;
        break;
    case "Winter":
        boatRentalPrice = 2600;
        break;
}

if (fishermenCount <= 6)
    boatRentalPrice *= 0.90;
else if (fishermenCount <= 11)
    boatRentalPrice *= 0.85;
else
    boatRentalPrice *= 0.75;

if (fishermenCount % 2 == 0 && season != "Autumn")
    boatRentalPrice *= 0.95;

double totalCost = budget - boatRentalPrice;

if (totalCost >= 0)
    Console.WriteLine($"Yes! You have {totalCost:f2} leva left.");
else
    Console.WriteLine($"Not enough money! You need {Math.Abs(totalCost):f2} leva.");