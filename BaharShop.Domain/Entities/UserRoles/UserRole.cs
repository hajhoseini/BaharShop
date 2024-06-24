using BaharShop.Domain.Entities.Roles;
using BaharShop.Domain.Entities.Users;

namespace BaharShop.Domain.Entities.UserRoles
{
    public class UserRole
    {
        public long Id { get; set; }

        public virtual User User { get; set; }

        public long UserId { get; set; }

        public virtual Role Role { get; set; }

        public long RoleId { get; set; }
    }
}
