namespace GameZone.Models
{
    public class GameInfoViewModel
    {
        public GameInfoViewModel(int id, string title, DateTime releasedOn, string genre, string imageUrl, string publisher)
        {
            Id = id;
            Title = title;
            ReleasedOn = releasedOn.ToString();
            Genre = genre;
            ImageUrl = imageUrl;
            Publisher = publisher;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string ReleasedOn { get; set; }

        public string Genre { get; set; }

        public string Publisher { get; set; }

        public string ImageUrl { get; set; }
    }
}
