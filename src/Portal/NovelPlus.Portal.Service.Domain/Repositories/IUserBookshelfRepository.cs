using NovelPlus.Portal.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Domain.Repositories;

/// <summary>
/// 用户书架仓储接口
/// </summary>
public interface IUserBookshelfRepository : ITransientDependency
{
    /// <summary>
    /// 查询书架记录
    /// </summary>
    /// <param name="id">记录ID</param>
    /// <returns>书架记录</returns>
    Task<UserBookshelfEntity?> GetAsync(long id);

    /// <summary>
    /// 书架列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>书架集合</returns>
    Task<List<UserBookshelfEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 书架数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>数量</returns>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增书架记录
    /// </summary>
    /// <param name="entity">书架记录</param>
    Task<int> SaveAsync(UserBookshelfEntity entity);

    /// <summary>
    /// 更新书架记录
    /// </summary>
    /// <param name="entity">书架记录</param>
    Task<int> UpdateAsync(UserBookshelfEntity entity);

    /// <summary>
    /// 删除书架记录
    /// </summary>
    /// <param name="id">记录ID</param>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除书架记录
    /// </summary>
    /// <param name="ids">记录ID集合</param>
    Task<int> BatchRemoveAsync(long[] ids);

    /// <summary>
    /// 查询用户书架
    /// </summary>
    /// <param name="userId">用户ID</param>
    /// <returns>书架集合</returns>
    Task<List<UserBookshelfEntity>> ListBookShelfAsync(long userId);
}
