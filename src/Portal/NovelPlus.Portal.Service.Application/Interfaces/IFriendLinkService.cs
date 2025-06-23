using NovelPlus.Portal.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Application.Interfaces;

/// <summary>
/// 友情链接服务接口
/// </summary>
public interface IFriendLinkService : IScopeDependency
{
    /// <summary>
    /// 查询首页友情链接
    /// </summary>
    Task<List<FriendLinkEntity>> ListIndexLinkAsync();
}
