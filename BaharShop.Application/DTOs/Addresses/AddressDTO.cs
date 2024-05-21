namespace BaharShop.Application.DTOs.Addresses
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CustomerId { get; set; }
        public int CityId { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }
}
