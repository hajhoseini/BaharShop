using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.UserRoles;
using BaharShop.Application.Features.UserRoles.Commands.Requests;

namespace BaharShop.Application.Features.UserRoles.Commands.RequestHandlers
{
    public class CreateUserRoleCommandHandler : IRequestHandler<CreateUserRoleCommand, ResultDTO>
	{
		private readonly IGenericRepository<UserRole> _genericRepository;
		private readonly IMapper _mapper;

		public CreateUserRoleCommandHandler(IGenericRepository<UserRole> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(CreateUserRoleCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<UserRole>(request.userRoleDTO);
            var result = await _genericRepository.Create(entity);
            return result;
        }
    }
}
