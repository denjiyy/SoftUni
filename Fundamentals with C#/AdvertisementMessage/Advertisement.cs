public class Advertisement
{
    public string[] phrases = new string[] {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can't live without this product."
        };

    public string[] events = new string[]
    {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
    };

    public string[] authors = new string[]
    {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
    };

    public string[] cities = new string[]
    {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
    };

    public string GenerateRandomMessage()
    {
        Random rnd = new Random();

        int index = rnd.Next(phrases.Length);
        string phrase = phrases[index];

        index = rnd.Next(events.Length);
        string ev = events[index];

        index = rnd.Next(authors.Length);
        string auth = authors[index];

        index = rnd.Next(cities.Length);
        string city = cities[index];

        return $"{phrase} {ev} {auth} - {city}.";
    }
}