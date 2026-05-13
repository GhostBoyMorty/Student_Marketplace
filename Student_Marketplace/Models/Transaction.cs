using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        [Required]
        public int StoreId { get; set; }
        public Store Buyer { get; set; } = null!;

        [Required]
        public int BuyerId { get; set; }
        public User Buyar { get; set; } = null!;

        public decimal Amount { get; set; }

        public string PaymentMethod { get; set; } = string.Empty; // e.g., Cash, Card, EFT

        public string Status { get; set; } = "Completed"; // Pending, Completed, Failed

        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

        public string? Reference { get; set; } // Payment gateway reference
    }
}