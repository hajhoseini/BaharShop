using BaharShop.Common.Enums;
using BaharShop.Domain.Entities.Base;

namespace BaharShop.Domain.Entities.Comments
{
    public class Comment : BaseEntity
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public int DeliveryTime { get; set; }
        public ScoreEnum Score { get; set; }
        public string Description { get; set; }
        public bool DisplayName { get; set; }
        public string Answer { get; set; }
        public DateTime AnswerDate { get; set; }
    }
}
