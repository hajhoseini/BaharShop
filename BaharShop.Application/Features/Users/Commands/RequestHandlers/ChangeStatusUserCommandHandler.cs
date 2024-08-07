using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Users;
using BaharShop.Application.Features.Users.Commands.Requests;
using BaharShop.Domain.IReaders;

namespace BaharShop.Application.Features.Users.Commands.RequestHandlers
{
    public class ChangeStatusUserCommandHandler : IRequestHandler<ChangeStatusUserCommand, ResultDTO>
	{
		private readonly IGenericRepository<User> _genericRepository;
        private readonly IGenericReader<User> _genericReader;

		public ChangeStatusUserCommandHandler(IGenericRepository<User> genericRepository, IGenericReader<User> genericReader)
		{
			_genericRepository = genericRepository;
            _genericReader = genericReader;
		}

        public async Task<ResultDTO> Handle(ChangeStatusUserCommand request, CancellationToken cancellationToken)
        {
            var entity = await _genericReader.GetById(request.UserDTO.Id);
            entity.IsActive = !entity.IsActive;
            var result = await _genericRepository.Update(entity);
            return result;
        }
    }
}
