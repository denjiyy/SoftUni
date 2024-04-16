int length = int.Parse(Console.ReadLine()!);
List<int> sequence = new List<int>(length);

string command = Console.ReadLine()!;
List<int> bestSequence = new List<int>(length);

int bestSequenceIndex = 0;
int bestSequenceSum = 0;
int leftMostIndex = 0;
int sequenceIndex = 0;
int bestSubsequence = 0;

while (command != "Clone them!")
{
    sequence = command!
        .Split("!", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToList();

    sequenceIndex++;

    int leftIndex = sequence.Count - 1;
    int subsequence = 1;
    int sum = 0;

    for (int i = 0; i < sequence.Count; i++)
    {
        sum += sequence[i];
        if (i != sequence.Count - 1 && sequence[i] == sequence[i + 1] && sequence[i] == 1)
        {
            subsequence++;
            if (leftIndex > i)
            {
                leftIndex = i;
            }
        }
    }

    if (subsequence > bestSubsequence
        || subsequence == bestSubsequence && leftIndex < leftMostIndex
        || subsequence == bestSubsequence && leftIndex == leftMostIndex && sum > bestSequenceSum)
    {
        bestSubsequence = subsequence;
        leftMostIndex = leftIndex;
        bestSequenceIndex = sequenceIndex;
        bestSequenceSum = sum;
        bestSequence = sequence.ToList();
    }

    command = Console.ReadLine()!;
}

Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
Console.WriteLine($"{string.Join(" ", bestSequence)}");