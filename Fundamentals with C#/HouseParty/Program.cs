int numCommands = int.Parse(Console.ReadLine());
HashSet<string> guestList = new HashSet<string>();

for (int i = 0; i < numCommands; i++)
{
    string[] command = Console.ReadLine().Split();
    string name = command[0];

    if (command[2] == "going!")
    {
        if (guestList.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            guestList.Add(name);
        }
    }
    else if (command[2] == "not")
    {
        if (guestList.Contains(name))
        {
            guestList.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}

foreach (string guest in guestList)
{
    Console.WriteLine(guest);
}