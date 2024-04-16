int n = int.Parse(Console.ReadLine());

int[] array1 = new int[n];
int[] array2 = new int[n];


for (int i = 0; i < n; i++)
{
    string[] pair = Console.ReadLine().Split();
    array1[i] = int.Parse(pair[0]);
    array2[i] = int.Parse(pair[1]);
}

int[] zigzagArray1 = new int[n];
int[] zigzagArray2 = new int[n];

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        zigzagArray1[i] = array1[i];
        zigzagArray2[i] = array2[i];
    }
    else
    {
        zigzagArray1[i] = array2[i];
        zigzagArray2[i] = array1[i];
    }
}

Console.WriteLine(string.Join(" ", zigzagArray1));
Console.WriteLine(string.Join(" ", zigzagArray2));