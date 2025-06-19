using System;
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
            new User { Id = 1, Username = "Alice", NickName = "Alice", Email = "alice@example.com" },
            new User { Id = 2, Username = "Bob", NickName = "Bob", Email = "bob@example.com" }
        };

        /// <inheritdoc />
        public IEnumerable<User> GetAll() => _users;

        /// <inheritdoc />
        public User? GetById(long id) => _users.FirstOrDefault(u => u.Id == id);

        /// <inheritdoc />
        public IEnumerable<User> List(IDictionary<string, object> filters) => _users;

        /// <inheritdoc />
        public int Count(IDictionary<string, object> filters) => _users.Count;

        /// <inheritdoc />
        public int Save(User user)
        {
            user.Id = _users.Max(u => u.Id) + 1;
            _users.Add(user);
            return 1;
        }

        /// <inheritdoc />
        public int Update(User user)
        {
            var index = _users.FindIndex(u => u.Id == user.Id);
            if (index == -1) return 0;
            _users[index] = user;
            return 1;
        }

        /// <inheritdoc />
        public int Remove(long id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return 0;
            _users.Remove(user);
            return 1;
        }

        /// <inheritdoc />
        public int BatchRemove(long[] ids)
        {
            var removed = 0;
            foreach (var id in ids) removed += Remove(id);
            return removed;
        }

        /// <inheritdoc />
        public IDictionary<object, object> TableStat(DateTime minDate)
        {
            return new Dictionary<object, object>();
        }
    }
}
