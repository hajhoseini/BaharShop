using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Comments;
using BaharShop.Application.Features.Comments.Commands.Requests;

namespace BaharShop.Application.Features.Comments.Commands.RequestHandlers
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, ResultDTO>
	{
		private readonly IGenericRepository<Comment> _genericRepository;
		private readonly IMapper _mapper;

		public CreateCommentCommandHandler(IGenericRepository<Comment> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Comment>(request.commentDTO);
            var result = await _genericRepository.Create(entity);
            return result;
        }
    }
}
