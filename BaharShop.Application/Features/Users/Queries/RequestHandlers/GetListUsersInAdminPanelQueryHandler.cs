using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Users;
using BaharShop.Application.DTOs.Users;
using BaharShop.Application.Features.Users.Queries.Requests;
using BaharShop.Common;

namespace BaharShop.Application.Features.Users.Queries.RequestHandlers
{
    public class GetListUsersInAdminPanelQueryHandler : IRequestHandler<GetListUsersInAdminPanelQuery, ResultDTO<UsersListAdminPanelDTO>>
	{
		private readonly IMapper _mapper;
		private readonly IUserReader _userReader;

		public GetListUsersInAdminPanelQueryHandler(IMapper mapper, IUserReader userReader)
		{
			_mapper = mapper;
			_userReader = userReader;
		}

		public async Task<ResultDTO<UsersListAdminPanelDTO>> Handle(GetListUsersInAdminPanelQuery request, CancellationToken cancellationToken)
		{
            int rowCount = 0;

            var Users = _userReader.GetListUsersInAdminPanel(request.CurrentPage, request.PageSize, out rowCount);

            return new ResultDTO<UsersListAdminPanelDTO>()
            {
                Data = new UsersListAdminPanelDTO()
                {
                    Users = _mapper.Map<List<UserDTO>>(Users),
                    CurrentPage = request.CurrentPage,
                    PageSize = request.PageSize,
                    RowCount = rowCount
                },
                IsSuccess = true,
                Message = "",
            };
        }
    }
}