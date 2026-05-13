using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int BuyerId { get; set; }

        public User Buyer { get; set; } = null!;

        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = "Pending";

        public DateTime OrderDate { get; set; }
            = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the order items associated with this order.
        /// </summary>
        public ICollection<OrderItem> OrderItems
            { get; set; }
            = new List<OrderItem>();
    }
}