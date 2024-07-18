using MediatR;
using BaharShop.Application.DTOs.Users;
using BaharShop.Common;

namespace BaharShop.Application.Features.Users.Queries.Requests
{
    public class GetListUsersInAdminPanelQuery : IRequest<ResultDTO<UsersListAdminPanelDTO>>
    {
        public int CurrentPage { get; set; }

        public int PageSize { get; set; }
    }
}