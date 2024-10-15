namespace SeminarHub.Data
{
    public static class DataConstants
    {
        public const int TopicMinLength = 3;
        public const int TopicMaxLength = 100;
        public const string TopicComment = "The topic of the seminar";

        public const int LecturerMinLength = 5;
        public const int LecturerMaxLength = 60;
        public const string LecturerComment = "The lecturer of the seminar";

        public const int DetailsMinLength = 10;
        public const int DetailsMaxLength = 500;
        public const string DetailsComment = "The details of the seminar";

        public const string DateFormat = "dd/MM/yyyy HH:mm";
        public const string DateComment = "The date of the seminar";

        public const int LowerDurationLimit = 30;
        public const int UpperDurationLimit = 180;
        public const string DurationComment = "The duration of the seminar";

        public const int NameMinLength = 3;
        public const int NameMaxLength = 50;
        public const string CategoryNameComment = "The category's name";

        public const string All = "All";
        public const string Seminar = "Seminar";
    }
}
