using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public class RegisterRequestDto : BaseDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string? ConfirmPassword { get; set; }
    }
}
