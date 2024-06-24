using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Users;
using BaharShop.Application.Features.Users.Queries.Requests;
using BaharShop.Application.DTOs.Users;

namespace BaharShop.Application.Features.Users.Queries.RequestHandlers
{
    public class GetListUsersQueryHandler : IRequestHandler<GetListUsersQuery, List<UserDTO>>
	{
		private readonly IMapper _mapper;
		private readonly IUserReader _userReader;

		public GetListUsersQueryHandler(IMapper mapper, IUserReader userReader)
		{
			_mapper = mapper;
			_userReader = userReader;
		}

		public async Task<List<UserDTO>> Handle(GetListUsersQuery request, CancellationToken cancellationToken)
		{
			var all = await _userReader.GetList(null, null);
			return _mapper.Map<List<UserDTO>>(all.ToList());
		}
	}
}