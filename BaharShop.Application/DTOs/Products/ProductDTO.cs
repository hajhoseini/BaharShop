using Microsoft.AspNetCore.Http;

namespace BaharShop.Application.DTOs.Products
{
    public class ProductDTO
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public int CategoryId { get; set; }
        
        public decimal Price { get; set; }
        
        public int? Inventory { get; set; }
        
        public bool? IsActive { get; set; }

        public List<ProductFeatureDTO> Features { get; set; }

        public List<IFormFile> Images { get; set; }
    }
}
