using System.ComponentModel;

namespace BaharShop.Application.DTOs.Categories
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Description("نام دسته")]
        public string Name { get; set; }

        [Description("دسته پدر")]
        public int? ParentId { get; set; }

        [Description("دسته های فرزند")]
        public List<CategoryDTO> Children { get; set; }

        public bool HasChild { get; set; }
    }
}
