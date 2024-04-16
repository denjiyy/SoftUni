List<string> symbols = Console.ReadLine()!
    .Split(' ')
    .ToList();

int bestCount = 0;
string bestSymbol = null!;

for (int i = 0; i < symbols.Count; i++)
{
    int count = 1;
    for (int j = i + 1; j < symbols.Count; j++)
    {
        if (symbols[i] == symbols[j])
        {
            count++;

            if (bestCount < count)
            {
                bestCount = count;
                bestSymbol = symbols[i];
            }
        }
        else
        {
            break;
        }
    }
}

for (int i = 0; i < bestCount; i++)
{
    Console.Write($"{bestSymbol} ");
}