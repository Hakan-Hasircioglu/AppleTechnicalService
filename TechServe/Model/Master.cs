using System.ComponentModel.DataAnnotations;
namespace TechServe.Model
{
    public class Master
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Costumer Name is required")]
        public string CostumerName { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string E_Mail { get; set; }
        [Required(ErrorMessage = "Address Name is required")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "City Name is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Postal Code must be exactly 5 digits")]
        public string PostalCode { get; set; }
        public string UsedParts { get; set; }
        public string DevicelBrand { get; set; }
        public string DevicelModel { get; set; }
        public string TypeOfService { get; set; }
        public string ServiceStatus { get; set; }

        public string ServiceCode { get; set; }
        [Required(ErrorMessage = "Description Name is required")]
        public string Description { get; set; }
        public float Price { get; set; }
        public DateOnly ArrivalDate { get; set; }
        public DateOnly CompletionDate { get; set; }
    }
}
