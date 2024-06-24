using BaharShop.Application.DTOs.UserRoles;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.UserRoles.Commands.Requests
{
    public class UpdateUserRoleCommand : IRequest<ResultDTO>
	{
        public UserRoleDTO userRoleDTO { get; set; }
    }
}
