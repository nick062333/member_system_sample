using System.ComponentModel.DataAnnotations;

namespace MemberSystem.Web.DTOs
{
    public class UserRegisterDto
    {
        [Required]
        public string Account { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }    
    }
}
