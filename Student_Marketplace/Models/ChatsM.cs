using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class ChatsM
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SenderId { get; set; }
        public User Sender { get; set; } = null!;

        [Required]
        public int ReceiverId { get; set; }
        public User Receiver { get; set; } = null!;

        [Required]
        public string Message { get; set; } = string.Empty;

        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        public bool IsRead { get; set; } = false;

        // Optional: For message editing/deletion tracking
        public bool IsDeleted { get; set; } = false;
    }
}