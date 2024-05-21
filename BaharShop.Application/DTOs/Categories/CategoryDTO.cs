namespace BaharShop.Application.DTOs.Categories
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int? ParentId { get; set; }
    }
}
