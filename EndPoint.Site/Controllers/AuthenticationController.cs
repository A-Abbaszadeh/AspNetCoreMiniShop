using Clean_Store.Application.Services.Users.Commands.RegisterUser;
using Clean_Store.Application.Services.Users.Commands.UserLogin;
using Clean_Store.Common.Dto;
using EndPoint.Site.Models.ViewModels.AuthenticationViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EndPoint.Site.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IRegisterUserService _registerUserService;
        private readonly IUserLoginService _userLoginService;
        public AuthenticationController(IRegisterUserService registerUserService, IUserLoginService userLoginService)
        {
            _registerUserService = registerUserService;
            _userLoginService = userLoginService;
        }
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(SignupViewModel request)
        {
            if (string.IsNullOrWhiteSpace(request.FullName) ||
                string.IsNullOrWhiteSpace(request.Email) ||
                string.IsNullOrWhiteSpace(request.Password) ||
                string.IsNullOrWhiteSpace(request.RePassword))
            {
                return Json(new ResultDto
                { 
                    IsSuccess = false,
                    Message = "لطفا تمامی موارد رو کامل وارد نمایید"
                });
            }

            string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";

            var match = Regex.Match(request.Email, emailRegex, RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                return Json(new ResultDto
                { 
                    IsSuccess = true, 
                    Message = "ایمیل وارد شده صحیح نیست" 
                });
            }

            var signupResult = _registerUserService.Execute(new RequestRegisterUserDto
            {
                Fullname = request.FullName,
                Email = request.Email,
                Password = request.Password,
                RePasword = request.RePassword,
                Roles = new List<RolesInRegisterUserDto>
                {
                    new RolesInRegisterUserDto { Id = 3 }
                }
            });

            if (signupResult.IsSuccess)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,signupResult.Data.UserId.ToString()),
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
            return Json(signupResult);
        }
    }
}
