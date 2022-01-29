using System.ComponentModel.DataAnnotations;

namespace OA1.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
