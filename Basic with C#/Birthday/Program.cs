float rent = float.Parse(Console.ReadLine()!);

float cakePrice = 0.2f * rent;
float drinksPrice = 0.55f * cakePrice;
float animatorPrice = (1.0f / 3f) * rent;
float totalBudget = rent + cakePrice + drinksPrice + animatorPrice;

Console.WriteLine($"{totalBudget:f2}");