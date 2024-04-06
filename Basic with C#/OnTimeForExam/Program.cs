int examHour = int.Parse(Console.ReadLine()!);
int examMinute = int.Parse(Console.ReadLine()!);
int arrivalHour = int.Parse(Console.ReadLine()!);
int arrivalMinute = int.Parse(Console.ReadLine()!);

int examTimeInMinutes = examHour * 60 + examMinute;
int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinute;

int difference = arrivalTimeInMinutes - examTimeInMinutes;

if (difference < -30)
{
    Console.WriteLine("Early");
}
else if (difference <= 0)
{
    Console.WriteLine("On time");
}
else
{
    Console.WriteLine("Late");
}

if (difference != 0)
{
    int hours = Math.Abs(difference / 60);
    int minutes = Math.Abs(difference % 60);

    if (hours > 0)
    {
        Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
    }
    else
    {
        Console.WriteLine($"{minutes} minutes {(difference < 0 ? "before" : "after")} the start");
    }
}