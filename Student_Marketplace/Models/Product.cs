using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        public int Stock { get; set; } = 1;

        public string? ImageUrl { get; set; }

        [Required]
        public int StoreId { get; set; }
        public Store Store { get; set; } = null!;

        public string Category { get; set; } = string.Empty;   // e.g., Electronics, Clothing, Food, etc.

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}