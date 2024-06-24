using BaharShop.Domain.Entities.UserRoles;

namespace BaharShop.Domain.Entities.Roles
{
    public class Role
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
