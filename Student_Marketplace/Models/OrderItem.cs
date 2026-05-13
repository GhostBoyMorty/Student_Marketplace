using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        // ORDER
        [Required]
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        // PRODUCT
        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        // QUANTITY
        public int Quantity { get; set; } = 1;

        // PRICE AT TIME OF PURCHASE
        public decimal UnitPrice { get; set; }

        // TOTAL
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}