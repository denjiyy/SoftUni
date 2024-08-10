using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;
using TravelAgency.Data;
using TravelAgency.Data.Models;
using TravelAgency.DataProcessor.ImportDtos;

namespace TravelAgency.DataProcessor
{
    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data format!";
        private const string DuplicationDataMessage = "Error! Data duplicated.";
        private const string SuccessfullyImportedCustomer = "Successfully imported customer - {0}";
        private const string SuccessfullyImportedBooking = "Successfully imported booking. TourPackage: {0}, Date: {1}";

        public static string ImportCustomers(TravelAgencyContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ImportCustomersDto>), new XmlRootAttribute("Customers"));
            List<ImportCustomersDto> customerDtos;

            using (var reader = new StringReader(xmlString))
            {
                customerDtos = (List<ImportCustomersDto>)xmlSerializer.Deserialize(reader);
            }

            var existingCustomers = context.Customers
                .ToList();

            var existingFullNames = existingCustomers.Select(c => c.FullName).ToHashSet();
            var existingEmails = existingCustomers.Select(c => c.Email).ToHashSet();
            var existingPhoneNumbers = existingCustomers.Select(c => c.PhoneNumber).ToHashSet();

            List<Customer> customersToAdd = new List<Customer>();

            foreach (var dto in customerDtos)
            {
                if (!IsValid(dto))
                {
                    var validationErrors = new List<ValidationResult>();
                    Validator.TryValidateObject(dto, new ValidationContext(dto), validationErrors, true);

                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (existingFullNames.Contains(dto.FullName) ||
                    existingEmails.Contains(dto.Email) ||
                    existingPhoneNumbers.Contains(dto.PhoneNumber))
                {
                    sb.AppendLine(DuplicationDataMessage);
                    continue;
                }

                Customer customer = new Customer
                {
                    FullName = dto.FullName,
                    Email = dto.Email,
                    PhoneNumber = dto.PhoneNumber
                };

                customersToAdd.Add(customer);
                sb.AppendLine(string.Format(SuccessfullyImportedCustomer, dto.FullName));

                existingFullNames.Add(dto.FullName);
                existingEmails.Add(dto.Email);
                existingPhoneNumbers.Add(dto.PhoneNumber);
            }

            if (customersToAdd.Count > 0)
            {
                context.Customers.AddRange(customersToAdd);
                context.SaveChanges();
            }

            return sb.ToString().Trim();
        }

        public static string ImportBookings(TravelAgencyContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            List<ImportBookingsDto> bookingsDtos = JsonConvert.DeserializeObject<List<ImportBookingsDto>>(jsonString);
            List<Booking> bookings = new List<Booking>();

            foreach (var bookingDto in bookingsDtos)
            {
                if (!DateTime.TryParseExact(bookingDto.BookingDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime bookingDate))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var customer = context.Customers.FirstOrDefault(c => c.FullName == bookingDto.CustomerName);
                var tourPackage = context.TourPackages.FirstOrDefault(tp => tp.PackageName == bookingDto.TourPackageName);

                if (customer == null || tourPackage == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Booking booking = new Booking
                {
                    BookingDate = bookingDate,
                    CustomerId = customer.Id,
                    TourPackageId = tourPackage.Id,
                    Customer = customer,
                    TourPackage = tourPackage
                };

                bookings.Add(booking);
                sb.AppendLine(string.Format(SuccessfullyImportedBooking, tourPackage.PackageName, bookingDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)));
            }

            if (bookings.Count > 0)
            {
                context.Bookings.AddRange(bookings);
                context.SaveChanges();
            }

            return sb.ToString().Trim();
        }

        public static bool IsValid(object dto)
        {
            var validateContext = new ValidationContext(dto);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(dto, validateContext, validationResults, true);

            foreach (var validationResult in validationResults)
            {
                string currValidationMessage = validationResult.ErrorMessage;
            }

            return isValid;
        }
    }
}
