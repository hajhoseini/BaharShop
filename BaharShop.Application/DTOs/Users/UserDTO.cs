namespace BaharShop.Application.DTOs.Users
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public string Roles { get; set; }
    }
}
