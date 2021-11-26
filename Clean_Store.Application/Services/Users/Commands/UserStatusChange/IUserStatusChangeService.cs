using Clean_Store.Application.Interfaces.Contexts;
using Clean_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Store.Application.Services.Users.Commands.UserStatusChange
{
    public interface IUserStatusChangeService
    {
        ResultDto Execute(long UserId);
    }

    public class UserStatusChangeService : IUserStatusChangeService
    {
        private readonly IDatabaseContext _context;
        public UserStatusChangeService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(long UserId)
        {
            var user = _context.Users.Find(UserId);
            if (user == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کاربر یافت نشد"
                };
            }
            user.IsActive = !user.IsActive;
            string userstate = user.IsActive ?" فعال ":" غیرفعال ";
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
                Message = $"کاربر با موفقیت {userstate} گردید"
            };

        }
    }
}
