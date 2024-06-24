using MediatR;
using BaharShop.Common;

namespace BaharShop.Application.Features.UserRoles.Commands.Requests
{
    public class DeleteUserRoleCommand : IRequest<ResultDTO>
	{
		public int Id { get; set; }
	}
}
