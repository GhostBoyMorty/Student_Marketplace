using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public DateTime EventDate { get; set; }

        public string? Location { get; set; }  // e.g., "Campus Hall A", "Online"

        public string? ImageUrl { get; set; }   // Banner or poster for the event

        [Required]
        public int OrganizerId { get; set; }
        public User Organizer { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

        // Optional: For paid events
        public decimal? TicketPrice { get; set; }
        public int? MaxAttendees { get; set; }
    }
}