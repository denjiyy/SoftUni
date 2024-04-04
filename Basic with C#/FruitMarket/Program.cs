double strawberryPrice = double.Parse(Console.ReadLine()!);
double bananasAmount = double.Parse(Console.ReadLine()!);
double orangesAmount = double.Parse(Console.ReadLine()!);
double raspberriesAmount = double.Parse(Console.ReadLine()!);
double strawberriesAmount = double.Parse(Console.ReadLine()!);

double raspberriesPrice = strawberryPrice / 2;
double orangesPrice = raspberriesPrice - (0.4 * raspberriesPrice);
double bananasPrice = raspberriesPrice - (0.8 * raspberriesPrice);

double totalCost = (strawberryPrice * strawberriesAmount) + (bananasPrice * bananasAmount) + (orangesPrice * orangesAmount) + (raspberriesPrice * raspberriesAmount);

Console.WriteLine($"{totalCost:f2}");