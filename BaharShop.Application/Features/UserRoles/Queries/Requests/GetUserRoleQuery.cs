using MediatR;
using BaharShop.Application.DTOs.UserRoles;

namespace BaharShop.Application.Features.UserRoles.Queries.Requests
{
    public class GetUserRoleQuery : IRequest<UserRoleDTO>
    {
        public int Id { get; set; }
    }
}