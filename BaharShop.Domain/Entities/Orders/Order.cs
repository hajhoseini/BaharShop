using BaharShop.Common.Enums;
using BaharShop.Domain.Entities.Base;
using System.ComponentModel;

namespace BaharShop.Domain.Entities.Orders
{
    public class Order : BaseEntity
    {
        [Description("کدسفارش")]
        public int Code { get; set; }

        [Description("مشتری")]
        public int CustomerId { get; set; }

        [Description("آدرس")]
        public int AddressId { get; set; }

        [Description("تاریخ سفارش")]
        public DateTime OrderDate { get; set; }

        [Description("تاریخ تحویل")]
        public DateTime DeliveryDate { get; set; }

        [Description("مبلغ کل")]
        public decimal OrderPrice { get; set; }

        [Description("هزینه ارسال")]
        public decimal SendPrice { get; set; }

        [Description("هزینه قابل پرداخت")]
        public decimal TotalPrice { get; set; }

        [Description("نحوه پرداخت")]
        public PaymentTypeEnum PaymentType { get; set; }
    }
}
