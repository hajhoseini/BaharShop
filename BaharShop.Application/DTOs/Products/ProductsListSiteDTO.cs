namespace BaharShop.Application.DTOs.Products
{
    public class ProductsListSiteDTO
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string ImageSrc { get; set; }

        public int Star { get; set; }

        public decimal Price { get; set; }
    }

    public class ResultProductsListSiteDTO
    {
        public List<ProductsListSiteDTO> Products { get; set; }

        public int TotalRow { get; set; }
    }
}
