using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Roles;
using BaharShop.Application.Features.Roles.Commands.Requests;

namespace BaharShop.Application.Features.Roles.Commands.RequestHandlers
{
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand, ResultDTO>
	{
		private readonly IGenericRepository<Role> _genericRepository;
		private readonly IMapper _mapper;

		public UpdateRoleCommandHandler(IGenericRepository<Role> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Role>(request.RoleDTO);
            var result = await _genericRepository.Update(entity);
            return result;
        }
    }
}
