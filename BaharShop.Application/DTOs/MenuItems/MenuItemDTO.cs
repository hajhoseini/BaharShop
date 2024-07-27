namespace BaharShop.Application.DTOs.MenuItems
{
    public class MenuItemDTO
    {
        public int CategotyId { get; set; }

        public string Name { get; set; }

        public List<MenuItemDTO> Children { get; set; }
    }
}
