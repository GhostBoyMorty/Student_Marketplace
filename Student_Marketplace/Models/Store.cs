using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string StoreName { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? LogoUrl { get; set; }

        [Required]
        public int OwnerId { get; set; }           // Foreign Key
        public User Owner { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

        // Navigation
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}