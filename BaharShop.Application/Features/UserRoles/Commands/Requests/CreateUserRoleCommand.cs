using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.UserRoles;

namespace BaharShop.Application.Features.UserRoles.Commands.Requests
{
    public class CreateUserRoleCommand : IRequest<ResultDTO>
	{
		public UserRoleDTO userRoleDTO { get; set; }
	}
}
