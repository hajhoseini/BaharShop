namespace BaharShop.WebMVC.Areas.Admin.Models.CategoryViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool HasChild { get; set; }

        public int? ParentId { get; set; }

        public string ParentName { get; set; }
    }
}