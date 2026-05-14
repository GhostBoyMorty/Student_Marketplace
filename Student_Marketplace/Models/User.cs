using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; }

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        public string? ProfilePicture { get; set; }

        public string? Bio { get; set; }

        public DateTime DateJoined { get; set; } = DateTime.UtcNow;

        public bool IsVerified { get; set; } = false;

        // Navigation Properties
        public ICollection<Store> Stores { get; set; } = new List<Store>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        //public ICollection<ChatsM> ChatsSent { get; set; } = new List<ChatsM>();

        public ICollection<Store> Store { get; set; } = new List<Store>();
        public ICollection<Order> Order { get; set; } = new List<Order>();
        
        /*public ICollection<ChatsM> ChatsSentt { get; set; } = new List<ChatsM>();
        public ICollection<ChatsM> ChatsReceived { get; set; } = new List<ChatsM>();*/
    }
}