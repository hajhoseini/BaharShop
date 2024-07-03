using System.ComponentModel.DataAnnotations;

namespace BaharShop.Domain.Entities.Base
{
    public abstract class BaseEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }

        public DateTime InsertDate { get; set; } = DateTime.Now;

        public DateTime? UpdateDate { get; set; }

        public bool IsRemoved { get; set; } = false;

        public DateTime? RemoveDate { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<int>
    {

    }
}
