using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Users;
using BaharShop.Application.Features.Users.Commands.Requests;
using BaharShop.Domain.IReaders;

namespace BaharShop.Application.Features.Users.Commands.RequestHandlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, ResultDTO>
	{
		private readonly IGenericRepository<User> _genericRepository;
        private readonly IGenericReader<User> _genericReader;
        private readonly IMapper _mapper;

		public UpdateUserCommandHandler(IGenericRepository<User> genericRepository, IGenericReader<User> genericReader, IMapper mapper)
		{
			_genericRepository = genericRepository;
            _genericReader = genericReader;
            _mapper = mapper;
		}

        public async Task<ResultDTO> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var entity = await _genericReader.GetById(request.UserDTO.Id);
            entity.FullName = request.UserDTO.FullName;            
            var result = await _genericRepository.Update(entity);
            return result;
        }
    }
}
