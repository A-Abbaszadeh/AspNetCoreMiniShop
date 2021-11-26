using Clean_Store.Domain.Entities.Commons;

namespace Clean_Store.Domain.Entities.Users
{
    public class UserInRole : BaseEntity
    {
        public virtual User User { get; set; }
        public long UserId { get; set; }
        public virtual Role Role { get; set; }
        public long RoleId { get; set; }
    }
}
