Console.Write("Enter hour (0-23): ");
int hour = int.Parse(Console.ReadLine()!);

Console.Write("Enter minutes (0-59): ");
int minutes = int.Parse(Console.ReadLine()!);

minutes += 15;
hour += minutes / 60;
minutes %= 60;
hour %= 24;

Console.WriteLine($"It'll be: {hour:D2}:{minutes:D2} after 15 mins.");