using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SeminarHub.Data.DataConstants;

namespace SeminarHub.Data
{
    public class Seminar
    {
        public Seminar()
        {
            SeminarsParticipants = new HashSet<SeminarParticipant>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(TopicMinLength)]
        [MaxLength(TopicMaxLength)]
        [Comment(TopicComment)]
        public string Topic { get; set; } = string.Empty;

        [Required]
        [MinLength(LecturerMinLength)]
        [MaxLength(LecturerMaxLength)]
        [Comment(LecturerComment)]
        public string Lecturer { get; set; } = string.Empty;

        [Required]
        [MinLength(DetailsMinLength)]
        [MaxLength(DetailsMaxLength)]
        [Comment(DetailsComment)]
        public string Details { get; set; } = string.Empty;

        [Required]
        public string OrganizerId { get; set; } = string.Empty;
        [ForeignKey(nameof(OrganizerId))]
        public IdentityUser Organizer { get; set; } = null!;

        [Required]
        [DisplayFormat(DataFormatString = DateFormat, ApplyFormatInEditMode = true)]
        [Comment(DateComment)]
        public DateTime DateAndTime { get; set; }

        [Required]
        [Range(LowerDurationLimit, UpperDurationLimit)]
        [Comment(DurationComment)]
        public int Duration { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public ICollection<SeminarParticipant> SeminarsParticipants { get; set; }
    }
}
