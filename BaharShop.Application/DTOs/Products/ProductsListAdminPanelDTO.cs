namespace BaharShop.Application.DTOs.Products
{
    public class ProductsListAdminPanelDTO
    {
        public List<ProductDTO> Products { get; set; }        

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public int RowCount { get; set; }
    }
}
