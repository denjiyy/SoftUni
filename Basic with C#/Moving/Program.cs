int freeSpaceWidth = int.Parse(Console.ReadLine()!);
int freeSpaceLength = int.Parse(Console.ReadLine()!);
int freeSpaceHeight = int.Parse(Console.ReadLine()!);
int freeSpace = freeSpaceWidth * freeSpaceLength * freeSpaceHeight;
bool isFull = false;
int packetsSum = 0;

string input;
while ((input = Console.ReadLine()!) != "Done")
{
	int packets = int.Parse(input);
	packetsSum += packets;

	if (packetsSum > freeSpace)
	{
        Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace - packetsSum)} Cubic meters more.");
		isFull = true;
		break;
    }
}

if (isFull == false)
{
    Console.WriteLine($"{freeSpace - packetsSum} Cubic meters left.");
}