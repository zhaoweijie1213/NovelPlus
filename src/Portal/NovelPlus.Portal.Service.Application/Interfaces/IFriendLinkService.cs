using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Portal.Service.Domain.Entities;

namespace NovelPlus.Portal.Service.Application.Interfaces;

/// <summary>
/// 友情链接服务接口
/// </summary>
public interface IFriendLinkService
{
    /// <summary>
    /// 查询首页友情链接
    /// </summary>
    Task<List<FriendLinkEntity>> ListIndexLinkAsync();
}
