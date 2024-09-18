using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MixedShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            return View(new LogInViewModel
            {
                ReturnUrl = returnUrl
            });
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LogInViewModel logInViewModel)
        {
            if (!ModelState.IsValid)
                return View(logInViewModel);

            var user = await _userManager.FindByNameAsync(logInViewModel.UserName);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, logInViewModel.Password, false, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(logInViewModel.ReturnUrl))
                        return RedirectToAction("Index", "Home");

                    return Redirect(logInViewModel.ReturnUrl);
                }

            }

            ModelState.AddModelError("", "Username or password not found");
            return View(logInViewModel);
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Register(LogInViewModel logInViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = logInViewModel.UserName };
                var result = await _userManager.CreateAsync(user, logInViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(logInViewModel);

        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        
    }
}
