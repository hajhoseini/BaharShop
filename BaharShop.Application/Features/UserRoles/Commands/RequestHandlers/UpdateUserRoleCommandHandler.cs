using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.UserRoles;
using BaharShop.Application.Features.UserRoles.Commands.Requests;

namespace BaharShop.Application.Features.UserRoles.Commands.RequestHandlers
{
    public class UpdateUserRoleCommandHandler : IRequestHandler<UpdateUserRoleCommand, ResultDTO>
	{
		private readonly IGenericRepository<UserRole> _genericRepository;
		private readonly IMapper _mapper;

		public UpdateUserRoleCommandHandler(IGenericRepository<UserRole> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(UpdateUserRoleCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<UserRole>(request.userRoleDTO);
            var result = await _genericRepository.Update(entity);
            return result;
        }
    }
}
