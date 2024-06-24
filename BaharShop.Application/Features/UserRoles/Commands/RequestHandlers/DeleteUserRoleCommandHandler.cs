using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.UserRoles;
using BaharShop.Application.Features.UserRoles.Commands.Requests;

namespace BaharShop.Application.Features.UserRoles.Commands.RequestHandlers
{
    public class DeleteUserRoleCommandHandler : IRequestHandler<DeleteUserRoleCommand, ResultDTO>
	{
		private readonly IGenericRepository<UserRole> _genericRepository;

		public DeleteUserRoleCommandHandler(IGenericRepository<UserRole> genericRepository)
		{
			_genericRepository = genericRepository;
		}

        public async Task<ResultDTO> Handle(DeleteUserRoleCommand request, CancellationToken cancellationToken)
        {
            UserRole UserRole = new UserRole { Id = request.Id };
            var result = await _genericRepository.Delete(UserRole);
            return result;
        }
    }
}
