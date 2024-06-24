using MediatR;
using BaharShop.Application.DTOs.UserRoles;

namespace BaharShop.Application.Features.UserRoles.Queries.Requests
{
    public class GetListUserRolesQuery : IRequest<List<UserRoleDTO>>
    {

    }
}