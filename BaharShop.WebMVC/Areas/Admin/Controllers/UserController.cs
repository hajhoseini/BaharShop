using BaharShop.Application.DTOs.Roles;
using BaharShop.Application.DTOs.Users;
using BaharShop.Application.Features.Roles.Queries.Requests;
using BaharShop.Application.Features.Users.Commands.Requests;
using BaharShop.Application.Features.Users.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BaharShop.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index(int Page = 1, int PageSize = 5)
        {
            GetListUsersInAdminPanelQuery query = new GetListUsersInAdminPanelQuery()
            {
                CurrentPage = Page,
                PageSize = PageSize
            };
            var result = await _mediator.Send(query);
            return View(result.Data);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            GetListRolesQuery query = new GetListRolesQuery();
            var roles = await _mediator.Send(query);

            ViewBag.Roles = new SelectList(roles, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(string Email, string FullName, int RoleId, string Password, string RePassword)
        {
            var command = new RegisterUserCommand()
            {
                RegisterUserDTO = new RegisterUserDTO()
                {
                    FullName = FullName,
                    Email = Email,
                    Password = Password,
                    RePassword = RePassword,
                    roles = new List<RoleDTO>()
                    {
                        new RoleDTO
                        {
                            Id = RoleId
                        }
                    }
                }
            };

            var result = await _mediator.Send(command);

            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int userId)
        {
            DeleteUserCommand command = new DeleteUserCommand() { Id = userId };
            var result = await _mediator.Send(command);
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> UserSatusChange(int userId)
        {
            ChangeStatusUserCommand command = new ChangeStatusUserCommand()
            {
                UserDTO = new UserDTO()
                {
                    Id = userId
                },
            };

            var result = await _mediator.Send(command);

            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int userId, string fullname)
        {
            UpdateUserCommand command = new UpdateUserCommand()
            {
                UserDTO = new UserDTO()
                {
                    Id = userId,
                    FullName = fullname
                },
            };

            var result = await _mediator.Send(command);
            //if (result.IsSuccess)
            //    return View("Index");

            return Json(result);
        }
    }
}
