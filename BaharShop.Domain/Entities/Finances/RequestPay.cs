using BaharShop.Domain.Entities.Base;
using BaharShop.Domain.Entities.Orders;
using BaharShop.Domain.Entities.Users;

namespace BaharShop.Domain.Entities.Finances
{
    public class RequestPay : BaseEntity
    {
        public Guid Guid { get; set; }

        public virtual User User { get; set; }

        public int UserId { get; set; }

        public decimal Amount { get; set; }

        public bool IsPay { get; set; }

        public DateTime? PayDate { get; set; }

        public string Authority { get; set; } = "";

        public long RefId { get; set; } = 0;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
