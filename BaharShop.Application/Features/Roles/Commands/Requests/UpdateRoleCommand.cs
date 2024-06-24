using BaharShop.Application.DTOs.Roles;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Roles.Commands.Requests
{
    public class UpdateRoleCommand : IRequest<ResultDTO>
	{
        public RoleDTO RoleDTO { get; set; }
    }
}
