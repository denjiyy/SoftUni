string type = Console.ReadLine()!;
int rows = int.Parse(Console.ReadLine()!);
int cols = int.Parse(Console.ReadLine()!);

double income = 0.0;

switch (type)
{
	case "Premiere":
		income = rows * cols * 12.00;
		break;
	case "Normal":
		income = cols * rows * 7.50;
		break;
	case "Discount":
		income = rows * cols * 5.00;
		break;
	default:
		break;
}

Console.WriteLine($"{income:f2} leva");