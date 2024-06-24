using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Roles;
using BaharShop.Application.Features.Roles.Queries.Requests;
using BaharShop.Application.DTOs.Roles;

namespace BaharShop.Application.Features.Roles.Queries.RequestHandlers
{
    public class GetListRolesQueryHandler : IRequestHandler<GetListRolesQuery, List<RoleDTO>>
	{
		private readonly IMapper _mapper;
		private readonly IRoleReader _roleReader;

		public GetListRolesQueryHandler(IMapper mapper, IRoleReader roleReader)
		{
			_mapper = mapper;
			_roleReader = roleReader;
		}

		public async Task<List<RoleDTO>> Handle(GetListRolesQuery request, CancellationToken cancellationToken)
		{
			var all = await _roleReader.GetList(null, null);
			return _mapper.Map<List<RoleDTO>>(all.ToList());
		}
	}
}