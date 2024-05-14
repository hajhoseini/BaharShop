using BaharShop.Common.Enums;
using BaharShop.Domain.Entities.Base;

namespace BaharShop.Domain.Entities.Customers
{
    public class Customer : BaseEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public GenderEnum? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
