using System.ComponentModel.DataAnnotations;

namespace FeedbackApp.Data
{
    public partial class FeedbackMessage
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide name")]
        [MaxLength(100, ErrorMessage = "Name is limited to 100 characters.")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Please provide message")]
        [MaxLength(500, ErrorMessage = "Message is limited to 500 characters.")]
        public string Message { get; set; } = null!;
        public DateTime Submitted { get; set; }
    }
}