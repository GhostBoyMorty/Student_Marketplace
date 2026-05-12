using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string StoreName { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? StorePassword { get; set; }

        public string? LogoUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Foreign key — links store to the user who created it
        public int UserId { get; set; }
        public User? User { get; set; }

        // Navigation — a store can have many listings
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}