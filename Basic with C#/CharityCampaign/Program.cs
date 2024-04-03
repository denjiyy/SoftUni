int campaignDays = int.Parse(Console.ReadLine());
int bakers = int.Parse(Console.ReadLine());
int cakesPerBaker = int.Parse(Console.ReadLine());
int wafflesPerBaker = int.Parse(Console.ReadLine());
int pancakesPerBaker = int.Parse(Console.ReadLine());

int totalCakes = cakesPerBaker * bakers * campaignDays;
int totalWaffles = wafflesPerBaker * bakers * campaignDays;
int totalPancakes = pancakesPerBaker * bakers * campaignDays;

double cakesIncome = totalCakes * 45.0;
double wafflesIncome = totalWaffles * 5.80;
double pancakesIncome = totalPancakes * 3.20;
double totalIncome = cakesIncome + wafflesIncome + pancakesIncome;

double expenses = totalIncome / 8;

double finalIncome = totalIncome - expenses;

Console.WriteLine($"{finalIncome:f2}");