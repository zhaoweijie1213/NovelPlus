using System.Collections.Generic;
using System.Linq;
using UserService.Service.Domain.Entities;

namespace UserService.Service.Application
{
    /// <summary>
    /// 用户业务实现
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// 内置的用户列表，模拟数据存储
        /// </summary>
        private readonly List<User> _users = new()
        {
            new User { Id = 1, UserName = "Alice", Email = "alice@example.com" },
            new User { Id = 2, UserName = "Bob", Email = "bob@example.com" }
        };

        /// <inheritdoc />
        public IEnumerable<User> GetAll() => _users;

        /// <inheritdoc />
        public User? GetById(int id) => _users.FirstOrDefault(u => u.Id == id);
    }
}
