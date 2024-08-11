using BaharShop.Domain.Entities.Base;
using BaharShop.Domain.Entities.CartItems;
using BaharShop.Domain.Entities.Users;

namespace BaharShop.Domain.Entities.Carts
{
    public class Cart : BaseEntity
    {
        public virtual User User { get; set; }

        public int? UserId { get; set; }

        public Guid BrowserId { get; set; }

        public bool Finished { get; set; }

        public ICollection<CartItem> CartItems { get; set; }
    }
}
