using BaharShop.Domain.Entities.Base;
using BaharShop.Domain.Entities.UserRoles;

namespace BaharShop.Domain.Entities.Roles
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
