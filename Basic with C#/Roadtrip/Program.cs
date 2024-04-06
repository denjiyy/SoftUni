double budget = double.Parse(Console.ReadLine()!);
string season = Console.ReadLine()!;

string destination = "";
string vacationType = "";
double spentAmount = 0;

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        vacationType = "Camp";
        spentAmount = budget * 0.30;
    }
    else if (season == "winter")
    {
        vacationType = "Hotel";
        spentAmount = budget * 0.70;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        vacationType = "Camp";
        spentAmount = budget * 0.40;
    }
    else if (season == "winter")
    {
        vacationType = "Hotel";
        spentAmount = budget * 0.80;
    }
}
else
{
    destination = "Europe";
    vacationType = "Hotel";
    spentAmount = budget * 0.90;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{vacationType} - {spentAmount:f2}");