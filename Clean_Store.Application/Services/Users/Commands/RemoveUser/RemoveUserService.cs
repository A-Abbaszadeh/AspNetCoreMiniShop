using Clean_Store.Application.Interfaces.Contexts;
using Clean_Store.Common.Dto;
using System;

namespace Clean_Store.Application.Services.Users.Commands.RemoveUser
{
    public class RemoveUserService : IRemoveUserService
    {
        private readonly IDatabaseContext _context;
        public RemoveUserService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(long UserId)
        {
            try
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
                user.RemoveTime = DateTime.Now;
                user.IsRemoved = true;
                _context.SaveChanges();
                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "کاربر با موفقیت حذف گردید"
                };
            }
            catch (Exception)
            {

                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "عمل حذف به دلایل نامعلوم انجام نشد"
                };
            }
        }
    }
}
