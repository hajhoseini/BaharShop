using BaharShop.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaharShop.Domain.Entities.Categories
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual List<Category> Children { get; set; }
    }
}
