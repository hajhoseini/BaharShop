using BaharShop.Domain.Entities.Base;
using BaharShop.Domain.Entities.Roles;
using BaharShop.Domain.Entities.Users;

namespace BaharShop.Domain.Entities.UserRoles
{
    public class UserRole : BaseEntity
    {
        public int Id { get; set; }

        public virtual User User { get; set; }

        public int UserId { get; set; }

        public virtual Role Role { get; set; }

        public int RoleId { get; set; }
    }
}
