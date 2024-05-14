using BaharShop.Domain.Entities.Base;

namespace BaharShop.Domain.Entities.Addresses
{
    public class Address : BaseEntity
    {
        public string Title { get; set; }
        public int CustomerId { get; set; }
        public int CityId { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }
}
