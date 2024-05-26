using BaharShop.Common.Enums;
using BaharShop.Domain.Entities.Base;
using System.ComponentModel;

namespace BaharShop.Domain.Entities.Comments
{
    public class Comment : BaseEntity
    {
        [Description("محصول")]
        public int ProductId { get; set; }

        [Description("کاربر")]
        public int UserId { get; set; }

        [Description("سفارش")]
        public int OrderId { get; set; }

        public int DeliveryTime { get; set; }

        [Description("امتیاز")]
        public ScoreEnum Score { get; set; }

        [Description("شرح")]
        public string Description { get; set; }

        [Description("عنوان")]
        public bool DisplayName { get; set; }

        [Description("شرح پاسخ")]
        public string Answer { get; set; }

        [Description("تاریخ پاسخ")]
        public DateTime AnswerDate { get; set; }
    }
}
