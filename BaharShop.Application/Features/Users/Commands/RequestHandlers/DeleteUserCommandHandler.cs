using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Users;
using BaharShop.Application.Features.Users.Commands.Requests;

namespace BaharShop.Application.Features.Users.Commands.RequestHandlers
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, ResultDTO>
	{
		private readonly IGenericRepository<User> _genericRepository;

		public DeleteUserCommandHandler(IGenericRepository<User> genericRepository)
		{
			_genericRepository = genericRepository;
		}

        public async Task<ResultDTO> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            User user = new User { Id = request.Id };
            var result = await _genericRepository.Delete(user);
            return result;
        }
    }
}
