using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServiceDeskAppProject.Models;
namespace ServiceDeskAppProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public AccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterModel());
        }

        public IActionResult Login()
        {
            return View();
        }

        private void AddToModelState(IEnumerable<IdentityError> identityError)
        {
            foreach (IdentityError item in identityError)
            {
                ModelState.AddModelError("", item.Description);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    Email = registerModel.Email,
                    UserName = registerModel.Username,
                     Name = registerModel.Name,
                     PhoneNumber = registerModel.PhoneNumber
                    
                };
                IdentityResult identityResult =
                               await _userManager.CreateAsync(appUser, registerModel.Password);

                if (!identityResult.Succeeded)
                {
                    AddToModelState(identityResult.Errors);
                    return View();
                }
                else
                    return RedirectToAction(nameof(Login));
            }
            else
                return View();
        }
    }
}