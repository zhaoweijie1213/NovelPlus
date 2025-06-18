using System.Linq;
using System.Collections.Generic;
using AuthService.Service.Domain.Entities;

namespace AuthService.Service.Application;

/// <summary>
/// 认证服务实现
/// </summary>
public class AuthService : IAuthService
{
    private readonly List<User> _users = new()
    {
        new User { Id = 1, UserName = "test", PasswordHash = "pwd" }
    };

    /// <inheritdoc/>
    public User? Login(string userName, string password)
    {
        return _users.FirstOrDefault(u => u.UserName == userName && u.PasswordHash == password);
    }
}
