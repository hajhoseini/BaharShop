using BaharShop.Application.DTOs.Roles;
using BaharShop.Application.DTOs.Users;
using BaharShop.Application.Features.Users.Commands.Requests;
using BaharShop.Common;
using BaharShop.WebMVC.Models.AuthenticationViewModel;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BaharShop.WebMVC.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IMediator _mediator;

        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel request)
        {
            if (User.Identity.IsAuthenticated == true)
            {
                return Json(new ResultDTO { IsSuccess = false, Message = "شما به حساب کاربری خود وارد شده اید! و در حال حاضر نمی توانید ثبت نام مجدد نمایید" });
            }

            var command = new RegisterUserCommand()
            {
                RegisterUserDTO = new RegisterUserDTO()
                {
                    FullName = request.FullName,
                    Email = request.Email,
                    Password = request.Password,
                    RePassword = request.RePassword,
                    roles = new List<RoleDTO>()
                    {
                        new RoleDTO
                        {
                            Id = 3//UserRoles.Customer
                        }
                    }
                }
            };

            var signeUpResult = await _mediator.Send(command);

            if (signeUpResult.IsSuccess == true)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,signeUpResult.Data.Id.ToString()),
                    new Claim(ClaimTypes.Email, request.Email),
                    new Claim(ClaimTypes.Name, request.FullName),
                    new Claim(ClaimTypes.Role, "Customer"),
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties()
                {
                    IsPersistent = true
                };

                HttpContext.SignInAsync(principal, properties);
            }

            return Json(signeUpResult);
        }
    }
}
