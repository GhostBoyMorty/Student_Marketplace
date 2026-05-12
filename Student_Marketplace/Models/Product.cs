using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int Quantity { get; set; } = 1;

        public string? ImageUrl { get; set; }

        public string? Category { get; set; }

        public bool IsAvailable { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Foreign key — listing belongs to a user
        public int UserId { get; set; }
        public User? User { get; set; }

        // Foreign key — listing optionally belongs to a store
        // nullable because not every listing needs a store
        public int? StoreId { get; set; }
        public Store? Store { get; set; }
    }
}