using AuthService.Service.Domain.Entities;

namespace AuthService.Service.Application;

/// <summary>
/// 认证服务接口
/// </summary>
public interface IAuthService
{
    /// <summary>
    /// 登录验证
    /// </summary>
    /// <param name="userName">用户名</param>
    /// <param name="password">密码</param>
    /// <returns>用户信息</returns>
    User? Login(string userName, string password);
}
