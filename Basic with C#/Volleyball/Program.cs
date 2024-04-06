string yearType = Console.ReadLine()!;
int holidays = int.Parse(Console.ReadLine()!);
int weekendsBackHome = int.Parse(Console.ReadLine()!);

int weekendsInSofia = 48 - weekendsBackHome;

double volleyballSofiaWeekends = weekendsInSofia * (3.0 / 4);
double volleyballHolidays = holidays * (2.0 / 3);
double volleyballBackHome = weekendsBackHome;

double totalVolleyball = volleyballSofiaWeekends + volleyballHolidays + volleyballBackHome;

if (yearType == "leap")
{
    totalVolleyball *= 1.15;
}

Console.WriteLine(Math.Floor(totalVolleyball));