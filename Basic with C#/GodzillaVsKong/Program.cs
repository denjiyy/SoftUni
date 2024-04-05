double budget = double.Parse(Console.ReadLine()!);
int extrasCount = int.Parse(Console.ReadLine()!);
double clothingPricePerExtra = double.Parse(Console.ReadLine()!);

double decorCost = budget * 0.1;
double clothingCost = extrasCount * clothingPricePerExtra;

double totalCost = decorCost + clothingCost;
if (extrasCount > 150)
{
    clothingCost -= clothingCost * 0.1;
    totalCost = decorCost + clothingCost;
}

if (totalCost > budget)
{
    double neededMoney = totalCost - budget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
}
else
{
    double remainingMoney = budget - totalCost;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {remainingMoney:f2} leva left.");
}