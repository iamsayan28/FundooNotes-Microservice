using System.ComponentModel.DataAnnotations;

namespace Fundoo.User.Api.Contracts
{
    public class UserLoginRequest
    {
        [Required]
        public string Email { get; set; } = "";
        [Required]
        public string Password { get; set; } = "";
    }
}
