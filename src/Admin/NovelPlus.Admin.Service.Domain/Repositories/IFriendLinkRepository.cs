using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 友情链接仓储接口
/// </summary>
public interface IFriendLinkRepository
{
    Task<FriendLinkEntity?> GetAsync(int id);

    Task<List<FriendLinkEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(FriendLinkEntity link);

    Task<int> UpdateAsync(FriendLinkEntity link);

    Task<int> RemoveAsync(int id);

    Task<int> BatchRemoveAsync(int[] ids);
}
