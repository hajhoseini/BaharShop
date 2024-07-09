using AutoMapper;
using BaharShop.Application.DTOs.Users;
using BaharShop.Application.Features.Users.Queries.Requests;
using BaharShop.Common;
using BaharShop.Domain.Entities.Users;
using BaharShop.Domain.IReaders.Users;
using MediatR;

namespace BaharShop.Application.Features.Users.Queries.RequestHandlers
{
    public class SginInQueryHandler : IRequestHandler<SignInQuery, ResultDTO<UserDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUserReader _userReader;

        public SginInQueryHandler(IUserReader userReader, IMapper mapper)
        {
            _userReader = userReader;
            _mapper = mapper;
        }

        public async Task<ResultDTO<UserDTO>> Handle(SignInQuery request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.UserName) || string.IsNullOrWhiteSpace(request.Password))
            {
                return new ResultDTO<UserDTO>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "نام کاربری و رمز عبور را وارد نمایید"
                };
            }

            var result = await _userReader.GetList();
            if (result == null)
            {
                return new ResultDTO<UserDTO>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "کاربری با این ایمیل در سایت فروشگاه بهار ثبت نام نکرده است"
                };
            }

            User user = result.ToList().FirstOrDefault(x => x.Email == request.UserName);
            if (user == null)
            {
                return new ResultDTO<UserDTO>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "کاربری با این ایمیل در سایت فروشگاه بهار ثبت نام نکرده است"
                };
            }

            var passwordHasher = new PasswordHasher();
            bool resultVerifyPassword = passwordHasher.VerifyPassword(user.Password, request.Password);
            if (resultVerifyPassword == false)
            {
                return new ResultDTO<UserDTO>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "رمز وارد شده اشتباه است!"
                };
            }

            var roles = "";
            if (user.UserRoles != null)
            {
                foreach (var item in user.UserRoles)
                {
                    roles += $"{item.Role.Name}";
                }
            }

            var userDTO = _mapper.Map<UserDTO>(user);

            userDTO.Roles = roles;

            return new ResultDTO<UserDTO>()
            {
                Data = userDTO,
                IsSuccess = true,
                Message = "ورود به سایت با موفقیت انجام شد"
            };
        }
    }
}