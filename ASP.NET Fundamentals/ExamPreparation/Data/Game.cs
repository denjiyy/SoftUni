using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static GameZone.Data.DataConstants;

namespace GameZone.Data
{
    public class Game
    {
        public Game()
        {
            GamersGames = new HashSet<GamerGame>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(TitleMinLength)]
        [MaxLength(TitleMaxLength)]
        [Comment(TitleComment)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(DescriptionMinLength)]
        [MaxLength(DescriptionMaxLength)]
        [Comment(DescriptionComment)]
        public string Description { get; set; } = string.Empty;

        [Comment(ImageUrlComment)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Comment(PublisherIdComment)]
        public string PublisherId { get; set; } = string.Empty;
        [ForeignKey(nameof(PublisherId))]
        public IdentityUser Publisher { get; set; } = null!;

        [Required]
        [DisplayFormat(DataFormatString = DateFormat)]
        [Comment(ReleasedOnComment)]
        public DateTime ReleasedOn { get; set; }

        [Required]
        [Comment(GenreIdComment)]
        public int GenreId { get; set; }

        [Required]
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;

        public ICollection<GamerGame> GamersGames { get; set; }
    }
}
