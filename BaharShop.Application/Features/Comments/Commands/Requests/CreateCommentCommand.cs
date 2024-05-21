using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.Comments;

namespace BaharShop.Application.Features.Comments.Commands.Requests
{
    public class CreateCommentCommand : IRequest<ResultDTO>
	{
		public CommentDTO commentDTO { get; set; }
	}
}
