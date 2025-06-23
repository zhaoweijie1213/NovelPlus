using NovelPlus.Portal.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Domain.Repositories;

/// <summary>
/// 友情链接仓储接口
/// </summary>
public interface IFriendLinkRepository : ITransientDependency
{
    /// <summary>
    /// 查询首页友情链接
    /// </summary>
    Task<List<FriendLinkEntity>> ListIndexLinkAsync();
}
