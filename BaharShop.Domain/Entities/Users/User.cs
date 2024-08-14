using BaharShop.Domain.Entities.Base;
using BaharShop.Domain.Entities.Orders;
using BaharShop.Domain.Entities.UserRoles;

namespace BaharShop.Domain.Entities.Users
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
