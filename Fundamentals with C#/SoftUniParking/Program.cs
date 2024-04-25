int n = int.Parse(Console.ReadLine()!);
Dictionary<string, string> dictionary = new Dictionary<string, string>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()!
        .Split()
        .ToArray();

    string register = input[0];
    string username = input[1];
    //string licensePlateNumber = input[2];

    if (register == "register")
    {
        string licensePlateNumber = input[2];
        if (!dictionary.ContainsKey(username))
        {
            dictionary.Add(username, licensePlateNumber);
            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
            continue;
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
            continue;
        }
    }

    if (register == "unregister")
    {
        if (dictionary.ContainsKey(username))
        {
            dictionary.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
            continue;
        }
        else
        {
            Console.WriteLine($"ERROR: user {username} not found");
            continue;
        }
    }
}

foreach (var item in dictionary)
{
    Console.WriteLine(item.Key + " => " + item.Value);
}