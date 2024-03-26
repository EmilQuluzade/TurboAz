using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Turbo.az.Extensions;
using Turbo.az.Models;
using static Turbo.az.Extensions.EmailSender;

namespace Turbo.az.Controllers
{
    public class AccountController : Controller
    {
        private readonly IEmailService _emailSender;
        private readonly ILogger<AccountController> _logger;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        

        public AccountController(ILogger<AccountController> logger, UserManager<User> userManager, SignInManager<User> signInManager, IEmailService emailSender)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    await _signInManager.SignInAsync(user, model.RememberMe);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid credentials");
                    return View(model);
                }
            }
            return View(model);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (email == "" || email == null || !email.Contains("@"))
            {
                ModelState.AddModelError(string.Empty, "Email format is not correct");
                return View();
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var resetLink = Url.Action("ResetPassword", "Account" , new { email = email, token }, Request.Scheme);
                await _emailSender.SendEmailAsync(email, "Reset Password", resetLink);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public async Task<IActionResult> ResetPassword(string email, string token)
        {
            var user = await _userManager.FindByEmailAsync(email);

            ResetPasswordVM reset = new ResetPasswordVM
            {
                Token = token,
                Email = email,
            };
            return View(reset);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetVM)
        {
            if (!ModelState.IsValid)
            {
                return View(resetVM);
            }
            var user = await _userManager.FindByEmailAsync(resetVM.Email);
            if(user != null)
            {
                var result = await _userManager.ResetPasswordAsync(user, resetVM.Token, resetVM.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVm model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = new User { UserName = model.UserName, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User"); 
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View();
        }
    }
}
