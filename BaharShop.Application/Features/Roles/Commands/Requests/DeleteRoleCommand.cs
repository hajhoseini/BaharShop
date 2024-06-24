using MediatR;
using BaharShop.Common;

namespace BaharShop.Application.Features.Roles.Commands.Requests
{
    public class DeleteRoleCommand : IRequest<ResultDTO>
	{
		public int Id { get; set; }
	}
}
