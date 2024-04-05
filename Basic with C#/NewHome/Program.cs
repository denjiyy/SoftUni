string flowerType = Console.ReadLine()!;
int flowerCount = int.Parse(Console.ReadLine()!);
int budget = int.Parse(Console.ReadLine()!);

double totalCost = 0;

switch (flowerType)
{
    case "Roses":
        totalCost = flowerCount * 5;
        if (flowerCount > 80)
            totalCost *= 0.90;
        break;
    case "Dahlias":
        totalCost = flowerCount * 3.80;
        if (flowerCount > 90)
            totalCost *= 0.85;
        break;
    case "Tulips":
        totalCost = flowerCount * 2.80;
        if (flowerCount > 80)
            totalCost *= 0.85;
        break;
    case "Narcissus":
        totalCost = flowerCount * 3;
        if (flowerCount < 120)
            totalCost *= 1.15;
        break;
    case "Gladiolus":
        totalCost = flowerCount * 2.50;
        if (flowerCount < 80)
            totalCost *= 1.20;
        break;
}

if (budget >= totalCost)
    Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {(budget - totalCost):f2} leva left.");
else
    Console.WriteLine($"Not enough money, you need {(totalCost - budget):f2} leva more.");