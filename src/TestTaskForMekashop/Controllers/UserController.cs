using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTaskForMekashop.DOMAIN.Extension;
using TestTaskForMekashop.DOMAIN.ViewModels.User;
using TestTaskForMekashop.Service.Interfaces;

namespace Automarket.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> GetUsers()
        {
            var response = await _userService.GetUsers();
            if (response.StatusCode == TestTaskForMekashop.DOMAIN.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Save() => PartialView();
                       
    }
}