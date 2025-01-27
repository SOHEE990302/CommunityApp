using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunityApp.Models
{
    public class Province
    {
        [Key]
        [Required]
        public string? ProvinceCode { get; set; } // Primary Key (예: BC)

        [Required]
        public string? ProvinceName { get; set; } // Example: British Columbia

        // City와 1:N 관계 설정
        public ICollection<City> Cities { get; set; } = new List<City>();
    }
}
