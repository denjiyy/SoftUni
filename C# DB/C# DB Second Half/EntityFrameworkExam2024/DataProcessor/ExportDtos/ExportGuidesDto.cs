using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TravelAgency.Data.Models.Enums;

namespace TravelAgency.DataProcessor.ExportDtos
{
    [XmlType("Guide")]
    public class ExportGuidesDto
    {
        public ExportGuidesDto()
        {
            TourPackages = new List<ExportTourPackagesDto>();    
        }

        [XmlElement("FullName")]
        [Required]
        [MinLength(4)]
        [MaxLength(60)]
        public string FullName { get; set; }

        [XmlArray("TourPackages")]
        public List<ExportTourPackagesDto> TourPackages { get; set; }
    }

    [XmlType("TourPackage")]
    public class ExportTourPackagesDto
    {
        [XmlElement("Name")]
        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        public string PackageName { get; set; }

        [XmlElement("Description")]
        [MaxLength(200)]
        public string Description { get; set; }

        [XmlElement("Price")]
        [Required]
        public decimal Price { get; set; }
    }
}
