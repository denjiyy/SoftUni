using System.ComponentModel.DataAnnotations;
using static SeminarHub.Data.DataConstants;

namespace SeminarHub.Models
{
    public class DetailsViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(TopicMaxLength, MinimumLength = TopicMinLength)]
        public string Topic { get; set; } = string.Empty;

        [Required]
        [StringLength(DetailsMaxLength, MinimumLength = DetailsMinLength)]
        public string Details { get; set; } = string.Empty;

        [Required]
        [StringLength(LecturerMaxLength, MinimumLength = LecturerMinLength)]
        public string Lecturer { get; set; } = string.Empty;

        [Required]
        [Range(LowerDurationLimit, UpperDurationLimit)]
        public int Duration { get; set; }

        [Required]
        public string Organizer { get; set; } = string.Empty;

        [Required]
        [DisplayFormat(DataFormatString = DateFormat)]
        public DateTime DateAndTime { get; set; }

        [Required]
        public string Category { get; set; } = string.Empty;
    }
}
