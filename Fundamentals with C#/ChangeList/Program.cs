List<int> integers = Console.ReadLine()!
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string command;
while ((command = Console.ReadLine()!) != "end")
{
    List<string> commandTokens = command
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToList();

    if (commandTokens[0] == "Delete")
    {
        for (int i = 0; i < integers.Count; i++)
        {
            if (int.Parse(commandTokens[1]) == integers[i])
            {
                integers.Remove(integers[i]);
            }
        }
    }
    else if (commandTokens[0] == "Insert")
    {
        integers.Insert(int.Parse(commandTokens[2]), int.Parse(commandTokens[1]));
    }
}

Console.WriteLine(string.Join(" ", integers));