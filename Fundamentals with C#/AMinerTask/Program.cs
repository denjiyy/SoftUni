var dictionary = new Dictionary<string, int>();

string input;
int quantity;
while ((input = Console.ReadLine()!) != "stop")
{
    if (!dictionary.ContainsKey(input))
    {
        dictionary.Add(input, 0);
    }

    quantity = int.Parse(Console.ReadLine()!);
    dictionary[input] += quantity;
}

foreach (var item in dictionary)
{
    Console.WriteLine(item.Key + " -> " + item.Value);
}