using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Roles;
using BaharShop.Application.Features.Roles.Commands.Requests;

namespace BaharShop.Application.Features.Roles.Commands.RequestHandlers
{
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, ResultDTO>
	{
		private readonly IGenericRepository<Role> _genericRepository;
		private readonly IMapper _mapper;

		public CreateRoleCommandHandler(IGenericRepository<Role> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Role>(request.RoleDTO);
            var result = await _genericRepository.Create(entity);
            return result;
        }
    }
}
