using System.ComponentModel.DataAnnotations;

namespace NexusPropertyPortal.Models
{
    public class Property
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Suburb { get; set; }

        [Range(1, 10, ErrorMessage = "Bedrooms must be between 1 and 10")]
        public int Bedrooms { get; set; }

        [Range(1, 10, ErrorMessage = "Bathrooms must be between 1 and 10")]
        public int Bathrooms { get; set; }

        [Display(Name = "Square Meters")]
        [Range(20, 2000, ErrorMessage = "Invalid size")]
        public int SquareMeters { get; set; }

        [Display(Name = "Garages")]
        [Range(0, 5)]
        public int GarageCount { get; set; }

        [DataType(DataType.Currency)]
        [Range(100000, 50000000, ErrorMessage = "Price must be at least R100,000")]
        public decimal Price { get; set; }
    }
}