namespace BaharShop.Application.DTOs.Users
{
    public class UsersListAdminPanelDTO
    {
        public List<UserDTO> Users { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public int RowCount { get; set; }
    }
}
