using MediatR;
using BaharShop.Application.DTOs.Roles;

namespace BaharShop.Application.Features.Roles.Queries.Requests
{
    public class GetRoleQuery : IRequest<RoleDTO>
    {
        public int Id { get; set; }
    }
}