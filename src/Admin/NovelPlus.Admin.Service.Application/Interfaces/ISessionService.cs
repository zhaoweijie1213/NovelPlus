using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 会话管理服务接口
/// </summary>
public interface ISessionService : IScopeDependency
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
