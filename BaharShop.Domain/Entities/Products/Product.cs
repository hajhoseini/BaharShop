using BaharShop.Domain.Entities.Base;
using BaharShop.Domain.Entities.Categories;
using System.ComponentModel;

namespace BaharShop.Domain.Entities.Products
{
    public class Product : BaseEntity
    {
        [Description("عنوان محصول")]
        public string Title { get; set; }

        [Description("شرح محصول")]
        public string Description { get; set; }

        public virtual Category Category { get; set; }

        [Description("دسته")]
        public int CategoryId { get; set; }

        [Description("قیمت")]
        public decimal Price { get; set; }

        [Description("تعداد موجودی")]
        public int? Inventory { get; set; }

        [Description("وضعیت فعال بودن")]
        public bool? IsActive { get; set; }

        public int ViewCount { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }

        public virtual ICollection<ProductFeature> ProductFeatures { get; set; }
    }
}
