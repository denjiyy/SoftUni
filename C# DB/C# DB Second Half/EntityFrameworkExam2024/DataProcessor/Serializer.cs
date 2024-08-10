using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Xml.Serialization;
using TravelAgency.Data;
using TravelAgency.Data.Models.Enums;
using TravelAgency.DataProcessor.ExportDtos;

namespace TravelAgency.DataProcessor
{
    public class Serializer
    {
        public static string ExportGuidesWithSpanishLanguageWithAllTheirTourPackages(TravelAgencyContext context)
        {
            var guides = context.Guides
                .Where(g => g.Language == Language.Spanish)
                .Select(g => new
                {
                    FullName = g.FullName,
                    TourPackages = g.TourPackagesGuides
                        .Select(tp => new ExportTourPackagesDto
                        {
                            PackageName = tp.TourPackage.PackageName,
                            Description = tp.TourPackage.Description,
                            Price = tp.TourPackage.Price
                        })
                        .OrderByDescending(tp => tp.Price)
                        .ThenBy(tp => tp.PackageName)
                        .ToList()
                })
                .OrderByDescending(g => g.TourPackages.Count)
                .ThenBy(g => g.FullName)
                .ToList();

            var xmlGuides = guides.Select(g => new ExportGuidesDto
            {
                FullName = g.FullName,
                TourPackages = g.TourPackages
            }).ToList();

            var serializer = new XmlSerializer(typeof(List<ExportGuidesDto>), new XmlRootAttribute("Guides"));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            using (var stringWriter = new StringWriter())
            {
                serializer.Serialize(stringWriter, xmlGuides, namespaces);
                return stringWriter.ToString().Trim();
            }
        }

        public static string ExportCustomersThatHaveBookedHorseRidingTourPackage(TravelAgencyContext context)
        {
            var customers = context.Customers
            .Where(c => c.Bookings.Any(b => b.TourPackage.PackageName == "Horse Riding Tour"))
            .Select(c => new
            {
                FullName = c.FullName,
                PhoneNumber = c.PhoneNumber.ToString(),
                Bookings = c.Bookings
                    .Where(b => b.TourPackage.PackageName == "Horse Riding Tour")
                    .Select(b => new
                    {
                        TourPackageName = b.TourPackage.PackageName,
                        Date = b.BookingDate
                    })
                    .ToList()
            })
            .ToList();

            var formattedCustomers = customers
                .Select(c => new
                {
                    FullName = c.FullName,
                    PhoneNumber = c.PhoneNumber.ToString(),
                    Bookings = c.Bookings
                        .Select(b => new
                        {
                            TourPackageName = b.TourPackageName,
                            Date = b.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
                        })
                        .OrderBy(b => b.Date)
                        .ToList()
                })
                .OrderByDescending(c => c.Bookings.Count)
                .ThenBy(c => c.FullName)
                .ToList();

            return JsonSerializer.Serialize(formattedCustomers, new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
            });
        }
    }
}
