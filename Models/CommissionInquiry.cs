using System.ComponentModel.DataAnnotations;

namespace GhostShoes_Art_Site.Models
{
    public class CommissionInquiry
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [StringLength(150)]
        public string Email { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Subject { get; set; }

        [Required(ErrorMessage = "Please describe what you're looking for.")]
        [StringLength(2000)]
        public string Message { get; set; } = string.Empty;

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    }
}