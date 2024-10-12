namespace GameZone.Data
{
    public static class DataConstants
    {
        public const int TitleMinLength = 2;
        public const int TitleMaxLength = 50;
        public const string TitleComment = "Title of the game";
        
        
        public const int DescriptionMinLength = 10;
        public const int DescriptionMaxLength = 500;
        public const string DescriptionComment = "Description of the game";

        public const string ImageUrlComment = "The url of the image";

        public const string PublisherIdComment = "Publisher FK";

        public const string ReleasedOnComment = "The game's release date";

        public const string GenreIdComment = "Genre FK";

        public const string DateFormat = "yyyy-MM-dd";
    }
}
