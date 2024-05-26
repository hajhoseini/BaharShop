using BaharShop.Domain.Entities.Base;
using System.ComponentModel;

namespace BaharShop.Domain.Entities.Addresses
{
    public class Address : BaseEntity
    {
        [Description("عنوان آدرس")]
        public string Title { get; set; }

        [Description("مشتری")]
        public int CustomerId { get; set; }

        [Description("شهر محل سکونت")]
        public int CityId { get; set; }

        [Description("نشانی پستی")]
        public string Street { get; set; }

        [Description("کدپستی")]
        public string ZipCode { get; set; }
    }
}
