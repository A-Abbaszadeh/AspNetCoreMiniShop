using System.Collections.Generic;

namespace Clean_Store.Application.Services.Users.Queries.GetUsers
{
    public class ResultGetUserDto
    {
        public List<GetUsersDto> Users { get; set; }
        public int Rows { get; set; }
    }
}
