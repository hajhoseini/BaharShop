using BaharShop.Domain.Entities.Base;
using System.ComponentModel;

namespace BaharShop.Domain.Entities.Products
{
    public class Product : BaseEntity
    {
        [Description("عنوان محصول")]
        public string Title { get; set; }

        [Description("شرح محصول")]
        public string Description { get; set; }

        [Description("دسته")]
        public int CategoryId { get; set; }

        [Description("قیمت")]
        public decimal Price { get; set; }

        [Description("تعداد موجودی")]
        public int? Inventory { get; set; }

        [Description("وضعیت فعال بودن")]
        public bool? IsActive { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }

        public virtual ICollection<ProductFeature> ProductFeatures { get; set; }
    }
}
