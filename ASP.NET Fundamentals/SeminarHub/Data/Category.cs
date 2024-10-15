using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static SeminarHub.Data.DataConstants;

namespace SeminarHub.Data
{
    public class Category
    {
        public Category()
        {
            Seminars = new HashSet<Seminar>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        [Comment(CategoryNameComment)]
        public string Name { get; set; }

        public ICollection<Seminar> Seminars { get; set; }
    }
}
