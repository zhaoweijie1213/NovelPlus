using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 友情链接仓储接口
/// </summary>
public interface IFriendLinkRepository : ITransientDependency
{
    /// <summary>
    /// 查询友情链接
    /// </summary>
    Task<FriendLinkEntity?> GetAsync(int id);

    /// <summary>
    /// 友情链接列表
    /// </summary>
    Task<List<FriendLinkEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 友情链接数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增友情链接
    /// </summary>
    Task<int> SaveAsync(FriendLinkEntity link);

    /// <summary>
    /// 更新友情链接
    /// </summary>
    Task<int> UpdateAsync(FriendLinkEntity link);

    /// <summary>
    /// 删除友情链接
    /// </summary>
    Task<int> RemoveAsync(int id);

    /// <summary>
    /// 批量删除友情链接
    /// </summary>
    Task<int> BatchRemoveAsync(int[] ids);
}
