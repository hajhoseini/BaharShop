using BaharShop.Domain.Entities.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaharShop.Domain.Entities.Categories
{
    public class Category : BaseEntity
    {
        [Description("نام دسته")]
        public string Name { get; set; }

        [Description("دسته پدر")]
        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        [Description("دسته های فرزند")]
        public virtual List<Category> Children { get; set; }
    }
}
