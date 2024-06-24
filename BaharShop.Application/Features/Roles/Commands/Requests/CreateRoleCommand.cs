using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.Roles;

namespace BaharShop.Application.Features.Roles.Commands.Requests
{
    public class CreateRoleCommand : IRequest<ResultDTO>
	{
		public RoleDTO RoleDTO { get; set; }
	}
}
