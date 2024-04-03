float depositSum;
int depositTime;
float interestPercentage;

if (float.TryParse(Console.ReadLine(), out depositSum) &&
    int.TryParse(Console.ReadLine(), out depositTime) &&
    float.TryParse(Console.ReadLine(), out interestPercentage))
{
    float accumulatedInterest = depositSum * (interestPercentage / 100);
    float interestPerMonth = accumulatedInterest / 12;
    float sum = depositSum + (depositTime * interestPerMonth);

    Console.WriteLine($"{sum:f2}");
}
else
{
    Console.WriteLine("Invalid input. Please enter valid numeric values.");
}