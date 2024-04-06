int N1 = int.Parse(Console.ReadLine()!);
int N2 = int.Parse(Console.ReadLine()!);
char operation = char.Parse(Console.ReadLine()!);

double result = 0;
string message = "";

switch (operation)
{
    case '+':
        result = N1 + N2;
        message = $"{N1} + {N2} = {result} - {(result % 2 == 0 ? "even" : "odd")}";
        break;
    case '-':
        result = N1 - N2;
        message = $"{N1} - {N2} = {result} - {(result % 2 == 0 ? "even" : "odd")}";
        break;
    case '*':
        result = N1 * N2;
        message = $"{N1} * {N2} = {result} - {(result % 2 == 0 ? "even" : "odd")}";
        break;
    case '/':
        if (N2 == 0)
            message = $"Cannot divide {N1} by zero";
        else
            message = $"{N1} / {N2} = {(double)N1 / N2:f2}";
        break;
    case '%':
        if (N2 == 0)
            message = $"Cannot divide {N1} by zero";
        else
            message = $"{N1} % {N2} = {N1 % N2}";
        break;
}

Console.WriteLine(message);