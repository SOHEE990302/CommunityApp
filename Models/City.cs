using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunityApp.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; } // Primary Key (자동 증가)

        [Required]
        public string? CityName { get; set; } // Example: Surrey

        [Required]
        public int Population { get; set; } // Example: 300,000

        [Required]
        public string? ProvinceCode { get; set; } // Foreign Key

        [ForeignKey("ProvinceCode")]
        public Province? Province { get; set; } // Navigation Property
    }
}
