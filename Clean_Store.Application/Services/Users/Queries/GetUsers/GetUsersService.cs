using Clean_Store.Application.Interfaces.Contexts;
using Clean_Store.Common;
using System.Collections.Generic;
using System.Linq;

namespace Clean_Store.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersService
    {
        private readonly IDatabaseContext _context;
        public GetUsersService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultGetUserDto Execute(RequestGetUserDto request)
        {
            var users = _context.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.SearchKey))
            {
                users = users.Where(p => p.Fullname.Contains(request.SearchKey) && p.Email.Contains(request.SearchKey));
            }
            int rowsCount = 0;
            var userList = users.ToPaged(request.Page, 20, out rowsCount).Select(p => new GetUsersDto
            {
                Id = p.Id,
                Fullname = p.Fullname,
                Email = p.Email,
                IsActive = p.IsActive
            }).ToList();

            return new ResultGetUserDto
            {
                Rows = rowsCount,
                Users = userList
            };
        }
    }
}
