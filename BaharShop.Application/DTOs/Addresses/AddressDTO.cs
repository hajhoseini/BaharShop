using System.ComponentModel;

namespace BaharShop.Application.DTOs.Addresses
{
    public class AddressDTO
    {
        public int Id { get; set; }
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
