using Articles;
using System;

class Program
{
    private static void Main(string[] args)
    {
        List<string> book = Console.ReadLine()!
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        Article article = new Article(book[0], book[1], book[2]);

        int n = int.Parse(Console.ReadLine()!);

        while (n > 0)
        {
            List<string> commands = Console.ReadLine()!
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            switch (commands[0])
            {
                case "Edit":
                    article.Edit(commands[1]);
                    break;
                case "ChangeAuthor":
                    article.ChangeAuthor(commands[1]);
                    break;
                case "Rename":
                    article.Rename(commands[1]);
                    break;
                default:
                    break;
            }

            n--;
        }

        Console.WriteLine(article.ToString());
    }
}