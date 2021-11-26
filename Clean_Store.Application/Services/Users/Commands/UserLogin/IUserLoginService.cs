using Bugeto_Store.Common;
using Clean_Store.Application.Interfaces.Contexts;
using Clean_Store.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Store.Application.Services.Users.Commands.UserLogin
{
    public interface IUserLoginService
    {
        ResultDto<ResultUserloginDto> Execute(string Username, String Password);
    }

    public class UserLoginService : IUserLoginService
    {
        private readonly IDatabaseContext _context;
        public UserLoginService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultUserloginDto> Execute(string Username, string Password)
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                return new ResultDto<ResultUserloginDto>()
                {
                    Data = new ResultUserloginDto() { },
                    IsSuccess = false,
                    Message = "نام کاربری و رمز عبور را وارد نمایید",
                };
            }

            var user = _context.Users
                .Include(p => p.UserInRoles)
                .ThenInclude(p => p.Role)
                .Where(p => p.Email.Equals(Username) && p.IsActive)
                .FirstOrDefault();
            if (user == null)
            {
                return new ResultDto<ResultUserloginDto>()
                {
                    Data = new ResultUserloginDto() { },
                    IsSuccess = false,
                    Message = "این کاربر وجود ندارد",
                };
            }

            var passwordHasher = new PasswordHasher();
            bool resultVerifyPassword = passwordHasher.VerifyPassword(user.Password, Password);

            if (!resultVerifyPassword)
            {
                return new ResultDto<ResultUserloginDto>()
                {
                    Data = new ResultUserloginDto() { },
                    IsSuccess = false,
                    Message = "رمز وارد شده اشتباه است!",
                };
            }

            var roles = "";
            foreach (var item in user.UserInRoles)
            {
                roles += $"{item.Role.Name}";
            }

            return new ResultDto<ResultUserloginDto>()
            {
                Data = new ResultUserloginDto()
                {
                    Roles = roles,
                    UserId = user.Id,
                    Name = user.Fullname
                },
                IsSuccess = true,
                Message = "ورود به سایت با موفقیت انجام شد",
            };
        }
    }

    public class ResultUserloginDto
    {
        public long UserId { get; set; }
        public string Roles { get; set; }
        public string Name { get; set; }
    }
}
