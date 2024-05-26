using System.ComponentModel;

namespace BaharShop.Application.DTOs.Products
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Description("عنوان محصول")]
        public string Title { get; set; }

        [Description("شرح محصول")]
        public string Description { get; set; }

        [Description("دسته")]
        public int CategoryId { get; set; }

        [Description("قیمت")]
        public decimal Price { get; set; }
    }
}
