using NovelPlus.Portal.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Application.Interfaces;

/// <summary>
/// 用户服务接口
/// </summary>
public interface IUserService : IScopeDependency
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
