using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Roles;
using BaharShop.Application.Features.Roles.Commands.Requests;

namespace BaharShop.Application.Features.Roles.Commands.RequestHandlers
{
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, ResultDTO>
	{
		private readonly IGenericRepository<Role> _genericRepository;

		public DeleteRoleCommandHandler(IGenericRepository<Role> genericRepository)
		{
			_genericRepository = genericRepository;
		}

        public async Task<ResultDTO> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            Role Role = new Role { Id = request.Id };
            var result = await _genericRepository.Delete(Role);
            return result;
        }
    }
}
