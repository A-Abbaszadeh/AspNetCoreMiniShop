using Clean_Store.Application.Interfaces.Contexts;
using Clean_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Store.Application.Services.Users.Commands.EditUser
{
    public interface IEditUserService
    {
        ResultDto Execute(RequestEditUserDto request);
    }
    public class EditUserService : IEditUserService
    {
        private readonly IDatabaseContext _context;
        public EditUserService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestEditUserDto request)
        {
            var user = _context.Users.Find(request.UserId);
            if (user == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کاربر یافت نشد"
                };
            }
            user.Email = request.Email;
            user.Fullname = request.Fullname;
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "مشخصات کاربر با موفقیت ویرایش گردید"
            };
        }
    }
    public class RequestEditUserDto
    {
        public long UserId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
    }
}
