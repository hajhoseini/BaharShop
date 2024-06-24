using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Users;
using BaharShop.Application.Features.Users.Commands.Requests;

namespace BaharShop.Application.Features.Users.Commands.RequestHandlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, ResultDTO>
	{
		private readonly IGenericRepository<User> _genericRepository;
		private readonly IMapper _mapper;

		public UpdateUserCommandHandler(IGenericRepository<User> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<User>(request.UserDTO);
            var result = await _genericRepository.Update(entity);
            return result;
        }
    }
}
