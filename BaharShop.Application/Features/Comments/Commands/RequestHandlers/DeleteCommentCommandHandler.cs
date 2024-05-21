using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Comments;
using BaharShop.Application.Features.Comments.Commands.Requests;

namespace BaharShop.Application.Features.Comments.Commands.RequestHandlers
{
    public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommand, ResultDTO>
	{
		private readonly IGenericRepository<Comment> _genericRepository;

		public DeleteCommentCommandHandler(IGenericRepository<Comment> genericRepository)
		{
			_genericRepository = genericRepository;
		}

        public async Task<ResultDTO> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            Comment comment = new Comment { Id = request.Id };
            var result = await _genericRepository.Delete(comment);
            return result;
        }
    }
}
