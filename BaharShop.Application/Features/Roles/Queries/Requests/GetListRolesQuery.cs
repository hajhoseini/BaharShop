using MediatR;
using BaharShop.Application.DTOs.Roles;

namespace BaharShop.Application.Features.Roles.Queries.Requests
{
    public class GetListRolesQuery : IRequest<List<RoleDTO>>
    {

    }
}