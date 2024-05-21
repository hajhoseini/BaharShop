using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Comments;
using BaharShop.Application.DTOs.Comments;
using BaharShop.Application.Features.Comments.Queries.Requests;

namespace BaharShop.Application.Features.Comments.Queries.RequestHandlers
{
    public class GetListCommentsQueryHandler : IRequestHandler<GetListCommentsQuery, List<CommentDTO>>
	{
		private readonly IMapper _mapper;
		private readonly ICommentReader _commentReader;

		public GetListCommentsQueryHandler(IMapper mapper, ICommentReader commentReader)
		{
			_mapper = mapper;
			_commentReader = commentReader;
		}

		public async Task<List<CommentDTO>> Handle(GetListCommentsQuery request, CancellationToken cancellationToken)
		{
			var all = await _commentReader.GetList(null, null);
			return _mapper.Map<List<CommentDTO>>(all.ToList());
		}
	}
}