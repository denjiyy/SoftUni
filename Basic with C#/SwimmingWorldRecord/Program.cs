double recordSeconds = double.Parse(Console.ReadLine()!);
double distanceMeters = double.Parse(Console.ReadLine()!);
double timePerMeterSeconds = double.Parse(Console.ReadLine()!);

double resistanceTime = Math.Floor(distanceMeters / 15) * 12.5;
double swimmingTime = distanceMeters * timePerMeterSeconds + resistanceTime;

if (swimmingTime < recordSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {swimmingTime:f2} seconds.");
}
else
{
    double secondsSlower = swimmingTime - recordSeconds;
    Console.WriteLine($"No, he failed! He was {secondsSlower:f2} seconds slower.");
}