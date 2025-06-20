using System.Threading.Tasks;
using NovelPlus.Portal.Service.Domain.Entities;

namespace NovelPlus.Portal.Service.Application.Interfaces;

/// <summary>
/// 用户服务接口
/// </summary>
public interface IUserService
{
    /// <summary>
    /// 用户注册
    /// </summary>
    Task<UserEntity?> RegisterAsync(UserEntity user);

    /// <summary>
    /// 用户登录
    /// </summary>
    Task<UserEntity?> LoginAsync(UserEntity user);
}
