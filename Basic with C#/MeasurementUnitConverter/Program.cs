double number = double.Parse(Console.ReadLine()!);
string measurementUnit = Console.ReadLine()!;
string desiredUnit = Console.ReadLine()!;

double result = 0;

if (measurementUnit == "m")
{
    if (desiredUnit == "mm")
    {
        result = number * 1000;
    }
    else if (desiredUnit == "cm")
    {
        result = number * 100;
    }
}
else if (measurementUnit == "cm")
{
    if (desiredUnit == "mm")
    {
        result = number * 10;
    }
    else if (desiredUnit == "m")
    {
        result = number / 100;
    }
}
else if (measurementUnit == "mm")
{
    if (desiredUnit == "cm")
    {
        result = number / 10;
    }
    else if (desiredUnit == "m")
    {
        result = number / 1000;
    }
}
else
{
    Console.WriteLine("Invalid measurement unit.");
    return;
}

Console.WriteLine($"{number} {measurementUnit} is equal to {result} {desiredUnit}.");