using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CartId { get; set; }

        public Cart Cart { get; set; } = null!;

        [Required]
        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;

        public int Quantity { get; set; } = 1;

        public DateTime AddedAt { get; set; }
            = DateTime.UtcNow;
    }
}