using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace contact_Manger.DTOs
{
    public record UserDto(
        [Required (ErrorMessage = "Name is required")]
        string  Password,

        [Required(ErrorMessage = "Password is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        string Email);

}
