using SeminarHub.Data;
using System.ComponentModel.DataAnnotations;
using static SeminarHub.Data.DataConstants;

namespace SeminarHub.Models
{
    public class SeminarFormViewModel
    {
        public SeminarFormViewModel()
        {
            Categories = new HashSet<CategoryViewModel>();
        }

        [Required]
        [StringLength(TopicMaxLength, MinimumLength = TopicMinLength)]
        public string Topic { get; set; } = string.Empty;

        [Required]
        [MinLength(LecturerMinLength)]
        [MaxLength(LecturerMaxLength)]
        public string Lecturer { get; set; } = string.Empty;

        [Required]
        [MinLength(DetailsMinLength)]
        [MaxLength(DetailsMaxLength)]
        public string Details { get; set; } = string.Empty;

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = DateFormat, ApplyFormatInEditMode = true)]
        public string DateAndTime { get; set; } = string.Empty;

        [Required]
        [Range(LowerDurationLimit, UpperDurationLimit)]
        public int Duration { get; set; }

        public ICollection<CategoryViewModel> Categories { get; set; }
    }
}
