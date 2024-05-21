using MediatR;
using BaharShop.Common;

namespace BaharShop.Application.Features.Comments.Commands.Requests
{
    public class DeleteCommentCommand : IRequest<ResultDTO>
	{
		public int Id { get; set; }
	}
}
