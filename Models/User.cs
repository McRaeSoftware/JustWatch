using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JustWatch.Models
{
    public class User
    {
        [Key]
        public int User_ID { get; set; }

        [Required]
        [DisplayName("First name")]
        [RegularExpression(@"^[a-zA-Z]+$",
            ErrorMessage = "First name can only contain letters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$",
            ErrorMessage = "Surname can only contain letters.")]
        public string Surname { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]+$",
            ErrorMessage = "Username can only contain letters and numbers.")]
        public string Username { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$",
            ErrorMessage = "Email must be a valid format")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,30}$",
            ErrorMessage = "Password must be between 8 and 30 characters and contain atleast 1 lowercase, uppercase, number and symbol")]
        public string Password { get; set; } = string.Empty;
    }
}
