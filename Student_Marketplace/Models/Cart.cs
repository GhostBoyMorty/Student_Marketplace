using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<CartItem> CartItems { get; set; }
            = new List<CartItem>();
    }
}