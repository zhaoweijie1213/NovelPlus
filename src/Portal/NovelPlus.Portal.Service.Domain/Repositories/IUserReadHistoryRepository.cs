using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Portal.Service.Domain.Entities;

namespace NovelPlus.Portal.Service.Domain.Repositories;

/// <summary>
/// 用户阅读历史仓储接口
/// </summary>
public interface IUserReadHistoryRepository
{
    /// <summary>
    /// 查询阅读记录
    /// </summary>
    /// <param name="id">记录ID</param>
    /// <returns>阅读记录</returns>
    Task<UserReadHistoryEntity?> GetAsync(long id);

    /// <summary>
    /// 阅读记录列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>阅读记录集合</returns>
    Task<List<UserReadHistoryEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 阅读记录数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>数量</returns>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增阅读记录
    /// </summary>
    /// <param name="entity">阅读记录</param>
    Task<int> SaveAsync(UserReadHistoryEntity entity);

    /// <summary>
    /// 更新阅读记录
    /// </summary>
    /// <param name="entity">阅读记录</param>
    Task<int> UpdateAsync(UserReadHistoryEntity entity);

    /// <summary>
    /// 删除阅读记录
    /// </summary>
    /// <param name="id">记录ID</param>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除阅读记录
    /// </summary>
    /// <param name="ids">记录ID集合</param>
    Task<int> BatchRemoveAsync(long[] ids);

    /// <summary>
    /// 查询用户阅读记录
    /// </summary>
    /// <param name="userId">用户ID</param>
    /// <returns>阅读记录集合</returns>
    Task<List<UserReadHistoryEntity>> ListReadHistoryAsync(long userId);
}
