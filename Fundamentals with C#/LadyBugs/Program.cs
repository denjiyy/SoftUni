int fieldLength = int.Parse(Console.ReadLine()!);
List<int> bugs = Console.ReadLine()!
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> field = new List<int>(Enumerable
    .Repeat(0, fieldLength));

foreach (int bugIndex in bugs
    .Where(index => index >= 0 && index < fieldLength))
{
    field[bugIndex] = 1;
}

string command;
while ((command = Console.ReadLine()!) != "end")
{
    List<string> commandArgs = command
        .Split()
        .ToList();
    if (commandArgs.Count != 3) continue;

    int bugIndex = int.Parse(commandArgs[0]);
    string direction = commandArgs[1];
    int flyLength = int.Parse(commandArgs[2]);

    if (bugIndex < 0 || bugIndex >= field.Count || field[bugIndex] == 0)
    {
        continue;
    }

    field[bugIndex] = 0;

    if (direction == "right")
    {
        int lengthIndex = bugIndex + flyLength;

        if (lengthIndex >= field.Count)
        {
            continue;
        }

        while (lengthIndex < field.Count && field[lengthIndex] == 1)
        {
            lengthIndex += flyLength;
        }

        if (lengthIndex < field.Count)
        {
            field[lengthIndex] = 1;
        }
    }
    else if (direction == "left")
    {
        int lengthIndex = bugIndex - flyLength;

        if (lengthIndex < 0)
        {
            continue;
        }

        while (lengthIndex >= 0 && field[lengthIndex] == 1)
        {
            lengthIndex -= flyLength;
        }

        if (lengthIndex >= 0)
        {
            field[lengthIndex] = 1;
        }
    }
}

Console.WriteLine(string.Join(" ", field));