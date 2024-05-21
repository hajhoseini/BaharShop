using BaharShop.Application.DTOs.Comments;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Comments.Commands.Requests
{
    public class UpdateCommentCommand : IRequest<ResultDTO>
	{
        public CommentDTO commentDTO { get; set; }
    }
}
