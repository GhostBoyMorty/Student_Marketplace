using System.ComponentModel.DataAnnotations;

namespace Student_Marketplace.Models
{
    public class Verification
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        // ID Card Image
        [Required]
        public string IdCardImageUrl { get; set; } = string.Empty;

        // Selfie holding the ID Card
        [Required]
        public string SelfieWithIdImageUrl { get; set; } = string.Empty;

        public string? IdNumber { get; set; }           // Student ID / National ID
        public string? FullNameOnId { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

        public VerificationStatus Status { get; set; } = VerificationStatus.Pending;

        public DateTime? ReviewedAt { get; set; }

        public int? ReviewedByAdminId { get; set; }     // Optional: Which admin reviewed it
        public string? RejectionReason { get; set; }    // If rejected

        public DateTime? VerifiedAt { get; set; }
    }

    // Enum for clean status management
    public enum VerificationStatus
    {
        Pending = 0,
        Approved = 1,
        Rejected = 2
    }
}