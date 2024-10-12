using System.ComponentModel.DataAnnotations;

namespace GameZone.Data
{
    public class Genre
    {
        public Genre()
        {
            Games = new HashSet<Game>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Game> Games { get; set; }
    }
}
