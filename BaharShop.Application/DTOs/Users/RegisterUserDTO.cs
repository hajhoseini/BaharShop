using BaharShop.Application.DTOs.Roles;

namespace BaharShop.Application.DTOs.Users
{
    public class RegisterUserDTO
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string RePassword { get; set; }

        public List<RoleDTO> roles { get; set; }
    }
}
