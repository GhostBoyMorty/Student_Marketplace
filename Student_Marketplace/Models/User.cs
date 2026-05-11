using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string StudentNumber { get; set; } = string.Empty;

        public string? Faculty { get; set; }

        public string? University { get; set; }

        public string? ProfileImage { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation — one user can have one store (optional)
        public Store? Store { get; set; }

        // Navigation — one user can have many listings (without a store)
        public ICollection<Product> Products { get; set; } = new List<Product>();

        // Navigation — one user can have many orders as a buyer
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}