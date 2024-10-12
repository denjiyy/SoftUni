using GameZone.Data;
using System.ComponentModel.DataAnnotations;
using static GameZone.Data.DataConstants;

namespace GameZone.Models
{
    public class GameFormViewModel
    {
        public GameFormViewModel()
        {
            Genres = new HashSet<GenreViewModel>();
        }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [MinLength(DescriptionMinLength)]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int GenreId { get; set; }


        [Required]
        public string ReleasedOn { get; set; } = string.Empty;

        public ICollection<GenreViewModel> Genres { get; set; }
    }
}
