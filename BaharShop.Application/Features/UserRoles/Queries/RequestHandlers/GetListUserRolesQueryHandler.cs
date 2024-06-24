using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.UserRoles;
using BaharShop.Application.Features.UserRoles.Queries.Requests;
using BaharShop.Application.DTOs.UserRoles;

namespace BaharShop.Application.Features.UserRoles.Queries.RequestHandlers
{
    public class GetListUserRolesQueryHandler : IRequestHandler<GetListUserRolesQuery, List<UserRoleDTO>>
	{
		private readonly IMapper _mapper;
		private readonly IUserRoleReader _userRoleReader;

		public GetListUserRolesQueryHandler(IMapper mapper, IUserRoleReader userRoleReader)
		{
			_mapper = mapper;
			_userRoleReader = userRoleReader;
		}

		public async Task<List<UserRoleDTO>> Handle(GetListUserRolesQuery request, CancellationToken cancellationToken)
		{
			var all = await _userRoleReader.GetList(null, null);
			return _mapper.Map<List<UserRoleDTO>>(all.ToList());
		}
	}
}