using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static GameZone.Data.DataConstants;
using GameZone.Data;

namespace GameZone.Models
{
    public class DetailsViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = null!;

        [Required]
        public string Publisher { get; set; } = string.Empty;

        [Required]
        [DisplayFormat(DataFormatString = DataConstants.DateFormat)]
        public DateTime ReleasedOn { get; set; }

        [Required]
        public string Genre { get; set; }
    }
}
