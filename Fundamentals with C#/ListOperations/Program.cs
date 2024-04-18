List<int> list = Console.ReadLine()!
                .Split()
                .Select(int.Parse)
                .ToList();

while (true)
{
    string command = Console.ReadLine()!;

    if (command == "End")
    {
        break;
    }

    string[] elements = command.Split();

    if (elements[0] == "Add")
    {
        int number = int.Parse(elements[1]);
        list.Add(number);
    }

    if (elements[0] == "Insert")
    {
        int number = int.Parse(elements[1]);
        int index = int.Parse(elements[2]);

        if (index >= 0 && index < list.Count)
        {
            list.Insert(index, number);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }

    if (elements[0] == "Remove")
    {
        int index = int.Parse(elements[1]);

        if (index >= 0 && index < list.Count)
        {
            list.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }

    if (elements[0] == "Shift" && elements[1] == "left")
    {
        int count = int.Parse(elements[2]);

        for (int i = 0; i < count % list.Count; i++)
        {
            int firstEl = list[0];
            list.RemoveAt(0);
            list.Add(firstEl);
        }
    }

    if (elements[0] == "Shift" && elements[1] == "right")
    {
        int count = int.Parse(elements[2]);

        for (int i = 0; i < count % list.Count; i++)
        {
            int lastEl = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            list.Insert(0, lastEl);
        }
    }
}

Console.WriteLine(string.Join(" ", list));