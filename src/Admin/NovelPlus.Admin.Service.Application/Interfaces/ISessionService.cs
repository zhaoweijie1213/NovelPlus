using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 会话管理服务接口
/// </summary>
public interface ISessionService
{
    /// <summary>
    /// 查询在线用户列表
    /// </summary>
    Task<List<SysUserEntity>> ListOnlineUsersAsync();

    /// <summary>
    /// 强制下线
    /// </summary>
    Task<bool> ForceLogoutAsync(string sessionId);
}
