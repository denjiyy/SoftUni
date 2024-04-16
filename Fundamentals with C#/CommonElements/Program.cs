List<string> firstArray = Console.ReadLine()!
    .Split(' ')
    .ToList();

List<string> secondArray = Console.ReadLine()!
    .Split(' ')
    .ToList();

List<string> thirdArray = new List<string>();

for (int i = 0; i < firstArray.Count; i++)
{
    for (int j = 0; j < secondArray.Count; j++)
    {
        if (firstArray[i] == secondArray[j])
        {
            thirdArray.Add(firstArray[i]);
            break;
        }
    }
}

Console.WriteLine(string.Join(" ", thirdArray));