using MediatR;
using BaharShop.Common;

namespace BaharShop.Application.Features.Users.Commands.Requests
{
    public class DeleteUserCommand : IRequest<ResultDTO>
	{
		public int Id { get; set; }
	}
}
