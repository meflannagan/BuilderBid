using System.ComponentModel.DataAnnotations;

namespace builderbid.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Must be 4 to 8 characters!")]
        public string Password { get; set; }
    }
}