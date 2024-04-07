Console.Write("Enter the count of numbers: ");
int n = int.Parse(Console.ReadLine()!);

int[] numbers = new int[n];
int sum = 0;

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine()!);
    sum += numbers[i];
}

bool found = false;
int maxNumber = int.MinValue;
foreach (int num in numbers)
{
    if (num == sum - num)
    {
        Console.WriteLine("Yes");
        Console.WriteLine("Sum = " + num);
        found = true;
        break;
    }
    if (num > maxNumber)
    {
        maxNumber = num;
    }
}

if (!found)
{
    int diff = Math.Abs(maxNumber - (sum - maxNumber));
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + diff);
}